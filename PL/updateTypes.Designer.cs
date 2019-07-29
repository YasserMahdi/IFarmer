namespace IFarmer.PL
{
    partial class updateTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateTypes));
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntCatSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtCatName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnClose.ButtonText = "خروج";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.White;
            this.btnClose.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Location = new System.Drawing.Point(251, 385);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(302, 41);
            this.btnClose.TabIndex = 8;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntCatSave);
            this.groupBox2.Controls.Add(this.txtCatName);
            this.groupBox2.Location = new System.Drawing.Point(229, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 352);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الانواع";
            // 
            // bntCatSave
            // 
            this.bntCatSave.ActiveBorderThickness = 1;
            this.bntCatSave.ActiveCornerRadius = 20;
            this.bntCatSave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bntCatSave.ActiveForecolor = System.Drawing.Color.White;
            this.bntCatSave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bntCatSave.BackColor = System.Drawing.SystemColors.Control;
            this.bntCatSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntCatSave.BackgroundImage")));
            this.bntCatSave.ButtonText = "حفظ";
            this.bntCatSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCatSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCatSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.bntCatSave.IdleBorderThickness = 1;
            this.bntCatSave.IdleCornerRadius = 20;
            this.bntCatSave.IdleFillColor = System.Drawing.Color.White;
            this.bntCatSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bntCatSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bntCatSave.Location = new System.Drawing.Point(22, 168);
            this.bntCatSave.Margin = new System.Windows.Forms.Padding(5);
            this.bntCatSave.Name = "bntCatSave";
            this.bntCatSave.Size = new System.Drawing.Size(302, 41);
            this.bntCatSave.TabIndex = 1;
            this.bntCatSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntCatSave.Click += new System.EventHandler(this.bntCatSave_Click);
            // 
            // txtCatName
            // 
            this.txtCatName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCatName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCatName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCatName.HintForeColor = System.Drawing.Color.Empty;
            this.txtCatName.HintText = "";
            this.txtCatName.isPassword = false;
            this.txtCatName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCatName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCatName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCatName.LineThickness = 3;
            this.txtCatName.Location = new System.Drawing.Point(22, 86);
            this.txtCatName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(302, 44);
            this.txtCatName.TabIndex = 0;
            this.txtCatName.Text = "اسم النوع";
            this.txtCatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // updateTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateTypes";
            this.Load += new System.EventHandler(this.updateTypes_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 bntCatSave;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCatName;
    }
}