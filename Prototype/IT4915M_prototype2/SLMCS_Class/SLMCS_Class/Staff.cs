using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SLMCS_ERP;

namespace SLMCS_Class
{
    public class Staff
    {
        private string staffID;
        private string password;
        private DateTime passwordChangeDate;
        private string staffName;
        private string staffPhoneNo;
        private string staffPositionID;//determine the system function
        private string departmentID;
        private string staffStatus;

        private DBConnection dbConnection;
        private DataTable staffTable;

        private Department _department; //may don't need
        private List<ReorderOrder> _reorderOrder;


        public Staff()
        {
            dbConnection = new DBConnection();
        }

        public Staff(string staffID)
        {
            dbConnection = new DBConnection();
            _reorderOrder = new List<ReorderOrder>();

            string query = "SELECT * FROM Staff WHERE StaffID ='" + staffID + "'";

            staffTable = dbConnection.GetDataTable(query);
            DataRow[] rows = staffTable.Select();
            if (rows.Length <= 0)
            {
                throw new Exception("Staff ID invalid! Please Try again.");
            }
            StaffID = (string)rows[0]["StaffID"];
            Password = (string)rows[0]["Password"];
            PasswordChangeDate = (DateTime)rows[0]["PasswordChangeDate"];
            StaffName = (string)rows[0]["StaffName"];
            StaffPhoneNo = (string)rows[0]["StaffPhoneNo"];
            //StaffPositionID = (string)rows[0]["StaffPositionID"];
            departmentID = (string)rows[0]["DepartmentID"];
            staffStatus = (string)rows[0]["StaffStatus"];
        }
        //login the system via staffID and password
        public bool Verify(string password)
        {
            return password == this.password;
        }
        //change staff login password
        public bool ChangePassword(string newPassword)
        {
            if (Verify(password))
            {
                dbConnection.Update("Staff", "Password='" + newPassword + "', PasswordChangeDate=" + "CURDATE()" + "", "WHERE StaffID='" + staffID + "'");
                password = newPassword;
                //PasswordChangeDate = DateTime.Today.ToString("dd/MM/yyyy");
                Console.WriteLine("change successful"); // for testing
                return true;
            }
            Console.WriteLine("change fail"); // for testing
            return false;
        }
        //staffPhoneNo for checking the password


        public string ForgetPassword(string _staffPhoneNo)
        {
            if (_staffPhoneNo == staffPhoneNo)
            {
                return password;
            }
            else
            {
                return null;
            }
        }

        public string RandomPassword()
        {
            var uperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var lowerChars = "abcdefghijklmnopqrstuvwxyz";
            var numbers = "0123456789";
            var stringChars = new char[7];
            var random = new Random();

            for (int i = 0; i < 1; i++)
            {
                stringChars[i] = uperChars[random.Next(uperChars.Length)];
            }
            for (int i = 1; i < 6; i++)
            {
                stringChars[i] = numbers[random.Next(numbers.Length)];
            }
            for (int i = 6; i < 7; i++)
            {
                stringChars[i] = lowerChars[random.Next(lowerChars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }

        //CreateStaffAccount incomplete
        public void CreateStaffAccount(string staffID, string password, string staffName, string staffPhoneNo, string departmentID, string staffStatus)
        {
                string queryString = "INSERT INTO Staff VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
                string query = string.Format(queryString, staffID, password, DateTime.Now.ToString("yyMMdd"), staffName, staffPhoneNo, departmentID, staffStatus);
                try
                {
                    dbConnection.Insert(query);
                }
                catch (MySqlException ex)
                {
                    throw ex;
                }
            }
        public void EditStaffAccount(string staffID, string password, string staffName, string staffPhoneNo, string departmentID, string staffStatus)
        {
            string queryString = "UPDATE Staff SET StaffName='{0}', StaffPhoneNo='{1}' ,DepartmentID='{2}', StaffStatus='{3}', Password = {4}, PasswordChangeDate = {5} WHERE StaffID='{6}'";
            string query = string.Format(queryString, staffName, staffPhoneNo, departmentID, staffStatus, password, DateTime.Now.ToString("yyMMdd") ,staffID);

            try
            {
                dbConnection.Update(query);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public void EditStaffAccountPasswordUnchanged(string staffID, string staffName, string staffPhoneNo, string departmentID, string staffStatus)
        {
            string queryString = "UPDATE Staff SET StaffName='{0}', StaffPhoneNo='{1}' ,DepartmentID='{2}', StaffStatus='{3}' WHERE StaffID='{4}'";
            string query = string.Format(queryString, staffName, staffPhoneNo, departmentID, staffStatus, staffID);

            try
            {
                dbConnection.Update(query);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        //new Staff ID for creation
        public string GetNextStaffID()
        {
                string query = "SELECT COUNT(StaffID) FROM Staff WHERE StaffID LIKE 'S" + DateTime.Now.ToString("yy") + "%'";
                staffTable = dbConnection.GetDataTable(query);

                string count = "";
                foreach (DataRow row in staffTable.Rows)
                {
                    count = row["COUNT(StaffID)"].ToString();
                }
                count = (Int32.Parse(count) + 1).ToString();
                string nextOrderID = "S" + DateTime.Now.ToString("yy") + count.PadLeft(6, '0');
                return nextOrderID;
        }

        public DataTable GetStaffTable(string condition)
        {
            string query = "SELECT StaffID, StaffName, PasswordChangeDate, DepartmentID, StaffStatus FROM Staff ";
            if (condition != "")
            {
                query += "WHERE "+ condition;
            }
            return dbConnection.GetDataTable(query);
        }

        public void AddReorderOrder(ReorderOrder reorderOrder)
        {
            _reorderOrder.Add(reorderOrder);
        }

        public void RemoveReorderOrder(ReorderOrder reorderOrder)
        {
            _reorderOrder.Add(reorderOrder);
        }

        public List<ReorderOrder> GetStaffReorderOrders()
        {
            return _reorderOrder;
        }


        //        all get set method below
        public string StaffID
        {
            get => staffID;
            set => staffID = value;
        }
        public string StaffName
        {
            get => staffName;
            set => staffName = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public DateTime PasswordChangeDate
        {
            get => passwordChangeDate;
            set => passwordChangeDate = value;
        }

        public string StaffPhoneNo
        {
            get => staffPhoneNo;
            set => staffPhoneNo = value;
        }

        public string StaffPositionID
        {
            get => staffPositionID;
            set => staffPositionID = value;
        }

        public string DepartmentID
        {
            get => departmentID;
            set => departmentID = value;
        }

        //may don't need
        public Department Department
        {
            get => _department;
            set => _department = value;
        }
        public string StaffStatus { get => staffStatus; set => staffStatus = value; }

        public override string ToString()
        {
            string staffDetail = staffID + ", " + password + ", ";
            return staffDetail + staffName + ", " + staffPhoneNo + ", " + staffPositionID + ", " + departmentID;
        }
    }
}