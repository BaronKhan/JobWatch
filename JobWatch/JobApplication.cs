using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobWatch
{
  public class JobApplication
  {
    public string m_company { get; set; }
    public string m_jobRole { get; set; }
    public string m_status { get; set; }
    public string m_text { get; set; }
    
    public JobApplication() {
      m_company = "Company not set";
      m_jobRole = "Job role not set";
      m_status = "Pending";
      m_text = "";
    }

    public JobApplication(string company, string jobRole, string status, string text)
    {
      m_company = company;
      m_jobRole = jobRole;
      m_status = status;
      m_text = text;
    }
  }
}
