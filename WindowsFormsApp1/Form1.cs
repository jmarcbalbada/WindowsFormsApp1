using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
 

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataManager.UserData;
            //dataGridView1.ReadOnly = true;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                DataGridViewRow row = dataGridView1.SelectedRows[0];

                string name = row.Cells["name"].Value.ToString();
                string address = row.Cells["address"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();
                string age = row.Cells["age"].Value.ToString();
                string username = row.Cells["username"].Value.ToString();
                string saying = row.Cells["saying"].Value.ToString();
                string color = row.Cells["color"].Value.ToString();
                string gender = row.Cells["gender"].Value.ToString();
                string sport = row.Cells["sport"].Value.ToString();
                string birthday = row.Cells["birthday"].Value.ToString();
                string password = row.Cells["password"].Value.ToString();

                Program.signUpForm.SetUpdateMode(name, address, email, age, username, saying, color, gender, sport, birthday,password);

                Program.signUpForm.Show(); 
                Program.signUpForm.BringToFront();
            }
            else
            {
                MessageBox.Show("Please select a record to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string username = dataGridView1.SelectedRows[0].Cells["username"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    for (int i = DataManager.UserData.Rows.Count - 1; i >= 0; i--)
                    {
                        DataRow row = DataManager.UserData.Rows[i];
                        if (row["username"].ToString() == username)
                        {
                            DataManager.UserData.Rows.Remove(row);
                            break;
                        }
                    }

                    if (DataManager.users.ContainsKey(username))
                    {
                        DataManager.users.Remove(username);
                    }

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.UserData;

                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                // refresh
                dataGridView1.DataSource = null; 
                dataGridView1.DataSource = DataManager.UserData; 
                return;
            }

            DataTable filteredTable = DataManager.UserData.Clone(); 

            foreach (DataRow row in DataManager.UserData.Rows)
            {
                if (row["username"].ToString().ToLower().Contains(searchText)) 
                {
                    filteredTable.ImportRow(row); 
                    break;
                }
            }

            if (filteredTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = filteredTable;
            }
            else
            {
                MessageBox.Show("No matching record found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            if(DataManager.UserData != null)
            {
                // create excel file
                using (var workbook = new XLWorkbook())
                {
                    // worksheet
                    var worksheet = workbook.AddWorksheet("User Data");

                    DataTable dataTable = DataManager.UserData;

                    // add col
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dataTable.Columns[i].ColumnName;
                    }

                    // add row
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = dataTable.Rows[i][j].ToString();
                        }
                    }

                    // save
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.FileName = "User Data.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No data to be exported! Populate fields first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }
    }
}
