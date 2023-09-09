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

namespace MEDSOFT_Task
{
    public partial class Main : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString; // connection string-ის მიღება app.config ფაილიდან
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dataTable;

        public Main()
        {
            // მეთოდების გამოძახება
            InitializeDatabase();
            InitializeComponent();
            InitializeDataGridView();
            LoadPatientsData();
        }

        private void InitializeDatabase() // მონაცემთა ბაზასთან დაკავშირდება და მონაცემების წამოღება პროცედურის გამოყენებით
        {
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
            dataTable = new DataTable();

            using (SqlCommand command = new SqlCommand("GetPatientsData", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
            }
        }


        private void LoadPatientsData() // მონაცემთა ბაზიდან წამოღებული მონაცემებით ცხრილის შევსება
        {
            patientsGridView.DataSource = dataTable;
        }

        private void InitializeDataGridView() // ცხრილის ინიციალიზირება (სვეტები)
        {
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "ID";

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "პაციენტის გვარი სახელი";
            nameColumn.DataPropertyName = "FullName";

            DataGridViewTextBoxColumn birthDateColumn = new DataGridViewTextBoxColumn();
            birthDateColumn.HeaderText = "დაბ. თარიღი";
            birthDateColumn.DataPropertyName = "BirthDate";

            DataGridViewTextBoxColumn genderColumn = new DataGridViewTextBoxColumn();
            genderColumn.HeaderText = "სქესი";
            genderColumn.DataPropertyName = "GenderName";

            DataGridViewTextBoxColumn phoneColumn = new DataGridViewTextBoxColumn();
            phoneColumn.HeaderText = "ტელეფონი";
            phoneColumn.DataPropertyName = "Phone";

            DataGridViewTextBoxColumn addressColummn = new DataGridViewTextBoxColumn();
            addressColummn.HeaderText = "მისამართი";
            addressColummn.DataPropertyName = "Address";

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.HeaderText = "ელ. ფოსტა";
            emailColumn.DataPropertyName = "Email";

            DataGridViewTextBoxColumn personalIdColumn = new DataGridViewTextBoxColumn();
            personalIdColumn.HeaderText = "პირადი ნომერი";
            personalIdColumn.DataPropertyName = "PersonalId";

            patientsGridView.Columns.Add(idColumn);
            patientsGridView.Columns.Add(nameColumn);
            patientsGridView.Columns.Add(birthDateColumn);
            patientsGridView.Columns.Add(genderColumn);
            patientsGridView.Columns.Add(phoneColumn);
            patientsGridView.Columns.Add(addressColummn);
            patientsGridView.Columns.Add(emailColumn);
            patientsGridView.Columns.Add(personalIdColumn);

            patientsGridView.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == patientsGridView.Columns[3].Index && e.Value != null)
                {
                    string gender = e.Value.ToString();
                    if (gender == "Male")
                    {
                        e.Value = "მამრობითი";
                    } else if (gender == "Female"){
                        e.Value = "მდედრობითი";
                    }
                }
            };
            patientsGridView.AutoGenerateColumns = false;
            patientsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            patientsGridView.DataSource = dataTable;
        }


        // დამატების ფუნქცია

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddPatientForm addForm = new AddPatientForm();
            if (addForm.ShowDialog() == DialogResult.OK) // პაციენტის დამატების ფანჯრის გახსნა
            {
                dataTable.Clear();
                adapter.Fill(dataTable);
                patientsGridView.DataSource = dataTable;
            }
        }


        // რედაქტირების ფუნქცია

        private void editBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = patientsGridView.SelectedCells[0].RowIndex;
            if (!string.IsNullOrEmpty(patientsGridView.Rows[selectedRowIndex].Cells[0].Value?.ToString())) // შემოწმება არჩეულია თუ არა პაციენტი
            {
                int patientId = Convert.ToInt32(patientsGridView.Rows[selectedRowIndex].Cells[0].Value); // პაციენტის აიდის პოვნა

                EditPatientForm editForm = new EditPatientForm(patientId);
                if (editForm.ShowDialog() == DialogResult.OK) // არჩეული პაციენტის რედაქტირების ფანჯრის გახსნა
                {
                    dataTable.Clear();
                    adapter.Fill(dataTable);
                    patientsGridView.DataSource = dataTable;
                }
            } else
            {
                MessageBox.Show("აირჩიეთ პაციენტი!", "შეცდომა", MessageBoxButtons.OK); // პაციენტი არაა არჩეული
            }
        }
        

        // წაშლის ფუნქცია

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = patientsGridView.SelectedCells[0].RowIndex; // არჩეული უჯრის მწკრივის ინდექსის პოვნა

            if (!string.IsNullOrEmpty(patientsGridView.Rows[selectedRowIndex].Cells[0].Value?.ToString())) // შემოწმება არჩეულია თუ არა პაციენტი
            {
                int patientId = Convert.ToInt32(patientsGridView.Rows[selectedRowIndex].Cells[0].Value); // პაციენტის აიდის პოვნა

                DialogResult result = MessageBox.Show($"გსურთ მონიშნული ჩანაწერის წაშლა?", "წაშლის დადასტურება", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // მონაცემთა ბაზიდან პაციენტის ამოშლა პროცედურის გამოძახებით
                        using (SqlCommand command = new SqlCommand("DeletePatient", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@PatientID", patientId);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }

                        dataTable.Rows.RemoveAt(selectedRowIndex);
                        patientsGridView.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"წაშლა ვერ მოხერხდა!\n{ex}", "შეცდომა");
                    }
                }

            }
            else
            {
                MessageBox.Show("აირჩიეთ პაციენტი!", "შეცდომა", MessageBoxButtons.OK); // პაციენტი არაა არჩეული
            }
            
        }
    }
}
