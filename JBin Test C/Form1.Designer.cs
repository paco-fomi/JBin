namespace JBin_Test_C
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIntro = new System.Windows.Forms.Label();
            this.GroupBoxAll = new System.Windows.Forms.GroupBox();
            this.scrollIndex = new System.Windows.Forms.HScrollBar();
            this.BtnGo = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GroupBoxClient = new System.Windows.Forms.GroupBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.lblView = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.GroupBoxAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.GroupBoxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(12, 188);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(711, 90);
            this.lblIntro.TabIndex = 17;
            this.lblIntro.Text = "Loading records One moment, please";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBoxAll
            // 
            this.GroupBoxAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxAll.Controls.Add(this.BtnGo);
            this.GroupBoxAll.Controls.Add(this.BtnNew);
            this.GroupBoxAll.Controls.Add(this.NumericUpDown1);
            this.GroupBoxAll.Controls.Add(this.BtnEdit);
            this.GroupBoxAll.Controls.Add(this.BtnSave);
            this.GroupBoxAll.Controls.Add(this.BtnCancel);
            this.GroupBoxAll.Controls.Add(this.GroupBoxClient);
            this.GroupBoxAll.Controls.Add(this.BtnDelete);
            this.GroupBoxAll.Controls.Add(this.Label8);
            this.GroupBoxAll.Location = new System.Drawing.Point(21, 50);
            this.GroupBoxAll.Name = "GroupBoxAll";
            this.GroupBoxAll.Size = new System.Drawing.Size(691, 516);
            this.GroupBoxAll.TabIndex = 16;
            this.GroupBoxAll.TabStop = false;
            this.GroupBoxAll.Visible = false;
            // 
            // scrollIndex
            // 
            this.scrollIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollIndex.LargeChange = 1;
            this.scrollIndex.Location = new System.Drawing.Point(470, 23);
            this.scrollIndex.Maximum = 0;
            this.scrollIndex.Name = "scrollIndex";
            this.scrollIndex.Size = new System.Drawing.Size(242, 24);
            this.scrollIndex.TabIndex = 6;
            this.scrollIndex.ValueChanged += new System.EventHandler(this.scrollIndex_ValueChanged);
            // 
            // BtnGo
            // 
            this.BtnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGo.Location = new System.Drawing.Point(631, 476);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(41, 25);
            this.BtnGo.TabIndex = 8;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNew.Location = new System.Drawing.Point(20, 466);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(79, 34);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericUpDown1.Location = new System.Drawing.Point(534, 477);
            this.NumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(92, 23);
            this.NumericUpDown1.TabIndex = 9;
            this.NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEdit.Location = new System.Drawing.Point(105, 466);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(79, 34);
            this.BtnEdit.TabIndex = 0;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.Location = new System.Drawing.Point(275, 466);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(79, 34);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.Location = new System.Drawing.Point(360, 466);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(79, 34);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GroupBoxClient
            // 
            this.GroupBoxClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GroupBoxClient.Controls.Add(this.Label12);
            this.GroupBoxClient.Controls.Add(this.DateTimePicker1);
            this.GroupBoxClient.Controls.Add(this.Label9);
            this.GroupBoxClient.Controls.Add(this.Label3);
            this.GroupBoxClient.Controls.Add(this.txtCountry);
            this.GroupBoxClient.Controls.Add(this.txtMobile);
            this.GroupBoxClient.Controls.Add(this.Label4);
            this.GroupBoxClient.Controls.Add(this.txtID);
            this.GroupBoxClient.Controls.Add(this.Label7);
            this.GroupBoxClient.Controls.Add(this.Label11);
            this.GroupBoxClient.Controls.Add(this.lblColor);
            this.GroupBoxClient.Controls.Add(this.Label6);
            this.GroupBoxClient.Controls.Add(this.Label10);
            this.GroupBoxClient.Controls.Add(this.Label5);
            this.GroupBoxClient.Controls.Add(this.Label2);
            this.GroupBoxClient.Controls.Add(this.txtAddress);
            this.GroupBoxClient.Controls.Add(this.txtEmail);
            this.GroupBoxClient.Controls.Add(this.Label1);
            this.GroupBoxClient.Controls.Add(this.txtName);
            this.GroupBoxClient.Controls.Add(this.txtDetails);
            this.GroupBoxClient.Location = new System.Drawing.Point(20, 42);
            this.GroupBoxClient.Name = "GroupBoxClient";
            this.GroupBoxClient.Size = new System.Drawing.Size(655, 408);
            this.GroupBoxClient.TabIndex = 3;
            this.GroupBoxClient.TabStop = false;
            // 
            // Label12
            // 
            this.Label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label12.BackColor = System.Drawing.Color.Silver;
            this.Label12.Location = new System.Drawing.Point(13, 183);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(617, 1);
            this.Label12.TabIndex = 5;
            this.Label12.Text = "HairColor";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker1.Location = new System.Drawing.Point(341, 215);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(289, 23);
            this.DateTimePicker1.TabIndex = 4;
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // Label9
            // 
            this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(338, 259);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(50, 15);
            this.Label9.TabIndex = 3;
            this.Label9.Text = "Country";
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(338, 123);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(44, 15);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Mobile";
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountry.Location = new System.Drawing.Point(341, 279);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(289, 23);
            this.txtCountry.TabIndex = 2;
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobile.Location = new System.Drawing.Point(341, 143);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(289, 23);
            this.txtMobile.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(13, 19);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(18, 15);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(16, 39);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(82, 23);
            this.txtID.TabIndex = 2;
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(338, 195);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(55, 15);
            this.Label7.TabIndex = 3;
            this.Label7.Text = "Birthdate";
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label11.BackColor = System.Drawing.Color.Silver;
            this.Label11.Location = new System.Drawing.Point(13, 251);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(617, 1);
            this.Label11.TabIndex = 3;
            this.Label11.Text = "HairColor";
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblColor.Location = new System.Drawing.Point(13, 215);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(94, 24);
            this.lblColor.TabIndex = 3;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(13, 195);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(58, 15);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "HairColor";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(13, 310);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(42, 15);
            this.Label10.TabIndex = 3;
            this.Label10.Text = "Details";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(13, 259);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(49, 15);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "Address";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 123);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(36, 15);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(16, 279);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(280, 23);
            this.txtAddress.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 71);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 15);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(16, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(614, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(16, 330);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(614, 64);
            this.txtDetails.TabIndex = 1;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.Location = new System.Drawing.Point(190, 466);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(79, 34);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(535, 458);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(36, 15);
            this.Label8.TabIndex = 3;
            this.Label8.Text = "Jump";
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Location = new System.Drawing.Point(603, 572);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(109, 34);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Visible = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblView
            // 
            this.lblView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblView.Location = new System.Drawing.Point(79, 26);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(384, 18);
            this.lblView.TabIndex = 14;
            this.lblView.Text = "0 of 0";
            this.lblView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(16, 9);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(71, 25);
            this.Label13.TabIndex = 15;
            this.Label13.Text = "Clients";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 615);
            this.Controls.Add(this.scrollIndex);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.GroupBoxAll);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.Label13);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(750, 654);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Example Client (C#.NET)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxAll.ResumeLayout(false);
            this.GroupBoxAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.GroupBoxClient.ResumeLayout(false);
            this.GroupBoxClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblIntro;
        internal System.Windows.Forms.GroupBox GroupBoxAll;
        internal System.Windows.Forms.HScrollBar scrollIndex;
        internal System.Windows.Forms.Button BtnGo;
        internal System.Windows.Forms.Button BtnNew;
        internal System.Windows.Forms.NumericUpDown NumericUpDown1;
        internal System.Windows.Forms.Button BtnEdit;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.GroupBox GroupBoxClient;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtCountry;
        internal System.Windows.Forms.TextBox txtMobile;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label lblColor;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtDetails;
        internal System.Windows.Forms.Button BtnDelete;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button BtnExit;
        internal System.Windows.Forms.Label lblView;
        internal System.Windows.Forms.Label Label13;
    }
}

