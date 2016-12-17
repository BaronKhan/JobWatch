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
    public bool localChanges = false;
    public bool globalChanges = false;
    public bool changeListView = true;
    public string fileName = "jobs.json";

    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      try
      {
#if DEBUG
        // debug stuff goes here
        LoadJobsData(Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), @"Debug\data\jobs.json"));
#else
        LoadJobsData(Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), @"Release\data\jobs.json"));
#endif

      }
      catch
      {
        MessageBox.Show("Could not load default jobs.json file. Please load a jobs file manually.", "jobs.json not found");
      }
    }

    public void LoadJobsData(string jsonPath)
    {
      JavaScriptSerializer ser = new JavaScriptSerializer();
      string input = File.ReadAllText(jsonPath);
      m_jobsList = ser.Deserialize<List<JobApplication>>(input);
      UpdateJobsListView();
    }

    public void SaveJobsData(string jsonPath)
    {
      try
      {
        JavaScriptSerializer ser = new JavaScriptSerializer();
        string JsonOutput = ser.Serialize(m_jobsList);
        File.WriteAllText(jsonPath, JsonOutput);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Could not save file. " + ex.Message, "Saving failed");
      }
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
      if (comboBoxStatus.Text != m_jobsList[lastJobIndex].m_status)
      {
        localChanges = true;
      }
    }

    private void listViewApplications_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (changeListView)
      {
        if (listViewApplications.SelectedIndices.Count > 0)
        {
          //save local changes first
          bool performChange = true;
          if (localChanges)
          {
            DialogResult dr = MessageBox.Show("Changes have been made to the current job. Would you like to save these changes?",
                        "Job Changes Made", MessageBoxButtons.YesNo);
            switch (dr)
            {
              case DialogResult.Yes:
                buttonUpdate_Click(sender, e);
                break;
              case DialogResult.No:
                localChanges = false;
                break;
              default:
                performChange = false;
                changeListView = false;
                listViewApplications.SelectedIndices.Clear();
                listViewApplications.SelectedIndices.Add(lastJobIndex);
                changeListView = true;
                break;
            }
          }
          if (performChange && listViewApplications.SelectedIndices.Count > 0)
          {
            lastJobIndex = listViewApplications.SelectedIndices[0];
            textBoxCompany.Text = m_jobsList[lastJobIndex].m_company;
            textBoxJobRole.Text = m_jobsList[lastJobIndex].m_jobRole;
            comboBoxStatus.Text = getStatus(lastJobIndex);
            richTextBoxAdditionalInfo.Text = m_jobsList[lastJobIndex].m_text;
          }
        }
      }
      label2.Text = lastJobIndex.ToString();
      if (listViewApplications.SelectedIndices.Count > 0)
        label3.Text = listViewApplications.SelectedIndices[0].ToString();
    }

    private void textBoxCompany_TextChanged(object sender, EventArgs e)
    {
      if (textBoxCompany.Text != m_jobsList[lastJobIndex].m_company)
      {
        localChanges = true;
      }
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
      var newJob = new JobApplication();
      m_jobsList.Add(newJob);
      UpdateJobsListView();
      clearJobInformation();
      globalChanges = true;
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
      if (listViewApplications.SelectedItems.Count > 0)
      {
        m_jobsList.RemoveAt(lastJobIndex);
      }
      UpdateJobsListView();
      clearJobInformation();
      globalChanges = true;
    }

    private void buttonUpdate_Click(object sender, EventArgs e)
    {
      if (listViewApplications.SelectedItems.Count > 0)
      {
        m_jobsList[lastJobIndex].m_company = textBoxCompany.Text;
        m_jobsList[lastJobIndex].m_jobRole = textBoxJobRole.Text;
        setStatus(lastJobIndex, comboBoxStatus.Text);
        m_jobsList[lastJobIndex].m_text = richTextBoxAdditionalInfo.Text;
      }
      UpdateJobsListView();
      clearJobInformation();
      localChanges = false;
      globalChanges = true;
    }

    private void setStatus(int jobIndex, string status)
    {
      if (status == "In-Progress")
      {
        m_jobsList[jobIndex].m_status = "InProgress";
      }
      else
      {
        m_jobsList[jobIndex].m_status = status;
      }
    }

    private string getStatus(int jobIndex)
    {
      if (m_jobsList[jobIndex].m_status == "InProgress")
      {
        return "In-Progress";
      }
      else
      {
        return m_jobsList[jobIndex].m_status;
      }
    }

    private void clearJobInformation()
    {
      textBoxCompany.Clear();
      textBoxJobRole.Clear();
      comboBoxStatus.Text = "";
      richTextBoxAdditionalInfo.Text = "";
    }

    private void buttonLoad_Click(object sender, EventArgs e)
    {
      try
      {
#if DEBUG
        // debug stuff goes here
        openFileDialogLoad.InitialDirectory = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), @"\Debug\data");
#else
        openFileDialogLoad.InitialDirectory = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), @"\Release\data");
#endif
        DialogResult result = openFileDialogLoad.ShowDialog();
        if (result == DialogResult.OK)
        {
          string loadedJobsPath = openFileDialogLoad.FileName;
          LoadJobsData(@loadedJobsPath);
        }
      }
      catch
      {
        MessageBox.Show("Error loading jobs file. Please select a valid .json file.", "Could not load jobs");
      }
    }

    private void textBoxJobRole_TextChanged(object sender, EventArgs e)
    {
      if (textBoxJobRole.Text != m_jobsList[lastJobIndex].m_jobRole) {
        localChanges = true;
      }
    }

    private void richTextBoxAdditionalInfo_TextChanged(object sender, EventArgs e)
    {
      if (richTextBoxAdditionalInfo.Text != m_jobsList[lastJobIndex].m_text)
      {
        localChanges = true;
      }
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      openFileDialogSave.FileName = fileName;
      DialogResult result = openFileDialogSave.ShowDialog();
      if (result == DialogResult.OK)
      {
        SaveJobsData(openFileDialogSave.FileName);
      }
    }
  }
}
