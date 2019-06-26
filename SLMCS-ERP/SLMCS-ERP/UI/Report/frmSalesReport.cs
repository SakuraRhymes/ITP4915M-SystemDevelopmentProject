using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLMCS_Class;

namespace SLMCS_ERP
{
    public partial class frmSalesReport : Form
    {
        private Report report;
        private DataTable topTenTable;
        private DataTable topTenTableYear;
        public frmSalesReport()
        {
            InitializeComponent();
            report = new Report();
        }

        private void FrmSalesReport_Load(object sender, EventArgs e)
        {
            string rank = "";
            string dealerID = "";
            string dealerName = "";
            string totalAmount = "";

            chart1.Series["s1"]["PieLabelStyle"] = "Disabled";
            chart1.Legends[0].Alignment = System.Drawing.StringAlignment.Center;

            //get top 10
            topTenTable = report.GetTopTenDealerTable();
            DataRow[] rows = topTenTable.Select();
            for (int i=0; i<rows.Length; i++)
            {
                rank += (i + 1) + "\n\n";
                dealerID += (string)rows[i]["dealerID"] + "\n\n";
                dealerName += (string)rows[i]["dealerName"] + "\n\n";
                totalAmount += "$ " + rows[i]["totalAmount"].ToString() + "\n\n";
                chart1.Series["s1"].Points.AddXY((string)rows[i]["dealerName"], rows[i]["totalAmount"]);
            }
            lblRank.Text = rank;
            lblDealerID.Text = dealerID;
            lblDealerName.Text = dealerName;
            lblYear.Text = rows[0]["year"].ToString() + "\n\n";
            lblTotalAmount.Text = totalAmount;

            //get year of top 10
            topTenTableYear = report.GetTopTenDealerTableYear();
            DataRow[] yearRows = topTenTable.Select();
            {
                
            }
      
        }
    }
}
