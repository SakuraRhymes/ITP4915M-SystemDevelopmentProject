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
    public partial class frmProductReport : Form
    {
        private Report report;
        private DataTable topTenTable;
        public frmProductReport()
        {
            InitializeComponent();
            report = new Report();
        }

        private void FrmProductReport_Load(object sender, EventArgs e)
        {
            string rank = "";
            string productID = "";
            string productName = "";
            string totalSaleQty = "";

            chart1.Series["s1"]["PieLabelStyle"] = "Disabled";
            chart1.Legends[0].Alignment = System.Drawing.StringAlignment.Center;

            //get top 10
            topTenTable = report.GetTopSaleProductTable();
            DataRow[] rows = topTenTable.Select();
            for (int i = 0; i < rows.Length; i++)
            {
                rank += (i + 1) + "\n\n";
                productID += (string)rows[i]["ProductID"] + "\n\n";
                productName += (string)rows[i]["ProductName"] + "\n\n";
                totalSaleQty += rows[i]["TotalSaleQty"].ToString() + "\n\n";
                chart1.Series["s1"].Points.AddXY((string)rows[i]["ProductName"], rows[i]["TotalSaleQty"]);
            }
            lblRank.Text = rank;
            lblProductID.Text = productID;
            lblProductName.Text = productName;
            lblTotalSaleQty.Text = totalSaleQty;


        }
    }
}
