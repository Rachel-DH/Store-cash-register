namespace UI;

partial class SalesForm
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabViewAll;
    private System.Windows.Forms.TabPage tabViewOne;
    private System.Windows.Forms.TabPage tabAdd;
    private System.Windows.Forms.TabPage tabUpdate;
    private System.Windows.Forms.TabPage tabDelete;
    private System.Windows.Forms.Panel bottomPanel;
    private System.Windows.Forms.DataGridView dgvSales;
    private System.Windows.Forms.Label lblMembersOnly;
    private System.Windows.Forms.CheckBox chkMembersOnly;
    private System.Windows.Forms.Button btnFilter;
    private System.Windows.Forms.Button btnClearFilter;
    private System.Windows.Forms.Label lblReadId;
    private System.Windows.Forms.NumericUpDown nudReadId;
    private System.Windows.Forms.Button btnRead;
    private System.Windows.Forms.TextBox txtReadResult;
    private System.Windows.Forms.Label lblCreateBarcode;
    private System.Windows.Forms.TextBox txtCreateBarcode;
    private System.Windows.Forms.Label lblCreateMinAmount;
    private System.Windows.Forms.TextBox txtCreateMinAmount;
    private System.Windows.Forms.Label lblCreatePrice;
    private System.Windows.Forms.TextBox txtCreatePrice;
    private System.Windows.Forms.Label lblCreateToMembers;
    private System.Windows.Forms.CheckBox chkCreateToMembers;
    private System.Windows.Forms.Label lblCreateBegin;
    private System.Windows.Forms.DateTimePicker dtpCreateBegin;
    private System.Windows.Forms.Label lblCreateEnd;
    private System.Windows.Forms.DateTimePicker dtpCreateEnd;
    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.Label lblUpdateId;
    private System.Windows.Forms.NumericUpDown nudUpdateId;
    private System.Windows.Forms.Label lblUpdateBarcode;
    private System.Windows.Forms.TextBox txtUpdateBarcode;
    private System.Windows.Forms.Label lblUpdateMinAmount;
    private System.Windows.Forms.TextBox txtUpdateMinAmount;
    private System.Windows.Forms.Label lblUpdatePrice;
    private System.Windows.Forms.TextBox txtUpdatePrice;
    private System.Windows.Forms.Label lblUpdateToMembers;
    private System.Windows.Forms.CheckBox chkUpdateToMembers;
    private System.Windows.Forms.Label lblUpdateBegin;
    private System.Windows.Forms.DateTimePicker dtpUpdateBegin;
    private System.Windows.Forms.Label lblUpdateEnd;
    private System.Windows.Forms.DateTimePicker dtpUpdateEnd;
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
        tabControl = new System.Windows.Forms.TabControl();
        tabViewAll = new System.Windows.Forms.TabPage();
        tabViewOne = new System.Windows.Forms.TabPage();
        tabAdd = new System.Windows.Forms.TabPage();
        tabUpdate = new System.Windows.Forms.TabPage();
        tabDelete = new System.Windows.Forms.TabPage();
        bottomPanel = new System.Windows.Forms.Panel();
        dgvSales = new System.Windows.Forms.DataGridView();
        lblMembersOnly = new System.Windows.Forms.Label();
        chkMembersOnly = new System.Windows.Forms.CheckBox();
        btnFilter = new System.Windows.Forms.Button();
        btnClearFilter = new System.Windows.Forms.Button();
        lblReadId = new System.Windows.Forms.Label();
        nudReadId = new System.Windows.Forms.NumericUpDown();
        btnRead = new System.Windows.Forms.Button();
        txtReadResult = new System.Windows.Forms.TextBox();
        lblCreateBarcode = new System.Windows.Forms.Label();
        txtCreateBarcode = new System.Windows.Forms.TextBox();
        lblCreateMinAmount = new System.Windows.Forms.Label();
        txtCreateMinAmount = new System.Windows.Forms.TextBox();
        lblCreatePrice = new System.Windows.Forms.Label();
        txtCreatePrice = new System.Windows.Forms.TextBox();
        lblCreateToMembers = new System.Windows.Forms.Label();
        chkCreateToMembers = new System.Windows.Forms.CheckBox();
        lblCreateBegin = new System.Windows.Forms.Label();
        dtpCreateBegin = new System.Windows.Forms.DateTimePicker();
        lblCreateEnd = new System.Windows.Forms.Label();
        dtpCreateEnd = new System.Windows.Forms.DateTimePicker();
        btnCreate = new System.Windows.Forms.Button();
        lblUpdateId = new System.Windows.Forms.Label();
        nudUpdateId = new System.Windows.Forms.NumericUpDown();
        lblUpdateBarcode = new System.Windows.Forms.Label();
        txtUpdateBarcode = new System.Windows.Forms.TextBox();
        lblUpdateMinAmount = new System.Windows.Forms.Label();
        txtUpdateMinAmount = new System.Windows.Forms.TextBox();
        lblUpdatePrice = new System.Windows.Forms.Label();
        txtUpdatePrice = new System.Windows.Forms.TextBox();
        lblUpdateToMembers = new System.Windows.Forms.Label();
        chkUpdateToMembers = new System.Windows.Forms.CheckBox();
        lblUpdateBegin = new System.Windows.Forms.Label();
        dtpUpdateBegin = new System.Windows.Forms.DateTimePicker();
        lblUpdateEnd = new System.Windows.Forms.Label();
        dtpUpdateEnd = new System.Windows.Forms.DateTimePicker();
        btnUpdate = new System.Windows.Forms.Button();
        lblDeleteId = new System.Windows.Forms.Label();
        nudDeleteId = new System.Windows.Forms.NumericUpDown();
        btnDelete = new System.Windows.Forms.Button();
        btnBack = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
        tabControl.SuspendLayout();
        tabViewAll.SuspendLayout();
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
        tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new System.Drawing.Size(800, 415);
        tabControl.TabIndex = 0;
        // 
        // tabViewAll
        // 
        tabViewAll.Controls.Add(dgvSales);
        tabViewAll.Controls.Add(lblMembersOnly);
        tabViewAll.Controls.Add(chkMembersOnly);
        tabViewAll.Controls.Add(btnFilter);
        tabViewAll.Controls.Add(btnClearFilter);
        tabViewAll.Name = "tabViewAll";
        tabViewAll.Size = new System.Drawing.Size(792, 389);
        tabViewAll.TabIndex = 0;
        tabViewAll.Text = "View All";
        // 
        // dgvSales
        // 
        dgvSales.AllowUserToAddRows = false;
        dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvSales.Location = new System.Drawing.Point(10, 50);
        dgvSales.Name = "dgvSales";
        dgvSales.ReadOnly = true;
        dgvSales.Size = new System.Drawing.Size(750, 300);
        dgvSales.TabIndex = 4;
        // 
        // lblMembersOnly
        // 
        lblMembersOnly.AutoSize = true;
        lblMembersOnly.Location = new System.Drawing.Point(10, 15);
        lblMembersOnly.Name = "lblMembersOnly";
        lblMembersOnly.Text = "Members only:";
        // 
        // chkMembersOnly
        // 
        chkMembersOnly.Location = new System.Drawing.Point(110, 13);
        chkMembersOnly.Name = "chkMembersOnly";
        chkMembersOnly.Size = new System.Drawing.Size(20, 20);
        chkMembersOnly.TabIndex = 1;
        // 
        // btnFilter
        // 
        btnFilter.Location = new System.Drawing.Point(140, 11);
        btnFilter.Name = "btnFilter";
        btnFilter.Size = new System.Drawing.Size(70, 25);
        btnFilter.TabIndex = 2;
        btnFilter.Text = "Filter";
        btnFilter.Click += btnFilter_Click;
        // 
        // btnClearFilter
        // 
        btnClearFilter.Location = new System.Drawing.Point(220, 11);
        btnClearFilter.Name = "btnClearFilter";
        btnClearFilter.Size = new System.Drawing.Size(70, 25);
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
        tabViewOne.Name = "tabViewOne";
        tabViewOne.Size = new System.Drawing.Size(792, 389);
        tabViewOne.TabIndex = 1;
        tabViewOne.Text = "View One";
        // 
        // lblReadId
        // 
        lblReadId.AutoSize = true;
        lblReadId.Location = new System.Drawing.Point(10, 20);
        lblReadId.Name = "lblReadId";
        lblReadId.Text = "Sale ID:";
        // 
        // nudReadId
        // 
        nudReadId.Location = new System.Drawing.Point(120, 20);
        nudReadId.Name = "nudReadId";
        nudReadId.Size = new System.Drawing.Size(150, 23);
        nudReadId.TabIndex = 1;
        nudReadId.Minimum = 1;
        nudReadId.Maximum = 99999;
        // 
        // btnRead
        // 
        btnRead.Location = new System.Drawing.Point(10, 55);
        btnRead.Name = "btnRead";
        btnRead.Size = new System.Drawing.Size(100, 28);
        btnRead.TabIndex = 2;
        btnRead.Text = "Get Sale";
        btnRead.Click += btnRead_Click;
        // 
        // txtReadResult
        // 
        txtReadResult.Location = new System.Drawing.Point(10, 95);
        txtReadResult.Multiline = true;
        txtReadResult.Name = "txtReadResult";
        txtReadResult.ReadOnly = true;
        txtReadResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtReadResult.Size = new System.Drawing.Size(750, 250);
        txtReadResult.TabIndex = 3;
        // 
        // tabAdd
        // 
        tabAdd.Controls.Add(lblCreateBarcode);
        tabAdd.Controls.Add(txtCreateBarcode);
        tabAdd.Controls.Add(lblCreateMinAmount);
        tabAdd.Controls.Add(txtCreateMinAmount);
        tabAdd.Controls.Add(lblCreatePrice);
        tabAdd.Controls.Add(txtCreatePrice);
        tabAdd.Controls.Add(lblCreateToMembers);
        tabAdd.Controls.Add(chkCreateToMembers);
        tabAdd.Controls.Add(lblCreateBegin);
        tabAdd.Controls.Add(dtpCreateBegin);
        tabAdd.Controls.Add(lblCreateEnd);
        tabAdd.Controls.Add(dtpCreateEnd);
        tabAdd.Controls.Add(btnCreate);
        tabAdd.Name = "tabAdd";
        tabAdd.Size = new System.Drawing.Size(792, 389);
        tabAdd.TabIndex = 2;
        tabAdd.Text = "Add";
        // 
        // lblCreateBarcode
        // 
        lblCreateBarcode.AutoSize = true;
        lblCreateBarcode.Location = new System.Drawing.Point(10, 20);
        lblCreateBarcode.Name = "lblCreateBarcode";
        lblCreateBarcode.Text = "Product Barcode:";
        // 
        // txtCreateBarcode
        // 
        txtCreateBarcode.Location = new System.Drawing.Point(140, 20);
        txtCreateBarcode.Name = "txtCreateBarcode";
        txtCreateBarcode.Size = new System.Drawing.Size(150, 23);
        txtCreateBarcode.TabIndex = 1;
        // 
        // lblCreateMinAmount
        // 
        lblCreateMinAmount.AutoSize = true;
        lblCreateMinAmount.Location = new System.Drawing.Point(10, 55);
        lblCreateMinAmount.Name = "lblCreateMinAmount";
        lblCreateMinAmount.Text = "Min Amount:";
        // 
        // txtCreateMinAmount
        // 
        txtCreateMinAmount.Location = new System.Drawing.Point(140, 55);
        txtCreateMinAmount.Name = "txtCreateMinAmount";
        txtCreateMinAmount.Size = new System.Drawing.Size(150, 23);
        txtCreateMinAmount.TabIndex = 2;
        // 
        // lblCreatePrice
        // 
        lblCreatePrice.AutoSize = true;
        lblCreatePrice.Location = new System.Drawing.Point(10, 90);
        lblCreatePrice.Name = "lblCreatePrice";
        lblCreatePrice.Text = "Sale Price:";
        // 
        // txtCreatePrice
        // 
        txtCreatePrice.Location = new System.Drawing.Point(140, 90);
        txtCreatePrice.Name = "txtCreatePrice";
        txtCreatePrice.Size = new System.Drawing.Size(150, 23);
        txtCreatePrice.TabIndex = 3;
        // 
        // lblCreateToMembers
        // 
        lblCreateToMembers.AutoSize = true;
        lblCreateToMembers.Location = new System.Drawing.Point(10, 125);
        lblCreateToMembers.Name = "lblCreateToMembers";
        lblCreateToMembers.Text = "Members Only:";
        // 
        // chkCreateToMembers
        // 
        chkCreateToMembers.Location = new System.Drawing.Point(140, 125);
        chkCreateToMembers.Name = "chkCreateToMembers";
        chkCreateToMembers.Size = new System.Drawing.Size(20, 20);
        chkCreateToMembers.TabIndex = 4;
        // 
        // lblCreateBegin
        // 
        lblCreateBegin.AutoSize = true;
        lblCreateBegin.Location = new System.Drawing.Point(10, 160);
        lblCreateBegin.Name = "lblCreateBegin";
        lblCreateBegin.Text = "Begin Date:";
        // 
        // dtpCreateBegin
        // 
        dtpCreateBegin.Location = new System.Drawing.Point(140, 160);
        dtpCreateBegin.Name = "dtpCreateBegin";
        dtpCreateBegin.Size = new System.Drawing.Size(200, 23);
        dtpCreateBegin.TabIndex = 5;
        // 
        // lblCreateEnd
        // 
        lblCreateEnd.AutoSize = true;
        lblCreateEnd.Location = new System.Drawing.Point(10, 195);
        lblCreateEnd.Name = "lblCreateEnd";
        lblCreateEnd.Text = "End Date:";
        // 
        // dtpCreateEnd
        // 
        dtpCreateEnd.Location = new System.Drawing.Point(140, 195);
        dtpCreateEnd.Name = "dtpCreateEnd";
        dtpCreateEnd.Size = new System.Drawing.Size(200, 23);
        dtpCreateEnd.TabIndex = 6;
        // 
        // btnCreate
        // 
        btnCreate.Location = new System.Drawing.Point(10, 235);
        btnCreate.Name = "btnCreate";
        btnCreate.Size = new System.Drawing.Size(100, 28);
        btnCreate.TabIndex = 7;
        btnCreate.Text = "Add Sale";
        btnCreate.Click += btnCreate_Click;
        // 
        // tabUpdate
        // 
        tabUpdate.Controls.Add(lblUpdateId);
        tabUpdate.Controls.Add(nudUpdateId);
        tabUpdate.Controls.Add(lblUpdateBarcode);
        tabUpdate.Controls.Add(txtUpdateBarcode);
        tabUpdate.Controls.Add(lblUpdateMinAmount);
        tabUpdate.Controls.Add(txtUpdateMinAmount);
        tabUpdate.Controls.Add(lblUpdatePrice);
        tabUpdate.Controls.Add(txtUpdatePrice);
        tabUpdate.Controls.Add(lblUpdateToMembers);
        tabUpdate.Controls.Add(chkUpdateToMembers);
        tabUpdate.Controls.Add(lblUpdateBegin);
        tabUpdate.Controls.Add(dtpUpdateBegin);
        tabUpdate.Controls.Add(lblUpdateEnd);
        tabUpdate.Controls.Add(dtpUpdateEnd);
        tabUpdate.Controls.Add(btnUpdate);
        tabUpdate.Name = "tabUpdate";
        tabUpdate.Size = new System.Drawing.Size(792, 389);
        tabUpdate.TabIndex = 3;
        tabUpdate.Text = "Update";
        // 
        // lblUpdateId
        // 
        lblUpdateId.AutoSize = true;
        lblUpdateId.Location = new System.Drawing.Point(10, 20);
        lblUpdateId.Name = "lblUpdateId";
        lblUpdateId.Text = "Sale ID:";
        // 
        // nudUpdateId
        // 
        nudUpdateId.Location = new System.Drawing.Point(140, 20);
        nudUpdateId.Name = "nudUpdateId";
        nudUpdateId.Size = new System.Drawing.Size(150, 23);
        nudUpdateId.TabIndex = 1;
        nudUpdateId.Minimum = 1;
        nudUpdateId.Maximum = 99999;
        // 
        // lblUpdateBarcode
        // 
        lblUpdateBarcode.AutoSize = true;
        lblUpdateBarcode.Location = new System.Drawing.Point(10, 55);
        lblUpdateBarcode.Name = "lblUpdateBarcode";
        lblUpdateBarcode.Text = "Product Barcode:";
        // 
        // txtUpdateBarcode
        // 
        txtUpdateBarcode.Location = new System.Drawing.Point(140, 55);
        txtUpdateBarcode.Name = "txtUpdateBarcode";
        txtUpdateBarcode.Size = new System.Drawing.Size(150, 23);
        txtUpdateBarcode.TabIndex = 2;
        // 
        // lblUpdateMinAmount
        // 
        lblUpdateMinAmount.AutoSize = true;
        lblUpdateMinAmount.Location = new System.Drawing.Point(10, 90);
        lblUpdateMinAmount.Name = "lblUpdateMinAmount";
        lblUpdateMinAmount.Text = "Min Amount:";
        // 
        // txtUpdateMinAmount
        // 
        txtUpdateMinAmount.Location = new System.Drawing.Point(140, 90);
        txtUpdateMinAmount.Name = "txtUpdateMinAmount";
        txtUpdateMinAmount.Size = new System.Drawing.Size(150, 23);
        txtUpdateMinAmount.TabIndex = 3;
        // 
        // lblUpdatePrice
        // 
        lblUpdatePrice.AutoSize = true;
        lblUpdatePrice.Location = new System.Drawing.Point(10, 125);
        lblUpdatePrice.Name = "lblUpdatePrice";
        lblUpdatePrice.Text = "Sale Price:";
        // 
        // txtUpdatePrice
        // 
        txtUpdatePrice.Location = new System.Drawing.Point(140, 125);
        txtUpdatePrice.Name = "txtUpdatePrice";
        txtUpdatePrice.Size = new System.Drawing.Size(150, 23);
        txtUpdatePrice.TabIndex = 4;
        // 
        // lblUpdateToMembers
        // 
        lblUpdateToMembers.AutoSize = true;
        lblUpdateToMembers.Location = new System.Drawing.Point(10, 160);
        lblUpdateToMembers.Name = "lblUpdateToMembers";
        lblUpdateToMembers.Text = "Members Only:";
        // 
        // chkUpdateToMembers
        // 
        chkUpdateToMembers.Location = new System.Drawing.Point(140, 160);
        chkUpdateToMembers.Name = "chkUpdateToMembers";
        chkUpdateToMembers.Size = new System.Drawing.Size(20, 20);
        chkUpdateToMembers.TabIndex = 5;
        // 
        // lblUpdateBegin
        // 
        lblUpdateBegin.AutoSize = true;
        lblUpdateBegin.Location = new System.Drawing.Point(10, 195);
        lblUpdateBegin.Name = "lblUpdateBegin";
        lblUpdateBegin.Text = "Begin Date:";
        // 
        // dtpUpdateBegin
        // 
        dtpUpdateBegin.Location = new System.Drawing.Point(140, 195);
        dtpUpdateBegin.Name = "dtpUpdateBegin";
        dtpUpdateBegin.Size = new System.Drawing.Size(200, 23);
        dtpUpdateBegin.TabIndex = 6;
        // 
        // lblUpdateEnd
        // 
        lblUpdateEnd.AutoSize = true;
        lblUpdateEnd.Location = new System.Drawing.Point(10, 230);
        lblUpdateEnd.Name = "lblUpdateEnd";
        lblUpdateEnd.Text = "End Date:";
        // 
        // dtpUpdateEnd
        // 
        dtpUpdateEnd.Location = new System.Drawing.Point(140, 230);
        dtpUpdateEnd.Name = "dtpUpdateEnd";
        dtpUpdateEnd.Size = new System.Drawing.Size(200, 23);
        dtpUpdateEnd.TabIndex = 7;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new System.Drawing.Point(10, 270);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new System.Drawing.Size(110, 28);
        btnUpdate.TabIndex = 8;
        btnUpdate.Text = "Update Sale";
        btnUpdate.Click += btnUpdate_Click;
        // 
        // tabDelete
        // 
        tabDelete.Controls.Add(lblDeleteId);
        tabDelete.Controls.Add(nudDeleteId);
        tabDelete.Controls.Add(btnDelete);
        tabDelete.Name = "tabDelete";
        tabDelete.Size = new System.Drawing.Size(792, 389);
        tabDelete.TabIndex = 4;
        tabDelete.Text = "Delete";
        // 
        // lblDeleteId
        // 
        lblDeleteId.AutoSize = true;
        lblDeleteId.Location = new System.Drawing.Point(10, 20);
        lblDeleteId.Name = "lblDeleteId";
        lblDeleteId.Text = "Sale ID:";
        // 
        // nudDeleteId
        // 
        nudDeleteId.Location = new System.Drawing.Point(120, 20);
        nudDeleteId.Name = "nudDeleteId";
        nudDeleteId.Size = new System.Drawing.Size(150, 23);
        nudDeleteId.TabIndex = 1;
        nudDeleteId.Minimum = 1;
        nudDeleteId.Maximum = 99999;
        // 
        // btnDelete
        // 
        btnDelete.Location = new System.Drawing.Point(10, 60);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new System.Drawing.Size(110, 28);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Delete Sale";
        btnDelete.Click += btnDelete_Click;
        // 
        // bottomPanel
        // 
        bottomPanel.Controls.Add(btnBack);
        bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
        bottomPanel.Name = "bottomPanel";
        bottomPanel.Size = new System.Drawing.Size(800, 35);
        bottomPanel.TabIndex = 1;
        // 
        // btnBack
        // 
        btnBack.Location = new System.Drawing.Point(5, 5);
        btnBack.Name = "btnBack";
        btnBack.Size = new System.Drawing.Size(80, 25);
        btnBack.TabIndex = 0;
        btnBack.Text = "Back";
        btnBack.Click += btnBack_Click;
        // 
        // SalesForm
        // 
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(tabControl);
        Controls.Add(bottomPanel);
        Name = "SalesForm";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Sales";
        ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
        tabViewAll.ResumeLayout(false);
        tabViewAll.PerformLayout();
        tabViewOne.ResumeLayout(false);
        tabViewOne.PerformLayout();
        tabAdd.ResumeLayout(false);
        tabAdd.PerformLayout();
        tabUpdate.ResumeLayout(false);
        tabUpdate.PerformLayout();
        tabDelete.ResumeLayout(false);
        tabDelete.PerformLayout();
        tabControl.ResumeLayout(false);
        bottomPanel.ResumeLayout(false);
        ResumeLayout(false);
    }
}
