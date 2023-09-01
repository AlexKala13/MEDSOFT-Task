namespace MEDSOFT_Task
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.patientsGridView = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.PictureBox();
            this.editBtn = new System.Windows.Forms.PictureBox();
            this.removeBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // patientsGridView
            // 
            this.patientsGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.patientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsGridView.Location = new System.Drawing.Point(12, 73);
            this.patientsGridView.Name = "patientsGridView";
            this.patientsGridView.Size = new System.Drawing.Size(899, 456);
            this.patientsGridView.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.Location = new System.Drawing.Point(12, 17);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(50, 50);
            this.addBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.addBtn.TabIndex = 1;
            this.addBtn.TabStop = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.Location = new System.Drawing.Point(68, 16);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(50, 50);
            this.editBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.editBtn.TabIndex = 2;
            this.editBtn.TabStop = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeBtn.Image")));
            this.removeBtn.Location = new System.Drawing.Point(124, 16);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(50, 50);
            this.removeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.removeBtn.TabIndex = 3;
            this.removeBtn.TabStop = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(744, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "MedSoft Test Task\r\nBy Alex Kalandadze\r\n";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(923, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.patientsGridView);
            this.Name = "Main";
            this.Text = "MedSoft Task";
            ((System.ComponentModel.ISupportInitialize)(this.patientsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patientsGridView;
        private System.Windows.Forms.PictureBox addBtn;
        private System.Windows.Forms.PictureBox editBtn;
        private System.Windows.Forms.PictureBox removeBtn;
        private System.Windows.Forms.Label label1;
    }
}

