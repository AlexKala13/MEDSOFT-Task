
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
            this.Detail.HeightF = 564.5236F;
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
            this.xrFullNameHeader.Text = "სახელი / გვარი";
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
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.DataSourceSchema = resources.GetString("$this.DataSourceSchema");
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 51, 100);
            this.Version = "21.2";
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
    }
}
