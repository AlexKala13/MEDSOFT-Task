using MEDSOFT_Task.FormEventHandlers;
using MEDSOFT_Task.HelperMethods;
using MEDSOFT_Task.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDSOFT_Task
{
    public partial class frmAddEdit : Form
    {
        /// <summary>
        /// არჩეული პაციენტის ID
        /// </summary>
        public int PatientId { get; set; }

        public frmAddEdit(int patientId)
        {
            PatientId = patientId;
            InitializeComponent();
            InitializeComboBox();
            LoadPatientData();
        }

        private void InitializeComboBox() // სქესის არჩევის კომბობოქსის ინიციალიზაცია
        {
            CbFillClass.InitializeCb(cbGender);
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
        }

        private void LoadPatientData() // პაციენტის მონაცემების არსებობის შემთხვევაში input-ების შევსება
        {
            if (PatientId != 0)
            {
                DataTable patientData = AddEditPatientHandler.PatientGet(PatientId);

                tbName.Text = patientData.Rows[0]["FullName"].ToString();
                pickerBirthDate.Value = Convert.ToDateTime(patientData.Rows[0]["BirthDate"]);
                cbGender.SelectedValue = Convert.ToInt32(patientData.Rows[0]["GenderID"]);
                tbPhone.Text = patientData.Rows[0]["Phone"].ToString();
                tbAddress.Text = patientData.Rows[0]["Address"].ToString();
                tbEmail.Text = patientData.Rows[0]["Email"].ToString();
                tbPersonalID.Text = patientData.Rows[0]["PersonalID"].ToString();
            }
        }

        private bool ValidateData() // დასამატებელი პაციენტის შეყვანილი მონაცემების ვალიდაცია
        {
            bool result = true;

            // სახელისა და გვარის ვალიდაცია

            if (!string.IsNullOrWhiteSpace(tbName.Text))
            {
                nameErrorLabel.Text = "";
            }
            else // თუ ველი არაა შევსებული
            {
                nameErrorLabel.Text = "შეიყვანეთ სახელი და გვარი !";
                result = false;
            }


            // დაბადების თარიღის ვალიდაცია

            if (pickerBirthDate.Value != null && pickerBirthDate.Value <= DateTime.Now)
            {
                birthDateErrorLabel.Text = "";
            }
            else if (pickerBirthDate.Value != null && pickerBirthDate.Value > DateTime.Now) // თუ შეყვანილი დაბადების თარიღი მომავალშია
            {
                birthDateErrorLabel.Text = "შეიყვანეთ ნამდვილი დაბადების თარიღი !";
                result = false;
            }
            else // თუ დაბადების თარიღი არაა შეყვანილი
            {
                birthDateErrorLabel.Text = "შეიყვანეთ დაბადების თარიღი !";
                result = false;
            }


            // სქესის ვალიდაცია

            if (cbGender.SelectedItem != null)
            {
                genderErrorLabel.Text = "";
            }
            else // თუ პაციენტის სქესი არაა არჩეული
            {
                genderErrorLabel.Text = "აირჩიეთ სქესი !";
                result = false;
            }


            // ტელეფონის ნომრის ვალიდაცია (მითითების შემთხვევაში)

            if (!string.IsNullOrWhiteSpace(tbPhone.Text)) // ჯერ ხდება შემოწმება მითითებულია თუ არა ტელეფონის ნომერი (რადგან ტელეფონის ნომრის შეყვანა არასავალდებულოა)
            {
                if (tbPhone.Text.Length == 9 && tbPhone.Text[0] == '5') // შეყვანილი ნომრის შემოწება (იწყება თუ არა 5-ზე და შეიცავს თუ არა 9 ციფრს)
                {
                    phoneErrorLabel.Text = "";
                }
                else // თუ შეყვანილმა ნომერმა ვერ გაიარა შემოწმება
                {
                    phoneErrorLabel.Text = "ნომერი არასწორადაა მითითებული !";
                    result = false;
                }
            }


            // პირადი ნომრის ვალიდაცია

            if (!string.IsNullOrWhiteSpace(tbPersonalID.Text) && tbPersonalID.Text.Length == 11) // მომწმდება შეყვანილია თუ არა პირადი ნომერი და შეიცავს თუ არა 11 სიმბოლოს
            {
                pIdErrorLabel.Text = "";
            }
            else if (tbPersonalID.Text != null && tbPersonalID.Text.Length != 11) // თუ შეყვანილია, მაგრამ არ შეიცავს 11 სიმბოლოს
            {
                pIdErrorLabel.Text = "პირადი ნომერი უნდა შეიცავდეს 11 ციფრს !";
                result = false;
            }
            else // თუ არაა შეყვანილი
            {
                pIdErrorLabel.Text = "შეიყვანეთ პირადი ნომერი !";
                result = false;
            }

            return result;
        }

        private void btnAddEdit_Click(object sender, EventArgs e) // დამატება/რედაქტირების ღილაკი
        {
            if (ValidateData()) // დამატება/რედაქტირებამდე ვატარებთ შეყვანილი მონაცემების ვალიდაციას
            {
                PatientModel model = new PatientModel(); // ვქმნით პაციენტის მოდელს და ვანიჭებთ მის ველებს შეყვანილი მონაცემების მნიშვნელობებს
                model.ID = PatientId;
                model.FullName = tbName.Text;
                model.Email = tbEmail.Text;
                model.BirthDate = pickerBirthDate.Value;
                model.Address = tbAddress.Text;
                model.personalId = tbPersonalID.Text;
                model.Phone = tbPhone.Text;
                model.GenderId = (int)cbGender.SelectedValue;

                AddEditPatientHandler.PatientSet(model);

                // პაციენტის რედაქტირების ფანჯრის ჩახურვა

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e) // გაუქმების ღილაკი
        {
            this.Close();
        }
    }
}