using DevExpress.XtraReports.UI;
using MEDSOFT_Task.Prints;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace MEDSOFT_Task.FormEventHandlers
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        private void xrCheckBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string gender = GetCurrentColumnValue("PatientGender").ToString();
            if (gender == "მამრობითი")
            {
                xrCbMale.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            } else if (gender == "მდედრობითი")
            {
                xrCbFemale.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            }
        }

        //private void xrTable1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    XRTable table = (XRTable)sender;

        //    PatientDataSet dataSet = (PatientDataSet)this.DataSource;

        //    DataTable dataTable = dataSet.Tables["AllPatientsDataTable"];

        //    foreach(DataRow dataRow in dataTable.Rows)
        //    {
        //        XRTableRow tableRow = new XRTableRow();

        //        XRTableCell cell1 = new XRTableCell();
        //        cell1.Text = dataRow["ID"].ToString();
        //        tableRow.Cells.Add(cell1);

        //        XRTableCell cell2 = new XRTableCell();
        //        cell2.Text = dataRow["FullName"].ToString();
        //        tableRow.Cells.Add(cell2);

        //        XRTableCell cell3 = new XRTableCell();
        //        cell3.Text = dataRow["BirthDate"].ToString();
        //        tableRow.Cells.Add(cell3);

        //        XRTableCell cell4 = new XRTableCell();
        //        cell4.Text = dataRow["PatientGender"].ToString();
        //        tableRow.Cells.Add(cell4);

        //        XRTableCell cell5 = new XRTableCell();
        //        cell5.Text = dataRow["Phone"].ToString();
        //        tableRow.Cells.Add(cell5);

        //        XRTableCell cell6 = new XRTableCell();
        //        cell6.Text = dataRow["Address"].ToString();
        //        tableRow.Cells.Add(cell6);

        //        XRTableCell cell7 = new XRTableCell();
        //        cell7.Text = dataRow["Email"].ToString();
        //        tableRow.Cells.Add(cell7);

        //        XRTableCell cell8 = new XRTableCell();
        //        cell8.Text = dataRow["PersonalID"].ToString();
        //        tableRow.Cells.Add(cell8);
        //    }
        //}
    }
}
