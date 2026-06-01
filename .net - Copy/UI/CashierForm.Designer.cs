namespace UI;

partial class CashierForm
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Panel topPanel;
    private System.Windows.Forms.Panel addPanel;
    private System.Windows.Forms.Panel centerPanel;
    private System.Windows.Forms.Panel bottomPanel;
    private System.Windows.Forms.Label lblMember;
    private System.Windows.Forms.CheckBox chkIsMember;
    private System.Windows.Forms.Button btnNewOrder;
    private System.Windows.Forms.Label lblProductId;
    private System.Windows.Forms.TextBox txtProductId;
    private System.Windows.Forms.Label lblOrSelect;
    private System.Windows.Forms.ComboBox cmbProducts;
    private System.Windows.Forms.Label lblAmount;
    private System.Windows.Forms.NumericUpDown nudAmount;
    private System.Windows.Forms.Button btnAddProduct;
    private System.Windows.Forms.Label lblOrderProducts;
    private System.Windows.Forms.DataGridView dgvOrderProducts;
    private System.Windows.Forms.Label lblAppliedSales;
    private System.Windows.Forms.DataGridView dgvSales;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.Button btnDoOrder;
    private System.Windows.Forms.Button btnBack;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        topPanel = new Panel();
        lblMember = new Label();
        chkIsMember = new CheckBox();
        btnNewOrder = new Button();
        addPanel = new Panel();
        lblProductId = new Label();
        txtProductId = new TextBox();
        lblOrSelect = new Label();
        cmbProducts = new ComboBox();
        lblAmount = new Label();
        nudAmount = new NumericUpDown();
        btnAddProduct = new Button();
        centerPanel = new Panel();
        lblOrderProducts = new Label();
        dgvOrderProducts = new DataGridView();
        lblAppliedSales = new Label();
        dgvSales = new DataGridView();
        bottomPanel = new Panel();
        lblTotal = new Label();
        btnDoOrder = new Button();
        btnBack = new Button();
        topPanel.SuspendLayout();
        addPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
        centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOrderProducts).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
        bottomPanel.SuspendLayout();
        SuspendLayout();
        // 
        // topPanel
        // 
        topPanel.Controls.Add(lblMember);
        topPanel.Controls.Add(chkIsMember);
        topPanel.Controls.Add(btnNewOrder);
        topPanel.Dock = DockStyle.Top;
        topPanel.Location = new Point(0, 0);
        topPanel.Name = "topPanel";
        topPanel.Size = new Size(800, 45);
        topPanel.TabIndex = 0;
        // 
        // lblMember
        // 
        lblMember.AutoSize = true;
        lblMember.Location = new Point(10, 13);
        lblMember.Name = "lblMember";
        lblMember.Size = new Size(135, 20);
        lblMember.TabIndex = 0;
        lblMember.Text = "Member Customer:";
        // 
        // chkIsMember
        // 
        chkIsMember.Location = new Point(130, 12);
        chkIsMember.Name = "chkIsMember";
        chkIsMember.Size = new Size(20, 20);
        chkIsMember.TabIndex = 1;
        chkIsMember.CheckedChanged += chkIsMember_CheckedChanged;
        // 
        // btnNewOrder
        // 
        btnNewOrder.Location = new Point(170, 9);
        btnNewOrder.Name = "btnNewOrder";
        btnNewOrder.Size = new Size(90, 28);
        btnNewOrder.TabIndex = 2;
        btnNewOrder.Text = "New Order";
        btnNewOrder.Click += btnNewOrder_Click;
        // 
        // addPanel
        // 
        addPanel.Controls.Add(lblProductId);
        addPanel.Controls.Add(txtProductId);
        addPanel.Controls.Add(lblOrSelect);
        addPanel.Controls.Add(cmbProducts);
        addPanel.Controls.Add(lblAmount);
        addPanel.Controls.Add(nudAmount);
        addPanel.Controls.Add(btnAddProduct);
        addPanel.Dock = DockStyle.Top;
        addPanel.Location = new Point(0, 45);
        addPanel.Name = "addPanel";
        addPanel.Size = new Size(800, 50);
        addPanel.TabIndex = 1;
        // 
        // lblProductId
        // 
        lblProductId.AutoSize = true;
        lblProductId.Location = new Point(10, 14);
        lblProductId.Name = "lblProductId";
        lblProductId.Size = new Size(82, 20);
        lblProductId.TabIndex = 0;
        lblProductId.Text = "Product ID:";
        // 
        // txtProductId
        // 
        txtProductId.Location = new Point(89, 14);
        txtProductId.Name = "txtProductId";
        txtProductId.Size = new Size(80, 27);
        txtProductId.TabIndex = 1;
        // 
        // lblOrSelect
        // 
        lblOrSelect.AutoSize = true;
        lblOrSelect.Location = new Point(175, 14);
        lblOrSelect.Name = "lblOrSelect";
        lblOrSelect.Size = new Size(70, 20);
        lblOrSelect.TabIndex = 2;
        lblOrSelect.Text = "Or select:";
        // 
        // cmbProducts
        // 
        cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbProducts.Location = new Point(245, 11);
        cmbProducts.Name = "cmbProducts";
        cmbProducts.Size = new Size(200, 28);
        cmbProducts.TabIndex = 2;
        cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
        // 
        // lblAmount
        // 
        lblAmount.AutoSize = true;
        lblAmount.Location = new Point(455, 14);
        lblAmount.Name = "lblAmount";
        lblAmount.Size = new Size(65, 20);
        lblAmount.TabIndex = 3;
        lblAmount.Text = "Amount:";
        // 
        // nudAmount
        // 
        nudAmount.Location = new Point(537, 14);
        nudAmount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nudAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudAmount.Name = "nudAmount";
        nudAmount.Size = new Size(60, 27);
        nudAmount.TabIndex = 3;
        nudAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnAddProduct
        // 
        btnAddProduct.Location = new Point(654, 10);
        btnAddProduct.Name = "btnAddProduct";
        btnAddProduct.Size = new Size(70, 28);
        btnAddProduct.TabIndex = 4;
        btnAddProduct.Text = "Add";
        btnAddProduct.Click += btnAddProduct_Click;
        // 
        // centerPanel
        // 
        centerPanel.Controls.Add(lblOrderProducts);
        centerPanel.Controls.Add(dgvOrderProducts);
        centerPanel.Controls.Add(lblAppliedSales);
        centerPanel.Controls.Add(dgvSales);
        centerPanel.Dock = DockStyle.Fill;
        centerPanel.Location = new Point(0, 95);
        centerPanel.Name = "centerPanel";
        centerPanel.Size = new Size(800, 310);
        centerPanel.TabIndex = 2;
        // 
        // lblOrderProducts
        // 
        lblOrderProducts.AutoSize = true;
        lblOrderProducts.Font = new Font("Arial", 9F, FontStyle.Bold);
        lblOrderProducts.Location = new Point(5, 5);
        lblOrderProducts.Name = "lblOrderProducts";
        lblOrderProducts.Size = new Size(122, 18);
        lblOrderProducts.TabIndex = 0;
        lblOrderProducts.Text = "Order Products:";
        // 
        // dgvOrderProducts
        // 
        dgvOrderProducts.AllowUserToAddRows = false;
        dgvOrderProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvOrderProducts.ColumnHeadersHeight = 29;
        dgvOrderProducts.Location = new Point(5, 25);
        dgvOrderProducts.Name = "dgvOrderProducts";
        dgvOrderProducts.ReadOnly = true;
        dgvOrderProducts.RowHeadersWidth = 51;
        dgvOrderProducts.Size = new Size(770, 180);
        dgvOrderProducts.TabIndex = 1;
        // 
        // lblAppliedSales
        // 
        lblAppliedSales.AutoSize = true;
        lblAppliedSales.Font = new Font("Arial", 9F, FontStyle.Bold);
        lblAppliedSales.Location = new Point(5, 210);
        lblAppliedSales.Name = "lblAppliedSales";
        lblAppliedSales.Size = new Size(108, 18);
        lblAppliedSales.TabIndex = 2;
        lblAppliedSales.Text = "Applied Sales:";
        // 
        // dgvSales
        // 
        dgvSales.AllowUserToAddRows = false;
        dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvSales.ColumnHeadersHeight = 29;
        dgvSales.Location = new Point(5, 230);
        dgvSales.Name = "dgvSales";
        dgvSales.ReadOnly = true;
        dgvSales.RowHeadersWidth = 51;
        dgvSales.Size = new Size(770, 100);
        dgvSales.TabIndex = 3;
        // 
        // bottomPanel
        // 
        bottomPanel.Controls.Add(lblTotal);
        bottomPanel.Controls.Add(btnDoOrder);
        bottomPanel.Controls.Add(btnBack);
        bottomPanel.Dock = DockStyle.Bottom;
        bottomPanel.Location = new Point(0, 405);
        bottomPanel.Name = "bottomPanel";
        bottomPanel.Size = new Size(800, 45);
        bottomPanel.TabIndex = 3;
        // 
        // lblTotal
        // 
        lblTotal.AutoSize = true;
        lblTotal.Font = new Font("Arial", 11F, FontStyle.Bold);
        lblTotal.Location = new Point(10, 13);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(79, 22);
        lblTotal.TabIndex = 0;
        lblTotal.Text = "Total: 0";
        // 
        // btnDoOrder
        // 
        btnDoOrder.Location = new Point(550, 9);
        btnDoOrder.Name = "btnDoOrder";
        btnDoOrder.Size = new Size(120, 28);
        btnDoOrder.TabIndex = 1;
        btnDoOrder.Text = "Complete Order";
        btnDoOrder.Click += btnDoOrder_Click;
        // 
        // btnBack
        // 
        btnBack.Location = new Point(680, 9);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(80, 28);
        btnBack.TabIndex = 2;
        btnBack.Text = "Back";
        btnBack.Click += btnBack_Click;
        // 
        // CashierForm
        // 
        ClientSize = new Size(800, 450);
        Controls.Add(centerPanel);
        Controls.Add(addPanel);
        Controls.Add(topPanel);
        Controls.Add(bottomPanel);
        Name = "CashierForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Cashier - New Order";
        topPanel.ResumeLayout(false);
        topPanel.PerformLayout();
        addPanel.ResumeLayout(false);
        addPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
        centerPanel.ResumeLayout(false);
        centerPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOrderProducts).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
        bottomPanel.ResumeLayout(false);
        bottomPanel.PerformLayout();
        ResumeLayout(false);
    }
}
