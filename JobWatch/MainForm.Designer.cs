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
      System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Accepted", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Rejected", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Waiting for Reply", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Interview with", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Application in Progress", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Application Pending", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Interested In", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Applied To", System.Windows.Forms.HorizontalAlignment.Left);
      this.listViewApplications = new System.Windows.Forms.ListView();
      this.columnHeaderCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderJobRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderNextDeadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.buttonLoad = new System.Windows.Forms.Button();
      this.groupBoxJobInfo = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.labelAdditionalInfo = new System.Windows.Forms.Label();
      this.richTextBoxAdditionalInfo = new System.Windows.Forms.RichTextBox();
      this.labelJobRole = new System.Windows.Forms.Label();
      this.textBoxJobRole = new System.Windows.Forms.TextBox();
      this.labelCompany = new System.Windows.Forms.Label();
      this.textBoxCompany = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.comboBoxStatus = new System.Windows.Forms.ComboBox();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.buttonDelete = new System.Windows.Forms.Button();
      this.buttonUpdate = new System.Windows.Forms.Button();
      this.buttonSave = new System.Windows.Forms.Button();
      this.openFileDialogLoad = new System.Windows.Forms.OpenFileDialog();
      this.openFileDialogSave = new System.Windows.Forms.OpenFileDialog();
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
      listViewGroup1.Header = "Accepted";
      listViewGroup1.Name = "listViewGroupAccepted";
      listViewGroup2.Header = "Rejected";
      listViewGroup2.Name = "listViewGroupRejected";
      listViewGroup3.Header = "Waiting for Reply";
      listViewGroup3.Name = "listViewGroupWaiting";
      listViewGroup4.Header = "Interview with";
      listViewGroup4.Name = "listViewGroupInterview";
      listViewGroup5.Header = "Application in Progress";
      listViewGroup5.Name = "listViewGroupInProgress";
      listViewGroup6.Header = "Application Pending";
      listViewGroup6.Name = "listViewGroupPending";
      listViewGroup7.Header = "Interested In";
      listViewGroup7.Name = "listViewGroupInterested";
      listViewGroup8.Header = "Applied To";
      listViewGroup8.Name = "listViewGroupApplied";
      this.listViewApplications.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8});
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
      this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
      // 
      // groupBoxJobInfo
      // 
      this.groupBoxJobInfo.Controls.Add(this.label3);
      this.groupBoxJobInfo.Controls.Add(this.label2);
      this.groupBoxJobInfo.Controls.Add(this.labelAdditionalInfo);
      this.groupBoxJobInfo.Controls.Add(this.richTextBoxAdditionalInfo);
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
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(91, 216);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "label3";
      this.label3.Visible = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 217);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "label2";
      this.label2.Visible = false;
      // 
      // labelAdditionalInfo
      // 
      this.labelAdditionalInfo.AutoSize = true;
      this.labelAdditionalInfo.Location = new System.Drawing.Point(9, 259);
      this.labelAdditionalInfo.Name = "labelAdditionalInfo";
      this.labelAdditionalInfo.Size = new System.Drawing.Size(77, 13);
      this.labelAdditionalInfo.TabIndex = 7;
      this.labelAdditionalInfo.Text = "Additional Info:";
      // 
      // richTextBoxAdditionalInfo
      // 
      this.richTextBoxAdditionalInfo.Location = new System.Drawing.Point(9, 278);
      this.richTextBoxAdditionalInfo.Name = "richTextBoxAdditionalInfo";
      this.richTextBoxAdditionalInfo.Size = new System.Drawing.Size(367, 191);
      this.richTextBoxAdditionalInfo.TabIndex = 6;
      this.richTextBoxAdditionalInfo.Text = "";
      this.richTextBoxAdditionalInfo.TextChanged += new System.EventHandler(this.richTextBoxAdditionalInfo_TextChanged);
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
      this.textBoxJobRole.TextChanged += new System.EventHandler(this.textBoxJobRole_TextChanged);
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
      this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(592, 12);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(75, 23);
      this.buttonSave.TabIndex = 6;
      this.buttonSave.Text = "Save Jobs";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
      // 
      // openFileDialogLoad
      // 
      this.openFileDialogLoad.FileName = "openFileDialogLoad";
      // 
      // openFileDialogSave
      // 
      this.openFileDialogSave.FileName = "openFileDialogSave";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(760, 569);
      this.Controls.Add(this.buttonSave);
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
    private System.Windows.Forms.Label labelAdditionalInfo;
    private System.Windows.Forms.RichTextBox richTextBoxAdditionalInfo;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.OpenFileDialog openFileDialogLoad;
    private System.Windows.Forms.OpenFileDialog openFileDialogSave;
  }
}

