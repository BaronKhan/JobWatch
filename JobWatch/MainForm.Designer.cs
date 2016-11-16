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
      this.listViewApplications = new System.Windows.Forms.ListView();
      this.columnHeaderCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderJobRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.SuspendLayout();
      // 
      // listViewApplications
      // 
      this.listViewApplications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCompany,
            this.columnHeaderJobRole});
      this.listViewApplications.Location = new System.Drawing.Point(13, 144);
      this.listViewApplications.Name = "listViewApplications";
      this.listViewApplications.Size = new System.Drawing.Size(345, 358);
      this.listViewApplications.TabIndex = 0;
      this.listViewApplications.UseCompatibleStateImageBehavior = false;
      this.listViewApplications.View = System.Windows.Forms.View.Details;
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(653, 569);
      this.Controls.Add(this.listViewApplications);
      this.Name = "MainForm";
      this.Text = "Job Watch";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView listViewApplications;
    private System.Windows.Forms.ColumnHeader columnHeaderCompany;
    private System.Windows.Forms.ColumnHeader columnHeaderJobRole;
  }
}

