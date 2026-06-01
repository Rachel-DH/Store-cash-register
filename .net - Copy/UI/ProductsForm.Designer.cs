namespace UI;

partial class ProductsForm
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabViewAll;
    private System.Windows.Forms.TabPage tabViewOne;
    private System.Windows.Forms.TabPage tabAdd;
    private System.Windows.Forms.TabPage tabUpdate;
    private System.Windows.Forms.TabPage tabDelete;
    private System.Windows.Forms.Panel bottomPanel;
    private System.Windows.Forms.DataGridView dgvProducts;
    private System.Windows.Forms.Label lblFilterCategory;
    private System.Windows.Forms.ComboBox cmbCategoryFilter;
    private System.Windows.Forms.Button btnFilter;
    private System.Windows.Forms.Button btnClearFilter;
    private System.Windows.Forms.Label lblReadId;
    private System.Windows.Forms.NumericUpDown nudReadId;
    private System.Windows.Forms.Button btnRead;
    private System.Windows.Forms.TextBox txtReadResult;
    private System.Windows.Forms.Label lblCreateName;
    private System.Windows.Forms.TextBox txtCreateName;
    private System.Windows.Forms.Label lblCreateCategory;
    private System.Windows.Forms.ComboBox cmbCreateCategory;
    private System.Windows.Forms.Label lblCreatePrice;
    private System.Windows.Forms.TextBox txtCreatePrice;
    private System.Windows.Forms.Label lblCreateAmount;
    private System.Windows.Forms.TextBox txtCreateAmount;
    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.Label lblUpdateId;
    private System.Windows.Forms.NumericUpDown nudUpdateId;
    private System.Windows.Forms.Label lblUpdateName;
    private System.Windows.Forms.TextBox txtUpdateName;
    private System.Windows.Forms.Label lblUpdateCategory;
    private System.Windows.Forms.ComboBox cmbUpdateCategory;
    private System.Windows.Forms.Label lblUpdatePrice;
    private System.Windows.Forms.TextBox txtUpdatePrice;
    private System.Windows.Forms.Label lblUpdateAmount;
    private System.Windows.Forms.TextBox txtUpdateAmount;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Label lblDeleteId;
    private System.Windows.Forms.NumericUpDown nudDeleteId;
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
        dgvProducts = new DataGridView();
        lblFilterCategory = new Label();
        cmbCategoryFilter = new ComboBox();
        btnFilter = new Button();
        btnClearFilter = new Button();
        tabViewOne = new TabPage();
        lblReadId = new Label();
        nudReadId = new NumericUpDown();
        btnRead = new Button();
        txtReadResult = new TextBox();
        tabAdd = new TabPage();
        lblCreateName = new Label();
        txtCreateName = new TextBox();
        lblCreateCategory = new Label();
        cmbCreateCategory = new ComboBox();
        lblCreatePrice = new Label();
        txtCreatePrice = new TextBox();
        lblCreateAmount = new Label();
        txtCreateAmount = new TextBox();
        btnCreate = new Button();
        tabUpdate = new TabPage();
        lblUpdateId = new Label();
        nudUpdateId = new NumericUpDown();
        lblUpdateName = new Label();
        txtUpdateName = new TextBox();
        lblUpdateCategory = new Label();
        cmbUpdateCategory = new ComboBox();
        lblUpdatePrice = new Label();
        txtUpdatePrice = new TextBox();
        lblUpdateAmount = new Label();
        txtUpdateAmount = new TextBox();
        btnUpdate = new Button();
        tabDelete = new TabPage();
        lblDeleteId = new Label();
        nudDeleteId = new NumericUpDown();
        btnDelete = new Button();
        bottomPanel = new Panel();
        btnBack = new Button();
        tabControl.SuspendLayout();
        tabViewAll.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
        tabViewOne.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudReadId).BeginInit();
        tabAdd.SuspendLayout();
        tabUpdate.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudUpdateId).BeginInit();
        tabDelete.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudDeleteId).BeginInit();
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
        tabViewAll.Controls.Add(dgvProducts);
        tabViewAll.Controls.Add(lblFilterCategory);
        tabViewAll.Controls.Add(cmbCategoryFilter);
        tabViewAll.Controls.Add(btnFilter);
        tabViewAll.Controls.Add(btnClearFilter);
        tabViewAll.Location = new Point(4, 29);
        tabViewAll.Name = "tabViewAll";
        tabViewAll.Size = new Size(792, 382);
        tabViewAll.TabIndex = 0;
        tabViewAll.Text = "View All";
        // 
        // dgvProducts
        // 
        dgvProducts.AllowUserToAddRows = false;
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProducts.ColumnHeadersHeight = 29;
        dgvProducts.Location = new Point(10, 50);
        dgvProducts.Name = "dgvProducts";
        dgvProducts.ReadOnly = true;
        dgvProducts.RowHeadersWidth = 51;
        dgvProducts.Size = new Size(750, 300);
        dgvProducts.TabIndex = 4;
        // 
        // lblFilterCategory
        // 
        lblFilterCategory.AutoSize = true;
        lblFilterCategory.Location = new Point(10, 15);
        lblFilterCategory.Name = "lblFilterCategory";
        lblFilterCategory.Size = new Size(129, 20);
        lblFilterCategory.TabIndex = 5;
        lblFilterCategory.Text = "Filter by Category:";
        // 
        // cmbCategoryFilter
        // 
        cmbCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCategoryFilter.Location = new Point(145, 10);
        cmbCategoryFilter.Name = "cmbCategoryFilter";
        cmbCategoryFilter.Size = new Size(120, 28);
        cmbCategoryFilter.TabIndex = 1;
        // 
        // btnFilter
        // 
        btnFilter.Location = new Point(271, 13);
        btnFilter.Name = "btnFilter";
        btnFilter.Size = new Size(70, 25);
        btnFilter.TabIndex = 2;
        btnFilter.Text = "Filter";
        btnFilter.Click += btnFilter_Click;
        // 
        // btnClearFilter
        // 
        btnClearFilter.Location = new Point(340, 11);
        btnClearFilter.Name = "btnClearFilter";
        btnClearFilter.Size = new Size(70, 25);
        btnClearFilter.TabIndex = 3;
        btnClearFilter.Text = "Clear";
        btnClearFilter.Click += btnClearFilter_Click;
        // 
        // tabViewOne
        // 
        tabViewOne.Controls.Add(lblReadId);
        tabViewOne.Controls.Add(nudReadId);
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
        lblReadId.Size = new Size(82, 20);
        lblReadId.TabIndex = 0;
        lblReadId.Text = "Product ID:";
        // 
        // nudReadId
        // 
        nudReadId.Location = new Point(120, 20);
        nudReadId.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
        nudReadId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudReadId.Name = "nudReadId";
        nudReadId.Size = new Size(150, 27);
        nudReadId.TabIndex = 1;
        nudReadId.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnRead
        // 
        btnRead.Location = new Point(10, 55);
        btnRead.Name = "btnRead";
        btnRead.Size = new Size(100, 28);
        btnRead.TabIndex = 2;
        btnRead.Text = "Get Product";
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
        tabAdd.Controls.Add(lblCreateName);
        tabAdd.Controls.Add(txtCreateName);
        tabAdd.Controls.Add(lblCreateCategory);
        tabAdd.Controls.Add(cmbCreateCategory);
        tabAdd.Controls.Add(lblCreatePrice);
        tabAdd.Controls.Add(txtCreatePrice);
        tabAdd.Controls.Add(lblCreateAmount);
        tabAdd.Controls.Add(txtCreateAmount);
        tabAdd.Controls.Add(btnCreate);
        tabAdd.Location = new Point(4, 29);
        tabAdd.Name = "tabAdd";
        tabAdd.Size = new Size(792, 382);
        tabAdd.TabIndex = 2;
        tabAdd.Text = "Add";
        // 
        // lblCreateName
        // 
        lblCreateName.AutoSize = true;
        lblCreateName.Location = new Point(10, 20);
        lblCreateName.Name = "lblCreateName";
        lblCreateName.Size = new Size(52, 20);
        lblCreateName.TabIndex = 0;
        lblCreateName.Text = "Name:";
        // 
        // txtCreateName
        // 
        txtCreateName.Location = new Point(120, 20);
        txtCreateName.Name = "txtCreateName";
        txtCreateName.Size = new Size(200, 27);
        txtCreateName.TabIndex = 1;
        // 
        // lblCreateCategory
        // 
        lblCreateCategory.AutoSize = true;
        lblCreateCategory.Location = new Point(10, 55);
        lblCreateCategory.Name = "lblCreateCategory";
        lblCreateCategory.Size = new Size(72, 20);
        lblCreateCategory.TabIndex = 2;
        lblCreateCategory.Text = "Category:";
        // 
        // cmbCreateCategory
        // 
        cmbCreateCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCreateCategory.Location = new Point(120, 55);
        cmbCreateCategory.Name = "cmbCreateCategory";
        cmbCreateCategory.Size = new Size(150, 28);
        cmbCreateCategory.TabIndex = 2;
        // 
        // lblCreatePrice
        // 
        lblCreatePrice.AutoSize = true;
        lblCreatePrice.Location = new Point(10, 90);
        lblCreatePrice.Name = "lblCreatePrice";
        lblCreatePrice.Size = new Size(44, 20);
        lblCreatePrice.TabIndex = 3;
        lblCreatePrice.Text = "Price:";
        // 
        // txtCreatePrice
        // 
        txtCreatePrice.Location = new Point(120, 90);
        txtCreatePrice.Name = "txtCreatePrice";
        txtCreatePrice.Size = new Size(150, 27);
        txtCreatePrice.TabIndex = 3;
        // 
        // lblCreateAmount
        // 
        lblCreateAmount.AutoSize = true;
        lblCreateAmount.Location = new Point(10, 125);
        lblCreateAmount.Name = "lblCreateAmount";
        lblCreateAmount.Size = new Size(65, 20);
        lblCreateAmount.TabIndex = 4;
        lblCreateAmount.Text = "Amount:";
        // 
        // txtCreateAmount
        // 
        txtCreateAmount.Location = new Point(120, 125);
        txtCreateAmount.Name = "txtCreateAmount";
        txtCreateAmount.Size = new Size(150, 27);
        txtCreateAmount.TabIndex = 4;
        // 
        // btnCreate
        // 
        btnCreate.Location = new Point(10, 165);
        btnCreate.Name = "btnCreate";
        btnCreate.Size = new Size(110, 28);
        btnCreate.TabIndex = 5;
        btnCreate.Text = "Add Product";
        btnCreate.Click += btnCreate_Click;
        // 
        // tabUpdate
        // 
        tabUpdate.Controls.Add(lblUpdateId);
        tabUpdate.Controls.Add(nudUpdateId);
        tabUpdate.Controls.Add(lblUpdateName);
        tabUpdate.Controls.Add(txtUpdateName);
        tabUpdate.Controls.Add(lblUpdateCategory);
        tabUpdate.Controls.Add(cmbUpdateCategory);
        tabUpdate.Controls.Add(lblUpdatePrice);
        tabUpdate.Controls.Add(txtUpdatePrice);
        tabUpdate.Controls.Add(lblUpdateAmount);
        tabUpdate.Controls.Add(txtUpdateAmount);
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
        lblUpdateId.Size = new Size(82, 20);
        lblUpdateId.TabIndex = 0;
        lblUpdateId.Text = "Product ID:";
        // 
        // nudUpdateId
        // 
        nudUpdateId.Location = new Point(120, 20);
        nudUpdateId.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
        nudUpdateId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudUpdateId.Name = "nudUpdateId";
        nudUpdateId.Size = new Size(150, 27);
        nudUpdateId.TabIndex = 1;
        nudUpdateId.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
        // lblUpdateCategory
        // 
        lblUpdateCategory.AutoSize = true;
        lblUpdateCategory.Location = new Point(10, 90);
        lblUpdateCategory.Name = "lblUpdateCategory";
        lblUpdateCategory.Size = new Size(72, 20);
        lblUpdateCategory.TabIndex = 3;
        lblUpdateCategory.Text = "Category:";
        // 
        // cmbUpdateCategory
        // 
        cmbUpdateCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbUpdateCategory.Location = new Point(120, 90);
        cmbUpdateCategory.Name = "cmbUpdateCategory";
        cmbUpdateCategory.Size = new Size(150, 28);
        cmbUpdateCategory.TabIndex = 3;
        // 
        // lblUpdatePrice
        // 
        lblUpdatePrice.AutoSize = true;
        lblUpdatePrice.Location = new Point(10, 125);
        lblUpdatePrice.Name = "lblUpdatePrice";
        lblUpdatePrice.Size = new Size(44, 20);
        lblUpdatePrice.TabIndex = 4;
        lblUpdatePrice.Text = "Price:";
        // 
        // txtUpdatePrice
        // 
        txtUpdatePrice.Location = new Point(120, 125);
        txtUpdatePrice.Name = "txtUpdatePrice";
        txtUpdatePrice.Size = new Size(150, 27);
        txtUpdatePrice.TabIndex = 4;
        // 
        // lblUpdateAmount
        // 
        lblUpdateAmount.AutoSize = true;
        lblUpdateAmount.Location = new Point(10, 160);
        lblUpdateAmount.Name = "lblUpdateAmount";
        lblUpdateAmount.Size = new Size(65, 20);
        lblUpdateAmount.TabIndex = 5;
        lblUpdateAmount.Text = "Amount:";
        // 
        // txtUpdateAmount
        // 
        txtUpdateAmount.Location = new Point(120, 160);
        txtUpdateAmount.Name = "txtUpdateAmount";
        txtUpdateAmount.Size = new Size(150, 27);
        txtUpdateAmount.TabIndex = 5;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(10, 200);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(120, 28);
        btnUpdate.TabIndex = 6;
        btnUpdate.Text = "Update Product";
        btnUpdate.Click += btnUpdate_Click;
        // 
        // tabDelete
        // 
        tabDelete.Controls.Add(lblDeleteId);
        tabDelete.Controls.Add(nudDeleteId);
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
        lblDeleteId.Size = new Size(82, 20);
        lblDeleteId.TabIndex = 0;
        lblDeleteId.Text = "Product ID:";
        // 
        // nudDeleteId
        // 
        nudDeleteId.Location = new Point(120, 20);
        nudDeleteId.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
        nudDeleteId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudDeleteId.Name = "nudDeleteId";
        nudDeleteId.Size = new Size(150, 27);
        nudDeleteId.TabIndex = 1;
        nudDeleteId.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(10, 60);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(120, 28);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Delete Product";
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
        // ProductsForm
        // 
        ClientSize = new Size(800, 450);
        Controls.Add(tabControl);
        Controls.Add(bottomPanel);
        Name = "ProductsForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Products";
        tabControl.ResumeLayout(false);
        tabViewAll.ResumeLayout(false);
        tabViewAll.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
        tabViewOne.ResumeLayout(false);
        tabViewOne.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudReadId).EndInit();
        tabAdd.ResumeLayout(false);
        tabAdd.PerformLayout();
        tabUpdate.ResumeLayout(false);
        tabUpdate.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudUpdateId).EndInit();
        tabDelete.ResumeLayout(false);
        tabDelete.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudDeleteId).EndInit();
        bottomPanel.ResumeLayout(false);
        ResumeLayout(false);
    }
}
