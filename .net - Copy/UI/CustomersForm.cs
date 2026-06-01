using BlApi;
using BO;

namespace UI;

public partial class CustomersForm : Form
{
    private readonly IBl _bl;
    private readonly Form _previous;

    public CustomersForm(IBl bl, Form previous)
    {
        _bl = bl;
        _previous = previous;
        InitializeComponent();
        FormClosed += (s, e) => { if (!_previous.Visible) _previous.Show(); };
        LoadAllCustomers();
    }

    private void LoadAllCustomers()
    {
        try { dgvCustomers.DataSource = _bl.customer.ReadAll(null); }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
        try
        {
            string name = txtFilterName.Text.ToLower();
            dgvCustomers.DataSource = _bl.customer.ReadAll(c => c.Name.ToLower().Contains(name));
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnClearFilter_Click(object sender, EventArgs e) { txtFilterName.Clear(); LoadAllCustomers(); }

    private void btnRead_Click(object sender, EventArgs e)
    {
        try
        {
            if (!int.TryParse(txtReadId.Text, out int id)) { MessageBox.Show("Invalid ID"); return; }
            txtReadResult.Text = _bl.customer.Read(id)?.ToString() ?? "Not found";
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
        try
        {
            if (!int.TryParse(txtCreateId.Text, out int id)) { MessageBox.Show("Invalid ID"); return; }
            _bl.customer.Create(new Customer(id, txtCreateName.Text, txtCreateAddress.Text, txtCreatePhone.Text));
            MessageBox.Show("Customer added successfully");
            LoadAllCustomers();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            if (!int.TryParse(txtUpdateId.Text, out int id)) { MessageBox.Show("Invalid ID"); return; }
            _bl.customer.Update(new Customer(id, txtUpdateName.Text, txtUpdateAddress.Text, txtUpdatePhone.Text));
            MessageBox.Show("Customer updated successfully");
            LoadAllCustomers();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            if (!int.TryParse(txtDeleteId.Text, out int id)) { MessageBox.Show("Invalid ID"); return; }
            _bl.customer.Delete(id);
            MessageBox.Show("Customer deleted successfully");
            LoadAllCustomers();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnBack_Click(object sender, EventArgs e) { Close(); _previous.Show(); }
}
