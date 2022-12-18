using Gate_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gate_system.Repos
{
    public static class ReporItemRepository
    {
        public static List<ReportItem> reports = new List<ReportItem>();

        public static List<ReportItem> Retrieve() { return reports; }

        public static ReportItem Retrieve(int id)
        {
            foreach (ReportItem report in reports)
            {
                if (report.Id == id)
                {
                    return report;
                }
            }
            return null;
        }

    }
}
