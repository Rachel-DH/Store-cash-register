using BlApi;
using BO;

namespace UI;

public partial class ProductsForm : Form
{
    private readonly IBl _bl;
    private readonly Form _previous;

    public ProductsForm(IBl bl, Form previous)
    {
        _bl = bl;
        _previous = previous;
        InitializeComponent();
        FormClosed += (s, e) => { if (!_previous.Visible) _previous.Show(); };
        cmbCategoryFilter.Items.Add("All");
        foreach (Category c in Enum.GetValues(typeof(Category)))
        {
            cmbCategoryFilter.Items.Add(c);
            cmbCreateCategory.Items.Add(c);
            cmbUpdateCategory.Items.Add(c);
        }
        cmbCategoryFilter.SelectedIndex = 0;
        cmbCreateCategory.SelectedIndex = 0;
        cmbUpdateCategory.SelectedIndex = 0;
        LoadAllProducts();
    }

    private void LoadAllProducts()
    {
        try
        {
            var products = _bl.product.ReadAll(null);
            dgvProducts.DataSource = products;
            if (products?.Count > 0)
            {
                int minId = products.Min(p => p!.Id);
                nudReadId.Minimum = minId;
                nudReadId.Value = minId;
                nudUpdateId.Minimum = minId;
                nudUpdateId.Value = minId;
                nudDeleteId.Minimum = minId;
                nudDeleteId.Value = minId;
            }
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
        try
        {
            if (cmbCategoryFilter.SelectedItem?.ToString() == "All") { LoadAllProducts(); return; }
            Category selected = (Category)cmbCategoryFilter.SelectedItem!;
            dgvProducts.DataSource = _bl.product.ReadAll(p => p.Category == selected);
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnClearFilter_Click(object sender, EventArgs e) { cmbCategoryFilter.SelectedIndex = 0; LoadAllProducts(); }

    private void btnRead_Click(object sender, EventArgs e)
    {
        try
        {
            int id = (int)nudReadId.Value;
            txtReadResult.Text = _bl.product.Read(id)?.ToString() ?? "Not found";
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
        try
        {
            if (!double.TryParse(txtCreatePrice.Text, out double price) || !int.TryParse(txtCreateAmount.Text, out int amount))
            { MessageBox.Show("Invalid price or amount"); return; }
            _bl.product.Create(new Product(0, txtCreateName.Text, (Category)cmbCreateCategory.SelectedItem!, price, amount, null));
            MessageBox.Show("Product added successfully");
            LoadAllProducts();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            if (!double.TryParse(txtUpdatePrice.Text, out double price) || !int.TryParse(txtUpdateAmount.Text, out int amount))
            { MessageBox.Show("Invalid input"); return; }
            int id = (int)nudUpdateId.Value;
            _bl.product.Update(new Product(id, txtUpdateName.Text, (Category)cmbUpdateCategory.SelectedItem!, price, amount, null));
            MessageBox.Show("Product updated successfully");
            LoadAllProducts();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            int id = (int)nudDeleteId.Value;
            _bl.product.Delete(id);
            MessageBox.Show("Product deleted successfully");
            LoadAllProducts();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnBack_Click(object sender, EventArgs e) { Close(); _previous.Show(); }
}
