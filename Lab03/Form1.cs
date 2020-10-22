using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Lab03
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        String conString = "Data Source=(LocalDb)\\TonysoDeep;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        private void loadDatabase()
        {
            
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Student, Faculty WHERE Student.FacultyID = Faculty.FacultyID", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                studentData.AutoGenerateColumns = false;
                studentData.DataSource = dtbl;
                sqlCon.Close();
            }
        }
        private void loadComboBox()
        {

            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT FacultyName FROM Faculty";
                cmd.ExecuteNonQuery();
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sqlDa = new SqlDataAdapter(cmd);
                sqlDa.Fill(dtbl);
                foreach (DataRow dr in dtbl.Rows)
                {
                    cb_nganh.Items.Add(dr["FacultyName"].ToString());
                }
                cb_nganh.SelectedIndex = 0;
                sqlCon.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadDatabase();
            loadComboBox();
        }
        
     

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                int facultyid = 0;

                String nganh = cb_nganh.SelectedItem.ToString();
                if (nganh.Equals("Cong Nghe Thong Tin"))
                    facultyid = 1;
                else if (nganh.Equals("Quan tri kinh doanh"))
                    facultyid = 3;
                else
                    facultyid = 2;
                sqlCon.Open();
                String query = "INSERT INTO Student (StudentID,FullName,AverageScore,FacultyID) VALUES('" + tb_mssv.Text + "','" + tb_ho_ten.Text + "','" + tb_diemTB.Text + "','" + facultyid.ToString() + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Insert sucessfull");
                loadDatabase();
                
               
            }

        }


        private void studentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(studentData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                studentData.CurrentRow.Selected = true;
                tb_mssv.Text = studentData.Rows[e.RowIndex].Cells["StudentID"].FormattedValue.ToString();
                tb_ho_ten.Text = studentData.Rows[e.RowIndex].Cells["FullName"].FormattedValue.ToString();
                tb_diemTB.Text = studentData.Rows[e.RowIndex].Cells["AverageScore"].FormattedValue.ToString();
                if(studentData.Rows[e.RowIndex].Cells["FacultyName"].FormattedValue.ToString().Equals("Ngon Ngu Anh"))
                { 
                    cb_nganh.SelectedIndex = 1;
                }
                if(studentData.Rows[e.RowIndex].Cells["FacultyName"].FormattedValue.ToString().Equals("Quan tri kinh doanh"))
                {
                    
                    cb_nganh.SelectedIndex = 2;
                }
                if (studentData.Rows[e.RowIndex].Cells["FacultyName"].FormattedValue.ToString().Equals("Cong Nghe Thong Tin"))
                {
                    
                    cb_nganh.SelectedIndex = 0;
                }

            }
        }
    }
}
