using MEDSOFT_Task.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MEDSOFT_Task.FormEventHandlers;
using DevExpress.XtraReports.UI;

namespace MEDSOFT_Task
{
    public partial class Main : Form
    {
        /// <summary>
        /// არჩეული პაციენტის ID
        /// </summary>
        public int _SelectedPatientID
        {
            get
            {
                return Convert.ToInt32(gvPatients.GetFocusedRowCellValue(colId).ToString());
            }
        }

        /// <summary>
        /// არჩეული პაციენტები
        /// </summary>
        public int[] _SelectedPatients
        {
            get
            {
                return gvPatients.GetSelectedRows();
            }
        }

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
            dataGrid.DataSource = MainHandler.GetPatients(null);
            gvPatients.BestFitColumns();
        }

        private void addBtn_Click(object sender, EventArgs e) // პაციენტის დამატების ღილაკი
        {
            frmAddEdit addEditForm = new frmAddEdit(0);
            if (addEditForm.ShowDialog() == DialogResult.OK) // არჩეული პაციენტის რედაქტირების ფანჯრის გახსნა
            {
                LoadData();
            }
        }

        private void editBtn_Click(object sender, EventArgs e) // პაციენტის რედაქტირების ღილაკი
        {
            if (gvPatients.SelectedRowsCount == 1)
            {
                frmAddEdit addEditForm = new frmAddEdit(_SelectedPatientID);
                if (addEditForm.ShowDialog() == DialogResult.OK) // არჩეული პაციენტის რედაქტირების ფანჯრის გახსნა
                {
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("აირჩიეთ მხოლოდ ერთი პაციენტი!");
            }
        }

        private void duplicateBtn_Click(object sender, EventArgs e) // პაციენტის ჩანაწერის დუბლირების ღილაკი
        {
            if (_SelectedPatients.Length > 0)
            {
                MainHandler.Duplicate(_SelectedPatientID);
                LoadData();
            }
            else
            {
                MessageBox.Show("აირჩიეთ მხოლოდ ერთი პაციენტი!");
            }
        }

        private void printBtn_Click(object sender, EventArgs e) // პაციენტის ჩანაწერის პრინტი
        {
            if (_SelectedPatientID > 0)
            {
                var print = new XtraReport1();
                print.DataSource = MainHandler.PatientDSFill(_SelectedPatientID);
                print.ShowRibbonPreviewDialog();

            }
            else
            {
                MessageBox.Show("აირჩიეთ მხოლოდ ერთი პაციენტი!");
            }
        }

        private void removeBtn_Click(object sender, EventArgs e) // პაციენტის წაშლის ღილაკი
        {
            List<int> selectedPatientIDs = new List<int>();  // ვქმნით ლისტს არჩეული ჩანაწერების შესანახად

            foreach (int rowHandle in _SelectedPatients)
            {
                int patientID = (int)gvPatients.GetRowCellValue(rowHandle, colId);
                selectedPatientIDs.Add(patientID);  // ვამატებთ ლისტში არჩეულ ჩანაწერებს
            }

            if (selectedPatientIDs.Count > 0)
            {
                DialogResult result = MessageBox.Show($"გსურთ მონიშნული ჩანაწერის წაშლა?", "წაშლის დადასტურება",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MainHandler.DeletePatients(selectedPatientIDs); // ვიძახებთ წაშლის მეთოდს handler კლასში
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("აირჩიეთ პაციენტი!");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string patientToSearch = searchingTb.Text;

            if (patientToSearch != null)
            {
                dataGrid.DataSource = MainHandler.GetPatients(patientToSearch);
            } else
            {
                MessageBox.Show("შეიყვანეთ პაციენტის გვარი და სახელი!");
            }
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            searchingTb.Text = "";
            LoadData();
        }
    }
}