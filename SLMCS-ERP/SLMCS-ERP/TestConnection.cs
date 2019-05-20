using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SLMCS_ERP
{
    public partial class TestConnection : Form
    {
        DBConnection mysqlcon = new DBConnection();
        public TestConnection()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                mysqlcon.openConnection();
                MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mysqlcon.getDataTable("SELECT * FROM testTable");

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
               // mysqlcon.insert("testTable", "2, 'Peter'");
                mysqlcon.insert("INSERT INTO testTable VALUES (3,'KKK')");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                mysqlcon.update("UPDATE testTable SET name='OKOK'");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                mysqlcon.delete("DELETE FROM testTable");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
