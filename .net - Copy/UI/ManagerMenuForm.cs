using BlApi;

namespace UI;

public partial class ManagerMenuForm : Form
{
    private readonly IBl _bl;
    private readonly Form _previous;

    public ManagerMenuForm(IBl bl, Form previous)
    {
        _bl = bl;
        _previous = previous;
        InitializeComponent();
        FormClosed += (s, e) => { if (!_previous.Visible) _previous.Show(); };
    }

    private void btnProducts_Click(object sender, EventArgs e) { Hide(); new ProductsForm(_bl, this).Show(); }
    private void btnSales_Click(object sender, EventArgs e) { Hide(); new SalesForm(_bl, this).Show(); }
    private void btnCustomers_Click(object sender, EventArgs e) { Hide(); new CustomersForm(_bl, this).Show(); }
    private void btnBack_Click(object sender, EventArgs e) { Close(); _previous.Show(); }
}
