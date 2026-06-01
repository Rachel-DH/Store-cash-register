using BlApi;
using BO;

namespace UI;

public partial class CashierForm : Form
{
    private readonly IBl _bl;
    private readonly Form _previous;
    private Order _currentOrder;

    public CashierForm(IBl bl, Form previous)
    {
        _bl = bl;
        _previous = previous;
        _currentOrder = new Order { Products = new List<ProductInOrder>(), IsMemberCustomer = false, TotalPrice = 0 };
        InitializeComponent();
        FormClosed += (s, e) => { if (!_previous.Visible) _previous.Show(); };
        LoadProductsCombo();
    }

    private void LoadProductsCombo()
    {
        try
        {
            cmbProducts.DataSource = _bl.product.ReadAll(null);
            cmbProducts.DisplayMember = "Name";
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void chkIsMember_CheckedChanged(object sender, EventArgs e) => _currentOrder.IsMemberCustomer = chkIsMember.Checked;

    private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbProducts.SelectedItem is Product p)
            txtProductId.Text = p.Id.ToString();
    }

    private void btnNewOrder_Click(object sender, EventArgs e)
    {
        _currentOrder = new Order { Products = new List<ProductInOrder>(), IsMemberCustomer = chkIsMember.Checked, TotalPrice = 0 };
        RefreshOrderDisplay();
    }

    private void btnAddProduct_Click(object sender, EventArgs e)
    {
        try
        {
            if (!int.TryParse(txtProductId.Text, out int productId)) { MessageBox.Show("Invalid product ID"); return; }
            int amount = (int)nudAmount.Value;
            if (amount <= 0) { MessageBox.Show("Invalid amount"); return; }
            _bl.order.AddProductToOrder(_currentOrder, productId, amount);
            RefreshOrderDisplay();
            txtProductId.Clear();
            nudAmount.Value = 1;
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnDoOrder_Click(object sender, EventArgs e)
    {
        try
        {
            if (_currentOrder.Products.Count == 0) { MessageBox.Show("Order is empty"); return; }
            _bl.order.DoOrder(_currentOrder);
            MessageBox.Show($"Order completed! Total: {_currentOrder.TotalPrice:F2}");
            _currentOrder = new Order { Products = new List<ProductInOrder>(), IsMemberCustomer = chkIsMember.Checked, TotalPrice = 0 };
            RefreshOrderDisplay();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnBack_Click(object sender, EventArgs e) { Close(); _previous.Show(); }

    private void RefreshOrderDisplay()
    {
        dgvOrderProducts.DataSource = null;
        dgvOrderProducts.DataSource = _currentOrder.Products;
        dgvSales.DataSource = _currentOrder.Products.Where(p => p.Sales != null).SelectMany(p => p.Sales!).ToList();
        lblTotal.Text = $"Total: {_currentOrder.TotalPrice:F2}";
    }
}
