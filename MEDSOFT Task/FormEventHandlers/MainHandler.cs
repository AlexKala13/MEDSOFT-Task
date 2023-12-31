﻿using MEDSOFT_Task.Prints;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDSOFT_Task
{
    public class MainHandler
    {
        public static DataTable GetPatients()
        {
            DataTable dataTable = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter("GetPatientsData", DatabaseAccess.Connect()))
            {
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                dataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        public static void DeletePatients(List<int> patientIDs)
        {
            DataTable table = new DataTable();
            table.Columns.Add("PatientID", typeof(int));

            foreach (int patientID in patientIDs)
            {
                table.Rows.Add(patientID);
            }

            using (SqlConnection connection = DatabaseAccess.Connect())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DeletePatients", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PatientIDs", table);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public static DataSet PatientDSFill(int patientId)
        {
            var dataSet = new PatientDataSet();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter("GetPatient", DatabaseAccess.Connect()))
            {
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.AddWithValue("@PatientID", patientId);

                dataAdapter.TableMappings.Add("Table", "PatientDataTable");
                dataAdapter.TableMappings.Add("Table1", "AllPatientsDataTable");
                dataAdapter.Fill(dataSet);
            }

            return dataSet;
        }

        public static void Duplicate(int patientId)
        {
            using (SqlCommand command = new SqlCommand("DuplicatePatient", DatabaseAccess.Connect()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PatientID", patientId);

                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }
    }
}