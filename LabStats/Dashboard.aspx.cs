using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LabStats.SoapStats;

namespace LabStats
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StatisticsSoapClient client = new StatisticsSoapClient();
            GroupStat[] stats = client.GetGroupedCurrentStats();

            //Task<GroupStat[]> group2 = client.GetGroupedCurrentStatsAsync();

            DataTable dt = new DataTable();
            dt.Columns.Add("percentAvailable", typeof(double));
            dt.Columns.Add("InUse", typeof(int));
            dt.Columns.Add("available", typeof(int));
            dt.Columns.Add("Total", typeof(int));

            foreach (GroupStat group in stats)
            {
                if (group.groupName.Equals("Learning Commons"))
                {
                    int available = group.availableCount;
                    int inUse = group.inUseCount;
                    int total = available + inUse;
                    double percentAvailable = Convert.ToDouble(available)/Convert.ToDouble(total) * 100;

                    DataRow availability = dt.NewRow();
                    availability["percentAvailable"] = percentAvailable;
                    availability["InUse"] = inUse;
                    availability["available"] = available;
                    availability["Total"] = total;

                    dt.Rows.Add(availability);

                    GridView2.DataSource = dt;
                    GridView2.DataBind();
                }
            }

        }

        //public async Task<GroupStat[]> getStatsAsync(TimeSpan interval, CancellationToken ct)
        //{
        //    StatisticsSoapClient client = new StatisticsSoapClient();
        //    Task<GroupStat[]> stats = client.GetGroupedCurrentStatsAsync();

            
        //}

    }
}