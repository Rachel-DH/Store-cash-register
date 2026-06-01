namespace UI;

partial class CustomersForm
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabViewAll;
    private System.Windows.Forms.TabPage tabViewOne;
    private System.Windows.Forms.TabPage tabAdd;
    private System.Windows.Forms.TabPage tabUpdate;
    private System.Windows.Forms.TabPage tabDelete;
    private System.Windows.Forms.Panel bottomPanel;
    private System.Windows.Forms.DataGridView dgvCustomers;
    private System.Windows.Forms.Label lblFilterName;
    private System.Windows.Forms.TextBox txtFilterName;
    private System.Windows.Forms.Button btnFilter;
    private System.Windows.Forms.Button btnClearFilter;
    private System.Windows.Forms.Label lblReadId;
    private System.Windows.Forms.TextBox txtReadId;
    private System.Windows.Forms.Button btnRead;
    private System.Windows.Forms.TextBox txtReadResult;
    private System.Windows.Forms.Label lblCreateId;
    private System.Windows.Forms.TextBox txtCreateId;
    private System.Windows.Forms.Label lblCreateName;
    private System.Windows.Forms.TextBox txtCreateName;
    private System.Windows.Forms.Label lblCreateAddress;
    private System.Windows.Forms.TextBox txtCreateAddress;
    private System.Windows.Forms.Label lblCreatePhone;
    private System.Windows.Forms.TextBox txtCreatePhone;
    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.Label lblUpdateId;
    private System.Windows.Forms.TextBox txtUpdateId;
    private System.Windows.Forms.Label lblUpdateName;
    private System.Windows.Forms.TextBox txtUpdateName;
    private System.Windows.Forms.Label lblUpdateAddress;
    private System.Windows.Forms.TextBox txtUpdateAddress;
    private System.Windows.Forms.Label lblUpdatePhone;
    private System.Windows.Forms.TextBox txtUpdatePhone;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Label lblDeleteId;
    private System.Windows.Forms.TextBox txtDeleteId;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnBack;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        tabControl = new TabControl();
        tabViewAll = new TabPage();
        dgvCustomers = new DataGridView();
        lblFilterName = new Label();
        txtFilterName = new TextBox();
        btnFilter = new Button();
        btnClearFilter = new Button();
        tabViewOne = new TabPage();
        lblReadId = new Label();
        txtReadId = new TextBox();
        btnRead = new Button();
        txtReadResult = new TextBox();
        tabAdd = new TabPage();
        lblCreateId = new Label();
        txtCreateId = new TextBox();
        lblCreateName = new Label();
        txtCreateName = new TextBox();
        lblCreateAddress = new Label();
        txtCreateAddress = new TextBox();
        lblCreatePhone = new Label();
        txtCreatePhone = new TextBox();
        btnCreate = new Button();
        tabUpdate = new TabPage();
        lblUpdateId = new Label();
        txtUpdateId = new TextBox();
        lblUpdateName = new Label();
        txtUpdateName = new TextBox();
        lblUpdateAddress = new Label();
        txtUpdateAddress = new TextBox();
        lblUpdatePhone = new Label();
        txtUpdatePhone = new TextBox();
        btnUpdate = new Button();
        tabDelete = new TabPage();
        lblDeleteId = new Label();
        txtDeleteId = new TextBox();
        btnDelete = new Button();
        bottomPanel = new Panel();
        btnBack = new Button();
        tabControl.SuspendLayout();
        tabViewAll.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
        tabViewOne.SuspendLayout();
        tabAdd.SuspendLayout();
        tabUpdate.SuspendLayout();
        tabDelete.SuspendLayout();
        bottomPanel.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabViewAll);
        tabControl.Controls.Add(tabViewOne);
        tabControl.Controls.Add(tabAdd);
        tabControl.Controls.Add(tabUpdate);
        tabControl.Controls.Add(tabDelete);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Location = new Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(800, 415);
        tabControl.TabIndex = 0;
        // 
        // tabViewAll
        // 
        tabViewAll.Controls.Add(dgvCustomers);
        tabViewAll.Controls.Add(lblFilterName);
        tabViewAll.Controls.Add(txtFilterName);
        tabViewAll.Controls.Add(btnFilter);
        tabViewAll.Controls.Add(btnClearFilter);
        tabViewAll.Location = new Point(4, 29);
        tabViewAll.Name = "tabViewAll";
        tabViewAll.Size = new Size(792, 382);
        tabViewAll.TabIndex = 0;
        tabViewAll.Text = "View All";
        // 
        // dgvCustomers
        // 
        dgvCustomers.AllowUserToAddRows = false;
        dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvCustomers.ColumnHeadersHeight = 29;
        dgvCustomers.Location = new Point(10, 50);
        dgvCustomers.Name = "dgvCustomers";
        dgvCustomers.ReadOnly = true;
        dgvCustomers.RowHeadersWidth = 51;
        dgvCustomers.Size = new Size(750, 300);
        dgvCustomers.TabIndex = 4;
        // 
        // lblFilterName
        // 
        lblFilterName.AutoSize = true;
        lblFilterName.Location = new Point(10, 15);
        lblFilterName.Name = "lblFilterName";
        lblFilterName.Size = new Size(109, 20);
        lblFilterName.TabIndex = 5;
        lblFilterName.Text = "Filter by Name:";
        // 
        // txtFilterName
        // 
        txtFilterName.Location = new Point(128, 12);
        txtFilterName.Name = "txtFilterName";
        txtFilterName.Size = new Size(150, 27);
        txtFilterName.TabIndex = 1;
        // 
        // btnFilter
        // 
        btnFilter.Location = new Point(284, 10);
        btnFilter.Name = "btnFilter";
        btnFilter.Size = new Size(70, 25);
        btnFilter.TabIndex = 2;
        btnFilter.Text = "Filter";
        btnFilter.Click += btnFilter_Click;
        // 
        // btnClearFilter
        // 
        btnClearFilter.Location = new Point(360, 10);
        btnClearFilter.Name = "btnClearFilter";
        btnClearFilter.Size = new Size(70, 25);
        btnClearFilter.TabIndex = 3;
        btnClearFilter.Text = "Clear";
        btnClearFilter.Click += btnClearFilter_Click;
        // 
        // tabViewOne
        // 
        tabViewOne.Controls.Add(lblReadId);
        tabViewOne.Controls.Add(txtReadId);
        tabViewOne.Controls.Add(btnRead);
        tabViewOne.Controls.Add(txtReadResult);
        tabViewOne.Location = new Point(4, 29);
        tabViewOne.Name = "tabViewOne";
        tabViewOne.Size = new Size(792, 382);
        tabViewOne.TabIndex = 1;
        tabViewOne.Text = "View One";
        // 
        // lblReadId
        // 
        lblReadId.AutoSize = true;
        lblReadId.Location = new Point(10, 20);
        lblReadId.Name = "lblReadId";
        lblReadId.Size = new Size(94, 20);
        lblReadId.TabIndex = 0;
        lblReadId.Text = "Customer ID:";
        // 
        // txtReadId
        // 
        txtReadId.Location = new Point(120, 20);
        txtReadId.Name = "txtReadId";
        txtReadId.Size = new Size(150, 27);
        txtReadId.TabIndex = 1;
        // 
        // btnRead
        // 
        btnRead.Location = new Point(10, 55);
        btnRead.Name = "btnRead";
        btnRead.Size = new Size(110, 28);
        btnRead.TabIndex = 2;
        btnRead.Text = "Get Customer";
        btnRead.Click += btnRead_Click;
        // 
        // txtReadResult
        // 
        txtReadResult.Location = new Point(10, 95);
        txtReadResult.Multiline = true;
        txtReadResult.Name = "txtReadResult";
        txtReadResult.ReadOnly = true;
        txtReadResult.ScrollBars = ScrollBars.Vertical;
        txtReadResult.Size = new Size(750, 250);
        txtReadResult.TabIndex = 3;
        // 
        // tabAdd
        // 
        tabAdd.Controls.Add(lblCreateId);
        tabAdd.Controls.Add(txtCreateId);
        tabAdd.Controls.Add(lblCreateName);
        tabAdd.Controls.Add(txtCreateName);
        tabAdd.Controls.Add(lblCreateAddress);
        tabAdd.Controls.Add(txtCreateAddress);
        tabAdd.Controls.Add(lblCreatePhone);
        tabAdd.Controls.Add(txtCreatePhone);
        tabAdd.Controls.Add(btnCreate);
        tabAdd.Location = new Point(4, 29);
        tabAdd.Name = "tabAdd";
        tabAdd.Size = new Size(792, 382);
        tabAdd.TabIndex = 2;
        tabAdd.Text = "Add";
        // 
        // lblCreateId
        // 
        lblCreateId.AutoSize = true;
        lblCreateId.Location = new Point(10, 20);
        lblCreateId.Name = "lblCreateId";
        lblCreateId.Size = new Size(27, 20);
        lblCreateId.TabIndex = 0;
        lblCreateId.Text = "ID:";
        // 
        // txtCreateId
        // 
        txtCreateId.Location = new Point(120, 20);
        txtCreateId.Name = "txtCreateId";
        txtCreateId.Size = new Size(150, 27);
        txtCreateId.TabIndex = 1;
        // 
        // lblCreateName
        // 
        lblCreateName.AutoSize = true;
        lblCreateName.Location = new Point(10, 55);
        lblCreateName.Name = "lblCreateName";
        lblCreateName.Size = new Size(52, 20);
        lblCreateName.TabIndex = 2;
        lblCreateName.Text = "Name:";
        // 
        // txtCreateName
        // 
        txtCreateName.Location = new Point(120, 55);
        txtCreateName.Name = "txtCreateName";
        txtCreateName.Size = new Size(200, 27);
        txtCreateName.TabIndex = 2;
        // 
        // lblCreateAddress
        // 
        lblCreateAddress.AutoSize = true;
        lblCreateAddress.Location = new Point(10, 90);
        lblCreateAddress.Name = "lblCreateAddress";
        lblCreateAddress.Size = new Size(65, 20);
        lblCreateAddress.TabIndex = 3;
        lblCreateAddress.Text = "Address:";
        // 
        // txtCreateAddress
        // 
        txtCreateAddress.Location = new Point(120, 90);
        txtCreateAddress.Name = "txtCreateAddress";
        txtCreateAddress.Size = new Size(200, 27);
        txtCreateAddress.TabIndex = 3;
        // 
        // lblCreatePhone
        // 
        lblCreatePhone.AutoSize = true;
        lblCreatePhone.Location = new Point(10, 125);
        lblCreatePhone.Name = "lblCreatePhone";
        lblCreatePhone.Size = new Size(53, 20);
        lblCreatePhone.TabIndex = 4;
        lblCreatePhone.Text = "Phone:";
        // 
        // txtCreatePhone
        // 
        txtCreatePhone.Location = new Point(120, 125);
        txtCreatePhone.Name = "txtCreatePhone";
        txtCreatePhone.Size = new Size(150, 27);
        txtCreatePhone.TabIndex = 4;
        // 
        // btnCreate
        // 
        btnCreate.Location = new Point(10, 165);
        btnCreate.Name = "btnCreate";
        btnCreate.Size = new Size(120, 28);
        btnCreate.TabIndex = 5;
        btnCreate.Text = "Add Customer";
        btnCreate.Click += btnCreate_Click;
        // 
        // tabUpdate
        // 
        tabUpdate.Controls.Add(lblUpdateId);
        tabUpdate.Controls.Add(txtUpdateId);
        tabUpdate.Controls.Add(lblUpdateName);
        tabUpdate.Controls.Add(txtUpdateName);
        tabUpdate.Controls.Add(lblUpdateAddress);
        tabUpdate.Controls.Add(txtUpdateAddress);
        tabUpdate.Controls.Add(lblUpdatePhone);
        tabUpdate.Controls.Add(txtUpdatePhone);
        tabUpdate.Controls.Add(btnUpdate);
        tabUpdate.Location = new Point(4, 29);
        tabUpdate.Name = "tabUpdate";
        tabUpdate.Size = new Size(792, 382);
        tabUpdate.TabIndex = 3;
        tabUpdate.Text = "Update";
        // 
        // lblUpdateId
        // 
        lblUpdateId.AutoSize = true;
        lblUpdateId.Location = new Point(10, 20);
        lblUpdateId.Name = "lblUpdateId";
        lblUpdateId.Size = new Size(94, 20);
        lblUpdateId.TabIndex = 0;
        lblUpdateId.Text = "Customer ID:";
        // 
        // txtUpdateId
        // 
        txtUpdateId.Location = new Point(120, 20);
        txtUpdateId.Name = "txtUpdateId";
        txtUpdateId.Size = new Size(150, 27);
        txtUpdateId.TabIndex = 1;
        // 
        // lblUpdateName
        // 
        lblUpdateName.AutoSize = true;
        lblUpdateName.Location = new Point(10, 55);
        lblUpdateName.Name = "lblUpdateName";
        lblUpdateName.Size = new Size(52, 20);
        lblUpdateName.TabIndex = 2;
        lblUpdateName.Text = "Name:";
        // 
        // txtUpdateName
        // 
        txtUpdateName.Location = new Point(120, 55);
        txtUpdateName.Name = "txtUpdateName";
        txtUpdateName.Size = new Size(200, 27);
        txtUpdateName.TabIndex = 2;
        // 
        // lblUpdateAddress
        // 
        lblUpdateAddress.AutoSize = true;
        lblUpdateAddress.Location = new Point(10, 90);
        lblUpdateAddress.Name = "lblUpdateAddress";
        lblUpdateAddress.Size = new Size(65, 20);
        lblUpdateAddress.TabIndex = 3;
        lblUpdateAddress.Text = "Address:";
        // 
        // txtUpdateAddress
        // 
        txtUpdateAddress.Location = new Point(120, 90);
        txtUpdateAddress.Name = "txtUpdateAddress";
        txtUpdateAddress.Size = new Size(200, 27);
        txtUpdateAddress.TabIndex = 3;
        // 
        // lblUpdatePhone
        // 
        lblUpdatePhone.AutoSize = true;
        lblUpdatePhone.Location = new Point(10, 125);
        lblUpdatePhone.Name = "lblUpdatePhone";
        lblUpdatePhone.Size = new Size(53, 20);
        lblUpdatePhone.TabIndex = 4;
        lblUpdatePhone.Text = "Phone:";
        // 
        // txtUpdatePhone
        // 
        txtUpdatePhone.Location = new Point(120, 125);
        txtUpdatePhone.Name = "txtUpdatePhone";
        txtUpdatePhone.Size = new Size(150, 27);
        txtUpdatePhone.TabIndex = 4;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(10, 165);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(130, 28);
        btnUpdate.TabIndex = 5;
        btnUpdate.Text = "Update Customer";
        btnUpdate.Click += btnUpdate_Click;
        // 
        // tabDelete
        // 
        tabDelete.Controls.Add(lblDeleteId);
        tabDelete.Controls.Add(txtDeleteId);
        tabDelete.Controls.Add(btnDelete);
        tabDelete.Location = new Point(4, 29);
        tabDelete.Name = "tabDelete";
        tabDelete.Size = new Size(792, 382);
        tabDelete.TabIndex = 4;
        tabDelete.Text = "Delete";
        // 
        // lblDeleteId
        // 
        lblDeleteId.AutoSize = true;
        lblDeleteId.Location = new Point(10, 20);
        lblDeleteId.Name = "lblDeleteId";
        lblDeleteId.Size = new Size(94, 20);
        lblDeleteId.TabIndex = 0;
        lblDeleteId.Text = "Customer ID:";
        // 
        // txtDeleteId
        // 
        txtDeleteId.Location = new Point(120, 20);
        txtDeleteId.Name = "txtDeleteId";
        txtDeleteId.Size = new Size(150, 27);
        txtDeleteId.TabIndex = 1;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(10, 60);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(130, 28);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Delete Customer";
        btnDelete.Click += btnDelete_Click;
        // 
        // bottomPanel
        // 
        bottomPanel.Controls.Add(btnBack);
        bottomPanel.Dock = DockStyle.Bottom;
        bottomPanel.Location = new Point(0, 415);
        bottomPanel.Name = "bottomPanel";
        bottomPanel.Size = new Size(800, 35);
        bottomPanel.TabIndex = 1;
        // 
        // btnBack
        // 
        btnBack.Location = new Point(5, 5);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(80, 25);
        btnBack.TabIndex = 0;
        btnBack.Text = "Back";
        btnBack.Click += btnBack_Click;
        // 
        // CustomersForm
        // 
        ClientSize = new Size(800, 450);
        Controls.Add(tabControl);
        Controls.Add(bottomPanel);
        Name = "CustomersForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Customers";
        tabControl.ResumeLayout(false);
        tabViewAll.ResumeLayout(false);
        tabViewAll.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
        tabViewOne.ResumeLayout(false);
        tabViewOne.PerformLayout();
        tabAdd.ResumeLayout(false);
        tabAdd.PerformLayout();
        tabUpdate.ResumeLayout(false);
        tabUpdate.PerformLayout();
        tabDelete.ResumeLayout(false);
        tabDelete.PerformLayout();
        bottomPanel.ResumeLayout(false);
        ResumeLayout(false);
    }
}
