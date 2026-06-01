using BlApi;
using BO;

namespace UI;

public partial class SalesForm : Form
{
    private readonly IBl _bl;
    private readonly Form _previous;

    public SalesForm(IBl bl, Form previous)
    {
        _bl = bl;
        _previous = previous;
        InitializeComponent();
        FormClosed += (s, e) => { if (!_previous.Visible) _previous.Show(); };
        LoadAllSales();
    }

    private void LoadAllSales()
    {
        try
        {
            var sales = _bl.sale.ReadAll(null);
            dgvSales.DataSource = sales;
            if (sales?.Count > 0)
            {
                int minId = sales.Min(s => s!.Id);
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
        try { dgvSales.DataSource = _bl.sale.ReadAll(s => s.ToMembers == chkMembersOnly.Checked); }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnClearFilter_Click(object sender, EventArgs e) { chkMembersOnly.Checked = false; LoadAllSales(); }

    private void btnRead_Click(object sender, EventArgs e)
    {
        try
        {
            int id = (int)nudReadId.Value;
            txtReadResult.Text = _bl.sale.Read(id)?.ToString() ?? "Not found";
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
        try
        {
            if (!int.TryParse(txtCreateBarcode.Text, out int barcode) || !int.TryParse(txtCreateMinAmount.Text, out int minAmount) || !double.TryParse(txtCreatePrice.Text, out double price))
            { MessageBox.Show("Invalid input"); return; }
            _bl.sale.Create(new Sale(0, barcode, minAmount, price, chkCreateToMembers.Checked, dtpCreateBegin.Value, dtpCreateEnd.Value));
            MessageBox.Show("Sale added successfully");
            LoadAllSales();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            if (!int.TryParse(txtUpdateBarcode.Text, out int barcode) || !int.TryParse(txtUpdateMinAmount.Text, out int minAmount) || !double.TryParse(txtUpdatePrice.Text, out double price))
            { MessageBox.Show("Invalid input"); return; }
            int id = (int)nudUpdateId.Value;
            _bl.sale.Update(new Sale(id, barcode, minAmount, price, chkUpdateToMembers.Checked, dtpUpdateBegin.Value, dtpUpdateEnd.Value));
            MessageBox.Show("Sale updated successfully");
            LoadAllSales();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            int id = (int)nudDeleteId.Value;
            _bl.sale.Delete(id);
            MessageBox.Show("Sale deleted successfully");
            LoadAllSales();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    private void btnBack_Click(object sender, EventArgs e) { Close(); _previous.Show(); }
}
