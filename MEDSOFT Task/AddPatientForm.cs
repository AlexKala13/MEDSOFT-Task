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
using System.Xml.Linq;

namespace MEDSOFT_Task
{
    public partial class AddPatientForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString; // connection string-ის მიღება app.config ფაილიდან
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dataTable;

        public AddPatientForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            InitializeComboBox();
        }

        private void InitializeComboBox() // სქესის არჩევის კომბობოქსის ინიციალიზაცია
        {
            // სქესების წამოღება ბაზიდან
            string query = "SELECT GenderID, GenderName FROM Gender";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // კომბობოქსის item-ების შექმნა
                {
                    int genderID = Convert.ToInt32(reader["GenderID"]);
                    string genderName = reader["GenderName"].ToString();
                    genderCb.Items.Add(new KeyValuePair<int, string>(genderID, genderName));
                }

                reader.Close();
                connection.Close();
            }
        }

        private void addBtn_Click(object sender, EventArgs e) // დამატების ფუნქცია
        {
            int invalidDataCounter = 0; // არასწორად შეყვანილი მონაცემების მთვლელი ცვლადი

            // ბაზაში დასამატებელი ელემენტის პარამეტრთა ცვალდები
            string name = "";
            DateTime birthdate = DateTime.Now;
            int genderID = 0;
            string phoneNumber = "";
            string address = "";
            string email = "";
            string personalId = "";


            // დასამატებელი პაციენტის შეყვანილი მონაცემების ვალიდაცია //

            // სახელისა და გვარის ვალიდაცია

            if (!string.IsNullOrWhiteSpace(nameTb.Text))
            {
                name = nameTb.Text;
                nameErrorLabel.Text = "";
            }
            else // თუ ველი არაა შევსებული
            {
                nameErrorLabel.Text = "შეიყვანეთ სახელი და გვარი !"; 
                invalidDataCounter++;
            }


            // დაბადების თარიღის ვალიდაცია

            if (birthdatePicker.Value != null && birthdatePicker.Value <= DateTime.Now)
            {
                birthdate = birthdatePicker.Value;
                birthDateErrorLabel.Text = "";
            }
            else if (birthdatePicker.Value != null && birthdatePicker.Value > DateTime.Now) // თუ შეყვანილი დაბადების თარიღი მომავალშია
            {
                birthDateErrorLabel.Text = "შეიყვანეთ ნამდვილი დაბადების თარიღი !";
                invalidDataCounter++;
            }
            else // თუ დაბადების თარიღი არაა შეყვანილი
            {
                birthDateErrorLabel.Text = "შეიყვანეთ დაბადების თარიღი !";
                invalidDataCounter++;
            }


            // სქესის ვალიდაცია

            if (genderCb.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedGender = (KeyValuePair<int, string>)genderCb.SelectedItem;
                genderID = selectedGender.Key;
                genderErrorLabel.Text = "";
            } else // თუ პაციენტის სქესი არაა არჩეული
            {
                genderErrorLabel.Text = "აირჩიეთ სქესი !";
                invalidDataCounter++;
            }


            // ტელეფონის ნომრის ვალიდაცია (მითითების შემთხვევაში)

            if (!string.IsNullOrWhiteSpace(phoneTb.Text)) // ჯერ ხდება შემოწმება მითითებულია თუ არა ტელეფონის ნომერი (რადგან ტელეფონის ნომრის შეყვანა არასავალდებულოა)
            {
                if (phoneTb.Text.Length == 9 && phoneTb.Text[0] == '5') // შეყვანილი ნომრის შემოწება (იწყება თუ არა 5-ზე და შეიცავს თუ არა 9 ციფრს)
                {
                    phoneNumber = phoneTb.Text;
                    phoneErrorLabel.Text = "";
                }
                else // თუ შეყვანილმა ნომერმა ვერ გაიარა შემოწმება
                {
                    phoneErrorLabel.Text = "ნომერი არასწორადაა მითითებული !";
                    invalidDataCounter++;
                }
            }


            // პირადი ნომრის ვალიდაცია

            if (!string.IsNullOrWhiteSpace(personalIdTb.Text) && personalIdTb.Text.Length == 11) // მომწმდება შეყვანილია თუ არა პირადი ნომერი და შეიცავს თუ არა 11 სიმბოლოს
            {
                personalId = personalIdTb.Text;
                pIdErrorLabel.Text = "";
            }
            else if (personalIdTb.Text != null && personalIdTb.Text.Length != 11) // თუ შეყვანილია, მაგრამ არ შეიცავს 11 სიმბოლოს
            {
                pIdErrorLabel.Text = "პირადი ნომერი უნდა შეიცავდეს 11 ციფრს !";
                invalidDataCounter++;
            }
            else // თუ არაა შეყვანილი
            {
                pIdErrorLabel.Text = "შეიყვანეთ პირადი ნომერი !";
                invalidDataCounter++;
            }

            if (invalidDataCounter > 0) // თუ არის არასწორად შეყვანილი მონაცემები მაშინ პროგრამა ჩერდება და მომხმარებელი ხედავს ვალიდაციის შენიშვნებს სავალდებულო ველებზე
            {
                return;
            }

            address = addressTb.Text; // პაციენტის მისამართი
            email = emailTb.Text; // პაციენტის ელ.ფოსტა


            // პაციენტის დამატება მონაცემთა ბაზაში //

            string insertQuery = "INSERT INTO Patients (FullName, BirthDate, GenderID"; 

            if (!string.IsNullOrEmpty(phoneNumber)) // მოწმდება მითითებულია თუ არა ტელეფონი, ასეთ შემთხვევაში query string-ს დაემატება ტელეფონის მონაცემი
            {
                insertQuery += ", Phone";
            }

            if (!string.IsNullOrEmpty(address)) // მოწმდება მითითებულია თუ არა მისამართი, ასეთ შემთხვევაში query string-ს დაემატება მისამართის მონაცემი
            {
                insertQuery += ", Address";
            }

            if (!string.IsNullOrEmpty(email)) // მოწმდება მითითებულია თუ არა ელ.ფოსტა, ასეთ შემთხვევაში query string-ს დაემატება ელ.ფოსტის მონაცემი
            {
                insertQuery += ", Email";
            }

            insertQuery += ", PersonalID) VALUES (@FullName, @BirthDate, @GenderID";

            if (!string.IsNullOrEmpty(phoneNumber))
            {
                insertQuery += ", @Phone";
            }

            if (!string.IsNullOrEmpty(address))
            {
                insertQuery += ", @Address";
            }

            if (!string.IsNullOrEmpty(email))
            {
                insertQuery += ", @Email";
            }

            insertQuery += ", @PersonalID)";


            // query string-ისა და connection string-ის მეშვეობით ხდება ბაზაში ახალი პაციენტის დამატება

            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@FullName", name);
                command.Parameters.AddWithValue("@BirthDate", birthdate);
                command.Parameters.AddWithValue("@GenderID", genderID);

                if (!string.IsNullOrEmpty(phoneNumber))
                {
                    command.Parameters.AddWithValue("@Phone", phoneNumber);
                }

                if (!string.IsNullOrEmpty(address))
                {
                    command.Parameters.AddWithValue("@Address", address);
                }

                if (!string.IsNullOrEmpty(email))
                {
                    command.Parameters.AddWithValue("@Email", email);
                }

                command.Parameters.AddWithValue("@PersonalID", personalId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }


            // პაციენტის დამატების ფანჯრის ჩახურვა

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
