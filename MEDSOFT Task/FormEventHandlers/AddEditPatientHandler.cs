using MEDSOFT_Task.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDSOFT_Task
{
    public class AddEditPatientHandler
    {
        public static int PatientSet(PatientModel model)
        {
            int result = 0;

            using (SqlCommand command = new SqlCommand("Patient_Set", DatabaseAccess.Connect()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PatientID", model.ID);
                command.Parameters.AddWithValue("@FullName", model.FullName);
                command.Parameters.AddWithValue("@BirthDate", model.BirthDate);
                command.Parameters.AddWithValue("@GenderID", model.GenderId);
                command.Parameters.AddWithValue("@Phone", model.Phone);
                command.Parameters.AddWithValue("@Address", model.Address);
                command.Parameters.AddWithValue("@Email", model.Email);
                command.Parameters.AddWithValue("@PersonalID", model.personalId);

                command.Connection.Open();
                result = command.ExecuteNonQuery();
                command.Connection.Close();
            }

            return result;
        }

        public static DataTable PatientGet(int patientId)
        {
            DataTable dataTable = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter("Patient_GetOne", DatabaseAccess.Connect()))
            {
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.AddWithValue("@PatientID", patientId);

                dataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}