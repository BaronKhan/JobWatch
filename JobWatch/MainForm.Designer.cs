namespace JobWatch
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Accepted", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Rejected", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Waiting for Reply", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("Interview with", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Application in Progress", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Application Pending", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Interested In", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup16 = new System.Windows.Forms.ListViewGroup("Applied To", System.Windows.Forms.HorizontalAlignment.Left);
      this.listViewApplications = new System.Windows.Forms.ListView();
      this.columnHeaderCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderJobRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderNextDeadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.buttonLoad = new System.Windows.Forms.Button();
      this.groupBoxJobInfo = new System.Windows.Forms.GroupBox();
      this.labelJobRole = new System.Windows.Forms.Label();
      this.textBoxJobRole = new System.Windows.Forms.TextBox();
      this.labelCompany = new System.Windows.Forms.Label();
      this.textBoxCompany = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.comboBoxStatus = new System.Windows.Forms.ComboBox();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.buttonDelete = new System.Windows.Forms.Button();
      this.buttonUpdate = new System.Windows.Forms.Button();
      this.groupBoxJobInfo.SuspendLayout();
      this.SuspendLayout();
      // 
      // listViewApplications
      // 
      this.listViewApplications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCompany,
            this.columnHeaderJobRole,
            this.columnHeaderNextDeadline});
      this.listViewApplications.FullRowSelect = true;
      listViewGroup9.Header = "Accepted";
      listViewGroup9.Name = "listViewGroupAccepted";
      listViewGroup10.Header = "Rejected";
      listViewGroup10.Name = "listViewGroupRejected";
      listViewGroup11.Header = "Waiting for Reply";
      listViewGroup11.Name = "listViewGroupWaiting";
      listViewGroup12.Header = "Interview with";
      listViewGroup12.Name = "listViewGroupInterview";
      listViewGroup13.Header = "Application in Progress";
      listViewGroup13.Name = "listViewGroupInProgress";
      listViewGroup14.Header = "Application Pending";
      listViewGroup14.Name = "listViewGroupPending";
      listViewGroup15.Header = "Interested In";
      listViewGroup15.Name = "listViewGroupInterested";
      listViewGroup16.Header = "Applied To";
      listViewGroup16.Name = "listViewGroupApplied";
      this.listViewApplications.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup9,
            listViewGroup10,
            listViewGroup11,
            listViewGroup12,
            listViewGroup13,
            listViewGroup14,
            listViewGroup15,
            listViewGroup16});
      this.listViewApplications.Location = new System.Drawing.Point(13, 12);
      this.listViewApplications.MultiSelect = false;
      this.listViewApplications.Name = "listViewApplications";
      this.listViewApplications.Size = new System.Drawing.Size(345, 545);
      this.listViewApplications.TabIndex = 0;
      this.listViewApplications.UseCompatibleStateImageBehavior = false;
      this.listViewApplications.View = System.Windows.Forms.View.Details;
      this.listViewApplications.SelectedIndexChanged += new System.EventHandler(this.listViewApplications_SelectedIndexChanged);
      // 
      // columnHeaderCompany
      // 
      this.columnHeaderCompany.Text = "Company";
      this.columnHeaderCompany.Width = 122;
      // 
      // columnHeaderJobRole
      // 
      this.columnHeaderJobRole.Text = "Job Role";
      this.columnHeaderJobRole.Width = 119;
      // 
      // columnHeaderNextDeadline
      // 
      this.columnHeaderNextDeadline.Text = "Next Deadline";
      this.columnHeaderNextDeadline.Width = 99;
      // 
      // buttonLoad
      // 
      this.buttonLoad.Location = new System.Drawing.Point(673, 12);
      this.buttonLoad.Name = "buttonLoad";
      this.buttonLoad.Size = new System.Drawing.Size(75, 23);
      this.buttonLoad.TabIndex = 1;
      this.buttonLoad.Text = "Load Jobs";
      this.buttonLoad.UseVisualStyleBackColor = true;
      // 
      // groupBoxJobInfo
      // 
      this.groupBoxJobInfo.Controls.Add(this.labelJobRole);
      this.groupBoxJobInfo.Controls.Add(this.textBoxJobRole);
      this.groupBoxJobInfo.Controls.Add(this.labelCompany);
      this.groupBoxJobInfo.Controls.Add(this.textBoxCompany);
      this.groupBoxJobInfo.Controls.Add(this.label1);
      this.groupBoxJobInfo.Controls.Add(this.comboBoxStatus);
      this.groupBoxJobInfo.Location = new System.Drawing.Point(365, 82);
      this.groupBoxJobInfo.Name = "groupBoxJobInfo";
      this.groupBoxJobInfo.Size = new System.Drawing.Size(383, 475);
      this.groupBoxJobInfo.TabIndex = 2;
      this.groupBoxJobInfo.TabStop = false;
      this.groupBoxJobInfo.Text = "Job Information";
      // 
      // labelJobRole
      // 
      this.labelJobRole.AutoSize = true;
      this.labelJobRole.Location = new System.Drawing.Point(132, 26);
      this.labelJobRole.Name = "labelJobRole";
      this.labelJobRole.Size = new System.Drawing.Size(52, 13);
      this.labelJobRole.TabIndex = 5;
      this.labelJobRole.Text = "Job Role:";
      // 
      // textBoxJobRole
      // 
      this.textBoxJobRole.Location = new System.Drawing.Point(135, 42);
      this.textBoxJobRole.Name = "textBoxJobRole";
      this.textBoxJobRole.Size = new System.Drawing.Size(143, 20);
      this.textBoxJobRole.TabIndex = 4;
      // 
      // labelCompany
      // 
      this.labelCompany.AutoSize = true;
      this.labelCompany.Location = new System.Drawing.Point(6, 25);
      this.labelCompany.Name = "labelCompany";
      this.labelCompany.Size = new System.Drawing.Size(85, 13);
      this.labelCompany.TabIndex = 3;
      this.labelCompany.Text = "Company Name:";
      // 
      // textBoxCompany
      // 
      this.textBoxCompany.Location = new System.Drawing.Point(5, 42);
      this.textBoxCompany.Name = "textBoxCompany";
      this.textBoxCompany.Size = new System.Drawing.Size(124, 20);
      this.textBoxCompany.TabIndex = 2;
      this.textBoxCompany.TextChanged += new System.EventHandler(this.textBoxCompany_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(281, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(95, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Application Status:";
      // 
      // comboBoxStatus
      // 
      this.comboBoxStatus.FormattingEnabled = true;
      this.comboBoxStatus.Items.AddRange(new object[] {
            "Accepted",
            "Rejected",
            "Waiting",
            "Interview",
            "Applied",
            "In-Progress",
            "Pending",
            "Interested"});
      this.comboBoxStatus.Location = new System.Drawing.Point(284, 42);
      this.comboBoxStatus.Name = "comboBoxStatus";
      this.comboBoxStatus.Size = new System.Drawing.Size(92, 21);
      this.comboBoxStatus.TabIndex = 0;
      this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
      // 
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(374, 42);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(75, 23);
      this.buttonAdd.TabIndex = 3;
      this.buttonAdd.Text = "Add New";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // buttonDelete
      // 
      this.buttonDelete.Location = new System.Drawing.Point(456, 42);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new System.Drawing.Size(75, 23);
      this.buttonDelete.TabIndex = 4;
      this.buttonDelete.Text = "Delete";
      this.buttonDelete.UseVisualStyleBackColor = true;
      this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
      // 
      // buttonUpdate
      // 
      this.buttonUpdate.Location = new System.Drawing.Point(673, 53);
      this.buttonUpdate.Name = "buttonUpdate";
      this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
      this.buttonUpdate.TabIndex = 5;
      this.buttonUpdate.Text = "Update";
      this.buttonUpdate.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(760, 569);
      this.Controls.Add(this.buttonUpdate);
      this.Controls.Add(this.buttonDelete);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.groupBoxJobInfo);
      this.Controls.Add(this.buttonLoad);
      this.Controls.Add(this.listViewApplications);
      this.Name = "MainForm";
      this.Text = "Job Watch";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.groupBoxJobInfo.ResumeLayout(false);
      this.groupBoxJobInfo.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView listViewApplications;
    private System.Windows.Forms.ColumnHeader columnHeaderCompany;
    private System.Windows.Forms.ColumnHeader columnHeaderJobRole;
    private System.Windows.Forms.ColumnHeader columnHeaderNextDeadline;
    private System.Windows.Forms.Button buttonLoad;
    private System.Windows.Forms.GroupBox groupBoxJobInfo;
    private System.Windows.Forms.ComboBox comboBoxStatus;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxCompany;
    private System.Windows.Forms.Label labelJobRole;
    private System.Windows.Forms.TextBox textBoxJobRole;
    private System.Windows.Forms.Label labelCompany;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonDelete;
    private System.Windows.Forms.Button buttonUpdate;
  }
}

