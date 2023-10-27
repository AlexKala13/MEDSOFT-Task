
namespace MEDSOFT_Task.FormEventHandlers
{
    partial class XtraReport1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport1));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrCbFemale = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCbMale = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrGenderHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xrAddressHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPhoneHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrEmailHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBirthDateHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPIdHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrFullNameHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xrHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.ID = new DevExpress.XtraReports.UI.XRTableCell();
            this.FullName = new DevExpress.XtraReports.UI.XRTableCell();
            this.BirthDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.PatientGender = new DevExpress.XtraReports.UI.XRTableCell();
            this.Phone = new DevExpress.XtraReports.UI.XRTableCell();
            this.Address = new DevExpress.XtraReports.UI.XRTableCell();
            this.Email = new DevExpress.XtraReports.UI.XRTableCell();
            this.PersonalID = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.patientDataSet1 = new MEDSOFT_Task.Prints.PatientDataSet();
            this.patientDataSet2 = new MEDSOFT_Task.Prints.PatientDataSet();
            this.patientDataSet3 = new MEDSOFT_Task.Prints.PatientDataSet();
            this.patientDataSet4 = new MEDSOFT_Task.Prints.PatientDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 51.04167F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCbFemale,
            this.xrCbMale,
            this.xrGenderHeader,
            this.xrAddressHeader,
            this.xrLabel8,
            this.xrPhoneHeader,
            this.xrLabel10,
            this.xrEmailHeader,
            this.xrLabel12,
            this.xrLabel6,
            this.xrBirthDateHeader,
            this.xrLabel4,
            this.xrPIdHeader,
            this.xrLabel2,
            this.xrFullNameHeader,
            this.xrHeader});
            this.Detail.HeightF = 354.107F;
            this.Detail.Name = "Detail";
            // 
            // xrCbFemale
            // 
            this.xrCbFemale.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[PatientDataTable].[PatientGender]")});
            this.xrCbFemale.LocationFloat = new DevExpress.Utils.PointFloat(364.4928F, 153.2808F);
            this.xrCbFemale.Name = "xrCbFemale";
            this.xrCbFemale.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCbFemale.SizeF = new System.Drawing.SizeF(122.8261F, 23F);
            this.xrCbFemale.Text = "მდედრობითი";
            // 
            // xrCbMale
            // 
            this.xrCbMale.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[PatientDataTable].[PatientGender]")});
            this.xrCbMale.LocationFloat = new DevExpress.Utils.PointFloat(241.6667F, 153.2808F);
            this.xrCbMale.Name = "xrCbMale";
            this.xrCbMale.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCbMale.SizeF = new System.Drawing.SizeF(122.8261F, 23F);
            this.xrCbMale.Text = "მამრობითი";
            this.xrCbMale.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrCheckBox1_BeforePrint);
            // 
            // xrGenderHeader
            // 
            this.xrGenderHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrGenderHeader.LocationFloat = new DevExpress.Utils.PointFloat(241.6667F, 130.2808F);
            this.xrGenderHeader.Multiline = true;
            this.xrGenderHeader.Name = "xrGenderHeader";
            this.xrGenderHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrGenderHeader.SizeF = new System.Drawing.SizeF(245.6522F, 23F);
            this.xrGenderHeader.StylePriority.UseFont = false;
            this.xrGenderHeader.Text = "სქესი";
            // 
            // xrAddressHeader
            // 
            this.xrAddressHeader.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrAddressHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 130.2808F);
            this.xrAddressHeader.Multiline = true;
            this.xrAddressHeader.Name = "xrAddressHeader";
            this.xrAddressHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrAddressHeader.SizeF = new System.Drawing.SizeF(200F, 23F);
            this.xrAddressHeader.StylePriority.UseFont = false;
            this.xrAddressHeader.Text = "მისამართი";
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PatientDataTable].[Address]")});
            this.xrLabel8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 153.2808F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(200F, 23F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "პაციენტის მონაცემები";
            // 
            // xrPhoneHeader
            // 
            this.xrPhoneHeader.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrPhoneHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 200.933F);
            this.xrPhoneHeader.Multiline = true;
            this.xrPhoneHeader.Name = "xrPhoneHeader";
            this.xrPhoneHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPhoneHeader.SizeF = new System.Drawing.SizeF(200F, 23F);
            this.xrPhoneHeader.StylePriority.UseFont = false;
            this.xrPhoneHeader.Text = "ტელეფონი";
            // 
            // xrLabel10
            // 
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PatientDataTable].[Phone]")});
            this.xrLabel10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 223.933F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(200F, 23F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "პაციენტის მონაცემები";
            // 
            // xrEmailHeader
            // 
            this.xrEmailHeader.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrEmailHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 279.1938F);
            this.xrEmailHeader.Multiline = true;
            this.xrEmailHeader.Name = "xrEmailHeader";
            this.xrEmailHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrEmailHeader.SizeF = new System.Drawing.SizeF(200F, 23F);
            this.xrEmailHeader.StylePriority.UseFont = false;
            this.xrEmailHeader.Text = "ელ. ფოსტა";
            // 
            // xrLabel12
            // 
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PatientDataTable].[Email]")});
            this.xrLabel12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 302.1938F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(200F, 23F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = "პაციენტის მონაცემები";
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PatientDataTable].[BirthDate]")});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(466.6667F, 78.69743F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(173.3333F, 23F);
            this.xrLabel6.Text = "პაციენტის მონაცემები";
            // 
            // xrBirthDateHeader
            // 
            this.xrBirthDateHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrBirthDateHeader.LocationFloat = new DevExpress.Utils.PointFloat(466.6667F, 55.69747F);
            this.xrBirthDateHeader.Multiline = true;
            this.xrBirthDateHeader.Name = "xrBirthDateHeader";
            this.xrBirthDateHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrBirthDateHeader.SizeF = new System.Drawing.SizeF(173.3333F, 23F);
            this.xrBirthDateHeader.StylePriority.UseFont = false;
            this.xrBirthDateHeader.Text = "დაბადების თარიღი";
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PatientDataTable].[PersonalID]")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(241.6667F, 78.69743F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(200F, 23F);
            this.xrLabel4.Text = "პაციენტის მონაცემები";
            // 
            // xrPIdHeader
            // 
            this.xrPIdHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrPIdHeader.LocationFloat = new DevExpress.Utils.PointFloat(241.6667F, 55.69747F);
            this.xrPIdHeader.Multiline = true;
            this.xrPIdHeader.Name = "xrPIdHeader";
            this.xrPIdHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPIdHeader.SizeF = new System.Drawing.SizeF(200F, 23F);
            this.xrPIdHeader.StylePriority.UseFont = false;
            this.xrPIdHeader.Text = "პირადი ნომერი";
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PatientDataTable].[FullName]")});
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 78.69743F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(200F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "პაციენტის მონაცემები";
            // 
            // xrFullNameHeader
            // 
            this.xrFullNameHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrFullNameHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 55.69747F);
            this.xrFullNameHeader.Multiline = true;
            this.xrFullNameHeader.Name = "xrFullNameHeader";
            this.xrFullNameHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrFullNameHeader.SizeF = new System.Drawing.SizeF(200F, 23F);
            this.xrFullNameHeader.StylePriority.UseFont = false;
            this.xrFullNameHeader.Text = "გვარი / სახელი";
            // 
            // xrHeader
            // 
            this.xrHeader.BorderColor = System.Drawing.Color.Black;
            this.xrHeader.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.xrHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.xrHeader.LocationFloat = new DevExpress.Utils.PointFloat(181.8841F, 0F);
            this.xrHeader.Multiline = true;
            this.xrHeader.Name = "xrHeader";
            this.xrHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrHeader.SizeF = new System.Drawing.SizeF(282.6087F, 23F);
            this.xrHeader.StylePriority.UseBorderColor = false;
            this.xrHeader.StylePriority.UseFont = false;
            this.xrHeader.StylePriority.UseForeColor = false;
            this.xrHeader.Text = "პაციენტის მონაცემები";
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrTable1});
            this.Detail1.HeightF = 50F;
            this.Detail1.Name = "Detail1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(243.6821F, 2.000014F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(213.5417F, 23F);
            this.xrLabel1.Text = "პაციენტების ცხრილი";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.ID,
            this.FullName,
            this.BirthDate,
            this.PatientGender,
            this.Phone,
            this.Address,
            this.Email,
            this.PersonalID});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 0.5D;
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.StylePriority.UseFont = false;
            this.ID.Text = "ID";
            this.ID.Weight = 1D;
            // 
            // FullName
            // 
            this.FullName.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.FullName.Multiline = true;
            this.FullName.Name = "FullName";
            this.FullName.StylePriority.UseFont = false;
            this.FullName.Text = "სახელი გვარი";
            this.FullName.Weight = 1D;
            // 
            // BirthDate
            // 
            this.BirthDate.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.BirthDate.Multiline = true;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.StylePriority.UseFont = false;
            this.BirthDate.Text = "დაბ. თარიღი";
            this.BirthDate.Weight = 1D;
            // 
            // PatientGender
            // 
            this.PatientGender.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.PatientGender.Multiline = true;
            this.PatientGender.Name = "PatientGender";
            this.PatientGender.StylePriority.UseFont = false;
            this.PatientGender.Text = "სქესი";
            this.PatientGender.Weight = 1D;
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.Phone.Multiline = true;
            this.Phone.Name = "Phone";
            this.Phone.StylePriority.UseFont = false;
            this.Phone.Text = "ტელეფონი";
            this.Phone.Weight = 1D;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.StylePriority.UseFont = false;
            this.Address.Text = "მისამართი";
            this.Address.Weight = 1D;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.StylePriority.UseFont = false;
            this.Email.Text = "ელ. ფოსტა";
            this.Email.Weight = 1D;
            // 
            // PersonalID
            // 
            this.PersonalID.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.PersonalID.Multiline = true;
            this.PersonalID.Name = "PersonalID";
            this.PersonalID.StylePriority.UseFont = false;
            this.PersonalID.Text = "პირადი ნომერი";
            this.PersonalID.Weight = 1D;
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable2.SizeF = new System.Drawing.SizeF(650F, 25F);
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ID]")});
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 0.8125D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FullName]")});
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.Weight = 0.8125D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BirthDate]")});
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.TextFormatString = "{0:dd/MM/yyyy}";
            this.xrTableCell3.Weight = 0.8125D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PatientGender]")});
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.Weight = 0.8125D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Phone]")});
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.Weight = 0.8125D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Address]")});
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "xrTableCell6";
            this.xrTableCell6.Weight = 0.8106893920898437D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Email]")});
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "xrTableCell7";
            this.xrTableCell7.Weight = 0.81431060791015619D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PersonalID]")});
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "xrTableCell8";
            this.xrTableCell8.Weight = 0.81431060791015619D;
            // 
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2});
            this.DetailReport1.DataMember = "AllPatientsDataTable";
            this.DetailReport1.Level = 1;
            this.DetailReport1.Name = "DetailReport1";
            // 
            // Detail2
            // 
            this.Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail2.HeightF = 25F;
            this.Detail2.Name = "Detail2";
            // 
            // patientDataSet1
            // 
            this.patientDataSet1.DataSetName = "PatientDataSet";
            this.patientDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientDataSet2
            // 
            this.patientDataSet2.DataSetName = "PatientDataSet";
            this.patientDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientDataSet3
            // 
            this.patientDataSet3.DataSetName = "PatientDataSet";
            this.patientDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientDataSet4
            // 
            this.patientDataSet4.DataSetName = "PatientDataSet";
            this.patientDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.DetailReport,
            this.DetailReport1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.patientDataSet1,
            this.patientDataSet2,
            this.patientDataSet3,
            this.patientDataSet4});
            this.DataSourceSchema = resources.GetString("$this.DataSourceSchema");
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 51, 100);
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrAddressHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrPhoneHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrEmailHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrBirthDateHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrPIdHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrFullNameHeader;
        private DevExpress.XtraReports.UI.XRLabel xrHeader;
        private DevExpress.XtraReports.UI.XRCheckBox xrCbFemale;
        private DevExpress.XtraReports.UI.XRCheckBox xrCbMale;
        private DevExpress.XtraReports.UI.XRLabel xrGenderHeader;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell ID;
        private DevExpress.XtraReports.UI.XRTableCell FullName;
        private DevExpress.XtraReports.UI.XRTableCell BirthDate;
        private DevExpress.XtraReports.UI.XRTableCell PatientGender;
        private DevExpress.XtraReports.UI.XRTableCell Phone;
        private DevExpress.XtraReports.UI.XRTableCell Address;
        private DevExpress.XtraReports.UI.XRTableCell Email;
        private DevExpress.XtraReports.UI.XRTableCell PersonalID;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private Prints.PatientDataSet patientDataSet2;
        private Prints.PatientDataSet patientDataSet1;
        private Prints.PatientDataSet patientDataSet3;
        private Prints.PatientDataSet patientDataSet4;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
        private DevExpress.XtraReports.UI.DetailBand Detail2;
    }
}
