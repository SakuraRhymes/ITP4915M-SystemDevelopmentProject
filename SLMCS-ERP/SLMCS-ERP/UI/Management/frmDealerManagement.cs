using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SLMCS_Class;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLMCS_ERP.UI.Management
{
    public partial class frmDealerManagement : Form
    {
        String selectedDealerID;
        Dealer dealer;
        public frmDealerManagement()
        {
            InitializeComponent();
            dgvDealerList.AllowUserToAddRows = false;
            dgvDealerList.RowHeadersVisible = false;
            dgvDealerList.ReadOnly = true;
            selectedDealerID = "";
            dealer = new Dealer();
        }

        private void BtnSearchDealer_Click(object sender, EventArgs e)
        {
            changeDgvDealerList(dealer.GetDealerTable(dealerMultiSearchString()));

        }

        private string dealerMultiSearchString()
        {
            string queryString = "";
            if (txtDealerID.Text != "")
            {
                queryString += "DealerID LIKE '%" + txtDealerID.Text + "%'" + " AND ";
            }
            if (txtDealerName.Text != "")
            {
                queryString += "DealerName LIKE '%" + txtDealerName.Text + "%' " + " AND ";
            }
            if (txtDealerPhoneNo.Text != "")
            {
                queryString += "DealerPhoneNo LIKE '%" + txtDealerPhoneNo.Text + "%' " + " AND ";
            }
            if (queryString != "")
            {
                queryString = queryString.Remove(queryString.Length - 5);
            }

            return queryString;
        }

        private void changeDgvDealerList(DataTable table)
        {
            dgvDealerList.DataSource = null;
            dgvDealerList.DataSource = table;
            dgvDealerList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDealerList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDealerList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDealerList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DgvDealerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedDealerID= dgvDealerList.Rows[e.RowIndex].Cells["DealerID"].Value.ToString();
                dgvDealerList.Rows[e.RowIndex].Selected = true;
                dealer = new Dealer(selectedDealerID);

                lblDealerID.Text = dealer.DealerID;
                lblDealerName.Text = dealer.DealerName;
                lblDealerPhoneNo.Text = dealer.DealerPhoneNo;
                lblDealerShippingAddress.Text = dealer.DealerShippingAddress;
                lblDealerInvoiceAddress.Text = dealer.DealerInvoiceAddress;
                lblDealerStatus.Text = dealer.DealerStatus;
            }
        }

        private void BtnNewDealer_Click(object sender, EventArgs e)
        {
            frmDealerManagement_NewDealer frmNewDealer = new frmDealerManagement_NewDealer();
            frmNewDealer.Show();
        }

        private void BtnEditDealer_Click(object sender, EventArgs e)
        {
            if (selectedDealerID != "")
            {
                frmDealerManagement_EditDealer frmEditDealer = new frmDealerManagement_EditDealer(selectedDealerID);
                frmEditDealer.Show();
            }
            else
            {
                MessageBox.Show("Please select a dealer");
            }
        }

        private void DgvDealerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedDealerID = dgvDealerList.Rows[e.RowIndex].Cells["DealerID"].Value.ToString();
                dgvDealerList.Rows[e.RowIndex].Selected = true;
                dealer = new Dealer(selectedDealerID);
                BtnEditDealer_Click(sender,e);
            }
        }

        private void ButDisable_Click(object sender, EventArgs e)
        {
            //String dstatus =  ((dealer.DealerStatus == "Available")?);
            //dealer.updataDealerStatus(selectedDealerID,);
        }
    }
}
