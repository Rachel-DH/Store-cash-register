namespace UI;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnManager;
    private System.Windows.Forms.Button btnCashier;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new System.Windows.Forms.Label();
        btnManager = new System.Windows.Forms.Button();
        btnCashier = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.Location = new System.Drawing.Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(800, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Select Role";
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnManager
        // 
        btnManager.Location = new System.Drawing.Point(250, 180);
        btnManager.Name = "btnManager";
        btnManager.Size = new System.Drawing.Size(120, 40);
        btnManager.TabIndex = 1;
        btnManager.Text = "Manager";
        btnManager.Click += btnManager_Click;
        // 
        // btnCashier
        // 
        btnCashier.Location = new System.Drawing.Point(420, 180);
        btnCashier.Name = "btnCashier";
        btnCashier.Size = new System.Drawing.Size(120, 40);
        btnCashier.TabIndex = 2;
        btnCashier.Text = "Cashier";
        btnCashier.Click += btnCashier_Click;
        // 
        // MainForm
        // 
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(lblTitle);
        Controls.Add(btnManager);
        Controls.Add(btnCashier);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Store";
        ResumeLayout(false);
    }
}
