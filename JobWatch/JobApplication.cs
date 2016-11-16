using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobWatch
{
  public class JobApplication
  {
    public int m_id { get; set; }
    public string m_company { get; set; }
    public string m_jobRole { get; set; }

    public static int s_applicationCount { get; private set; }

    static JobApplication() { s_applicationCount = 0; }
    
    public JobApplication() {
      m_id = s_applicationCount;
      m_company = "Company not set";
      m_jobRole = "Job role not set";

      s_applicationCount++;
    }

    public JobApplication(string company, string jobRole)
    {
      m_id = s_applicationCount;
      m_company = company;
      m_jobRole = jobRole;

      s_applicationCount++;
    }
  }
}
