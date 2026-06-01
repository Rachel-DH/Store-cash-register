namespace UI;

partial class ManagerMenuForm
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnProducts;
    private System.Windows.Forms.Button btnSales;
    private System.Windows.Forms.Button btnCustomers;
    private System.Windows.Forms.Button btnBack;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new System.Windows.Forms.Label();
        btnProducts = new System.Windows.Forms.Button();
        btnSales = new System.Windows.Forms.Button();
        btnCustomers = new System.Windows.Forms.Button();
        btnBack = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(800, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Select Entity";
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnProducts
        // 
        btnProducts.Location = new System.Drawing.Point(300, 80);
        btnProducts.Name = "btnProducts";
        btnProducts.Size = new System.Drawing.Size(200, 40);
        btnProducts.TabIndex = 1;
        btnProducts.Text = "Products";
        btnProducts.Click += btnProducts_Click;
        // 
        // btnSales
        // 
        btnSales.Location = new System.Drawing.Point(300, 135);
        btnSales.Name = "btnSales";
        btnSales.Size = new System.Drawing.Size(200, 40);
        btnSales.TabIndex = 2;
        btnSales.Text = "Sales";
        btnSales.Click += btnSales_Click;
        // 
        // btnCustomers
        // 
        btnCustomers.Location = new System.Drawing.Point(300, 190);
        btnCustomers.Name = "btnCustomers";
        btnCustomers.Size = new System.Drawing.Size(200, 40);
        btnCustomers.TabIndex = 3;
        btnCustomers.Text = "Customers";
        btnCustomers.Click += btnCustomers_Click;
        // 
        // btnBack
        // 
        btnBack.Location = new System.Drawing.Point(300, 245);
        btnBack.Name = "btnBack";
        btnBack.Size = new System.Drawing.Size(200, 40);
        btnBack.TabIndex = 4;
        btnBack.Text = "Back";
        btnBack.Click += btnBack_Click;
        // 
        // ManagerMenuForm
        // 
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(lblTitle);
        Controls.Add(btnProducts);
        Controls.Add(btnSales);
        Controls.Add(btnCustomers);
        Controls.Add(btnBack);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "ManagerMenuForm";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Manager Menu";
        ResumeLayout(false);
    }
}
