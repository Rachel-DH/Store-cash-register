using BlApi;

namespace UI;

public partial class MainForm : Form
{
    private readonly IBl _bl = BlApi.Factory.Get();

    public MainForm()
    {
        InitializeComponent();
    }

    private void btnManager_Click(object sender, EventArgs e)
    {
        Hide();
        new ManagerMenuForm(_bl, this).Show();
    }

    private void btnCashier_Click(object sender, EventArgs e)
    {
        Hide();
        new CashierForm(_bl, this).Show();
    }
}
