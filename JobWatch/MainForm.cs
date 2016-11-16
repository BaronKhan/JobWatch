using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;

namespace JobWatch
{
  public partial class MainForm : Form
  {
    public List<JobApplication> m_jobsList;

    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      LoadJobsData(@"D:\Google Drive\Other\JobWatch\JobWatch\bin\Debug\data\jobs.json");
    }

    public void LoadJobsData(string jsonPath)
    {
      JavaScriptSerializer ser = new JavaScriptSerializer();
      string input = File.ReadAllText(jsonPath);
      m_jobsList = ser.Deserialize<List<JobApplication>>(input);
      UpdateJobsListView();
    }

    public void UpdateJobsListView()
    {
      listViewApplications.Items.Clear();
      foreach(var job in m_jobsList) {
        var item = new ListViewItem(new[] { job.m_company, job.m_jobRole });
        listViewApplications.Items.Add(item);
      }
    }
  }
}
