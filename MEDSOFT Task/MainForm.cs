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
using System.Configuration;
using MEDSOFT_Task.Model;

namespace MEDSOFT_Task
{
    public partial class Main : Form
    {
       

        public Main()
        {
            // მეთოდების გამოძახება
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGrid.DataSource = MainHandler.GetPatients();
            gvPatients.BestFitColumns();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //AddEditForm addEditForm = new AddEditForm(null);
            //if (addEditForm.ShowDialog() == DialogResult.OK) // არჩეული პაციენტის რედაქტირების ფანჯრის გახსნა
            //{
            //    dataTable.Clear();
            //    adapter.Fill(dataTable);
            //    dataGrid.DataSource = dataTable;
            //}
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            PatientModel model = new PatientModel();
            model.ID = Convert.ToInt32(gvPatients.GetFocusedRowCellValue(colId).ToString());
            model.FullName = gvPatients.GetFocusedRowCellValue(colFullName).ToString();
            model.Phone = gvPatients.GetFocusedRowCellValue(colPhone).ToString();
            model.personalId = gvPatients.GetFocusedRowCellValue(colPersonalId).ToString();
            model.Email = gvPatients.GetFocusedRowCellValue(colEmail).ToString();
            model.GenderName = gvPatients.GetFocusedRowCellValue(colGenderName).ToString();
            model.BirthDate = Convert.ToDateTime(gvPatients.GetFocusedRowCellValue(colBirthDate).ToString());
            model.Address = gvPatients.GetFocusedRowCellValue(colAddress).ToString();

            AddEditForm addEditForm = new AddEditForm(model);
            if (addEditForm.ShowDialog() == DialogResult.OK) // არჩეული პაციენტის რედაქტირების ფანჯრის გახსნა
            {
                LoadData();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            //var patientId = gvPatients.GetFocusedRowCellValue(colId);

            //if (patientId != null) // შემოწმება არჩეულია თუ არა პაციენტი
            //{
            //    DialogResult result = MessageBox.Show($"გსურთ მონიშნული ჩანაწერის წაშლა?", "წაშლის დადასტურება",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question);

            //    if (result == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            // მონაცემთა ბაზიდან პაციენტის ამოშლა პროცედურის გამოძახებით
            //            using (SqlCommand command = new SqlCommand("DeletePatient", connection))
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@PatientID", patientId);

            //                connection.Open();
            //                command.ExecuteNonQuery();
            //                connection.Close();
            //            }
            //            dataTable.Clear();
            //            adapter.Fill(dataTable);
            //            dataGrid.DataSource = dataTable;
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show($"წაშლა ვერ მოხერხდა!\n{ex}", "შეცდომა");
            //        }
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("აირჩიეთ პაციენტი!", "შეცდომა", MessageBoxButtons.OK); // პაციენტი არაა არჩეული
            //}
        }
    }
}