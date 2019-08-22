namespace IFarmer.PL
{
    partial class customerDebtHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerDebtHistory));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnREP = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDocRep = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(12, 91);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 26;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(871, 320);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            this.bunifuCustomDataGrid1.DoubleClick += new System.EventHandler(this.bunifuCustomDataGrid1_DoubleClick);
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveBorderThickness = 1;
            this.btnPrint.ActiveCornerRadius = 20;
            this.btnPrint.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.ActiveForecolor = System.Drawing.Color.White;
            this.btnPrint.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.ButtonText = "طباعة";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.IdleBorderThickness = 1;
            this.btnPrint.IdleCornerRadius = 20;
            this.btnPrint.IdleFillColor = System.Drawing.Color.White;
            this.btnPrint.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnPrint.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.Location = new System.Drawing.Point(257, 425);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(181, 41);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnREP
            // 
            this.btnREP.ActiveBorderThickness = 1;
            this.btnREP.ActiveCornerRadius = 20;
            this.btnREP.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnREP.ActiveForecolor = System.Drawing.Color.White;
            this.btnREP.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnREP.BackColor = System.Drawing.SystemColors.Control;
            this.btnREP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnREP.BackgroundImage")));
            this.btnREP.ButtonText = "سداد الفواتير";
            this.btnREP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnREP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREP.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnREP.IdleBorderThickness = 1;
            this.btnREP.IdleCornerRadius = 20;
            this.btnREP.IdleFillColor = System.Drawing.Color.White;
            this.btnREP.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnREP.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnREP.Location = new System.Drawing.Point(448, 425);
            this.btnREP.Margin = new System.Windows.Forms.Padding(5);
            this.btnREP.Name = "btnREP";
            this.btnREP.Size = new System.Drawing.Size(181, 41);
            this.btnREP.TabIndex = 2;
            this.btnREP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnREP.Click += new System.EventHandler(this.btnREP_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 20;
            this.btnClose.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "الخروج";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.White;
            this.btnClose.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Location = new System.Drawing.Point(66, 425);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDocRep
            // 
            this.btnDocRep.ActiveBorderThickness = 1;
            this.btnDocRep.ActiveCornerRadius = 20;
            this.btnDocRep.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDocRep.ActiveForecolor = System.Drawing.Color.White;
            this.btnDocRep.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDocRep.BackColor = System.Drawing.SystemColors.Control;
            this.btnDocRep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDocRep.BackgroundImage")));
            this.btnDocRep.ButtonText = "سداد المستندات";
            this.btnDocRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocRep.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocRep.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDocRep.IdleBorderThickness = 1;
            this.btnDocRep.IdleCornerRadius = 20;
            this.btnDocRep.IdleFillColor = System.Drawing.Color.White;
            this.btnDocRep.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDocRep.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDocRep.Location = new System.Drawing.Point(639, 425);
            this.btnDocRep.Margin = new System.Windows.Forms.Padding(5);
            this.btnDocRep.Name = "btnDocRep";
            this.btnDocRep.Size = new System.Drawing.Size(181, 41);
            this.btnDocRep.TabIndex = 4;
            this.btnDocRep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDocRep.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // customerDebtHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 480);
            this.Controls.Add(this.btnDocRep);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnREP);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Name = "customerDebtHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerDebtHistory";
            this.Load += new System.EventHandler(this.customerDebtHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPrint;
        private Bunifu.Framework.UI.BunifuThinButton2 btnREP;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDocRep;
    }
}