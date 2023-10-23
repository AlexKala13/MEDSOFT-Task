using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
