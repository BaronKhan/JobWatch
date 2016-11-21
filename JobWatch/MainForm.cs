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
    public int lastJobIndex = 0;

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
      foreach (var job in m_jobsList)
      {
        var item = new ListViewItem(new[] { job.m_company, job.m_jobRole });
        listViewApplications.Items.Add(item);
        int currentIndex = listViewApplications.Items.Count-1;
        listViewApplications.Items[currentIndex].Group = listViewApplications.Groups["listViewGroup"+job.m_status];
      }
    }

    private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void listViewApplications_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listViewApplications.SelectedItems.Count > 0) {
        lastJobIndex = listViewApplications.SelectedItems[0].Index;
        textBoxCompany.Text = m_jobsList[lastJobIndex].m_company;
        textBoxJobRole.Text = m_jobsList[lastJobIndex].m_jobRole;
      }
    }

    private void textBoxCompany_TextChanged(object sender, EventArgs e)
    {
      /*
      if (listViewApplications.SelectedItems.Count > 0)
      {
        m_jobsList[lastJobIndex].m_company = textBoxCompany.Text;
      }
      UpdateJobsListView();
      */
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
      var newJob = new JobApplication();
      m_jobsList.Add(newJob);
      UpdateJobsListView();
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
      if (listViewApplications.SelectedItems.Count > 0)
      {
        m_jobsList.RemoveAt(lastJobIndex);
      }
      UpdateJobsListView();
    }
  }
}
