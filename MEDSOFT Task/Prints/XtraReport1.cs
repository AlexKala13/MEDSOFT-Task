using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
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

    }
}
