namespace YazılımYapımıProje
{
    partial class AdminScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.questionInformationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imgQuestion = new System.Windows.Forms.PictureBox();
            this.questionInformationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.questionInformationsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.imgShowQuestion = new System.Windows.Forms.PictureBox();
            this.imgRejectIcon = new System.Windows.Forms.PictureBox();
            this.btnShowQuestion = new System.Windows.Forms.Button();
            this.imgAcceptIcon = new System.Windows.Forms.PictureBox();
            this.btnReject = new System.Windows.Forms.Button();
            this.imgExitIcon = new System.Windows.Forms.PictureBox();
            this.btnAccepted = new System.Windows.Forms.Button();
            this.lblStick = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.imgAdminIcon = new System.Windows.Forms.PictureBox();
            this.panelAdminLogo = new System.Windows.Forms.Panel();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.questionInformationsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dbStudentExamSystemDataSet1 = new YazılımYapımıProje.dbStudentExamSystemDataSet1();
            this.panelMenuSide = new System.Windows.Forms.Panel();
            this.dbStudentExamSystemDataSet = new YazılımYapımıProje.dbStudentExamSystemDataSet();
            this.dbStudentExamSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionInformationsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.questionInformationsTableAdapter = new YazılımYapımıProje.dbStudentExamSystemDataSetTableAdapters.QuestionInformationsTableAdapter();
            this.questionInformationsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.questionInformationsTableAdapter1 = new YazılımYapımıProje.dbStudentExamSystemDataSet1TableAdapters.QuestionInformationsTableAdapter();
            this.questionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.questionInformationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionInformationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionInformationsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgShowQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRejectIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAcceptIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdminIcon)).BeginInit();
            this.panelAdminLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionInformationsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudentExamSystemDataSet1)).BeginInit();
            this.panelMenuSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudentExamSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudentExamSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionInformationsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionInformationsBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // questionInformationsBindingSource
            // 
            this.questionInformationsBindingSource.DataMember = "QuestionInformations";
            // 
            // imgQuestion
            // 
            this.imgQuestion.BackColor = System.Drawing.Color.White;
            this.imgQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imgQuestion.Location = new System.Drawing.Point(296, 534);
            this.imgQuestion.Name = "imgQuestion";
            this.imgQuestion.Size = new System.Drawing.Size(978, 521);
            this.imgQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgQuestion.TabIndex = 21;
            this.imgQuestion.TabStop = false;
            // 
            // questionInformationsBindingSource1
            // 
            this.questionInformationsBindingSource1.DataMember = "QuestionInformations";
            // 
            // questionInformationsBindingSource2
            // 
            this.questionInformationsBindingSource2.DataMember = "QuestionInformations";
            // 
            // imgShowQuestion
            // 
            this.imgShowQuestion.BackColor = System.Drawing.Color.Transparent;
            this.imgShowQuestion.Image = ((System.Drawing.Image)(resources.GetObject("imgShowQuestion.Image")));
            this.imgShowQuestion.Location = new System.Drawing.Point(31, 556);
            this.imgShowQuestion.Name = "imgShowQuestion";
            this.imgShowQuestion.Size = new System.Drawing.Size(43, 38);
            this.imgShowQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgShowQuestion.TabIndex = 75;
            this.imgShowQuestion.TabStop = false;
            // 
            // imgRejectIcon
            // 
            this.imgRejectIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgRejectIcon.Image")));
            this.imgRejectIcon.Location = new System.Drawing.Point(31, 483);
            this.imgRejectIcon.Name = "imgRejectIcon";
            this.imgRejectIcon.Size = new System.Drawing.Size(43, 38);
            this.imgRejectIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRejectIcon.TabIndex = 74;
            this.imgRejectIcon.TabStop = false;
            // 
            // btnShowQuestion
            // 
            this.btnShowQuestion.BackColor = System.Drawing.Color.Black;
            this.btnShowQuestion.Enabled = false;
            this.btnShowQuestion.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnShowQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnShowQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnShowQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowQuestion.ForeColor = System.Drawing.Color.White;
            this.btnShowQuestion.Location = new System.Drawing.Point(0, 544);
            this.btnShowQuestion.Name = "btnShowQuestion";
            this.btnShowQuestion.Size = new System.Drawing.Size(296, 64);
            this.btnShowQuestion.TabIndex = 19;
            this.btnShowQuestion.Text = "Resmi Gör";
            this.btnShowQuestion.UseVisualStyleBackColor = false;
            this.btnShowQuestion.Click += new System.EventHandler(this.btnShowQuestion_Click);
            // 
            // imgAcceptIcon
            // 
            this.imgAcceptIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgAcceptIcon.Image")));
            this.imgAcceptIcon.Location = new System.Drawing.Point(31, 417);
            this.imgAcceptIcon.Name = "imgAcceptIcon";
            this.imgAcceptIcon.Size = new System.Drawing.Size(43, 38);
            this.imgAcceptIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAcceptIcon.TabIndex = 73;
            this.imgAcceptIcon.TabStop = false;
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnReject.Enabled = false;
            this.btnReject.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnReject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnReject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReject.Location = new System.Drawing.Point(0, 474);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(296, 64);
            this.btnReject.TabIndex = 72;
            this.btnReject.Text = "Reddet";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // imgExitIcon
            // 
            this.imgExitIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgExitIcon.Image")));
            this.imgExitIcon.Location = new System.Drawing.Point(31, 627);
            this.imgExitIcon.Name = "imgExitIcon";
            this.imgExitIcon.Size = new System.Drawing.Size(43, 38);
            this.imgExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgExitIcon.TabIndex = 71;
            this.imgExitIcon.TabStop = false;
            // 
            // btnAccepted
            // 
            this.btnAccepted.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAccepted.Enabled = false;
            this.btnAccepted.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAccepted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnAccepted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAccepted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccepted.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccepted.ForeColor = System.Drawing.Color.White;
            this.btnAccepted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccepted.Location = new System.Drawing.Point(0, 404);
            this.btnAccepted.Name = "btnAccepted";
            this.btnAccepted.Size = new System.Drawing.Size(296, 64);
            this.btnAccepted.TabIndex = 70;
            this.btnAccepted.Text = "Kabul Et";
            this.btnAccepted.UseVisualStyleBackColor = false;
            this.btnAccepted.Click += new System.EventHandler(this.btnAccepted_Click);
            // 
            // lblStick
            // 
            this.lblStick.BackColor = System.Drawing.Color.White;
            this.lblStick.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStick.ForeColor = System.Drawing.Color.White;
            this.lblStick.Location = new System.Drawing.Point(-5, 317);
            this.lblStick.Name = "lblStick";
            this.lblStick.Size = new System.Drawing.Size(330, 2);
            this.lblStick.TabIndex = 69;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 614);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(296, 64);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Black;
            this.lblAdmin.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(107, 260);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(110, 34);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "ADMIN";
            // 
            // imgAdminIcon
            // 
            this.imgAdminIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgAdminIcon.Image")));
            this.imgAdminIcon.Location = new System.Drawing.Point(55, 51);
            this.imgAdminIcon.Name = "imgAdminIcon";
            this.imgAdminIcon.Size = new System.Drawing.Size(203, 196);
            this.imgAdminIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAdminIcon.TabIndex = 0;
            this.imgAdminIcon.TabStop = false;
            // 
            // panelAdminLogo
            // 
            this.panelAdminLogo.BackColor = System.Drawing.Color.Black;
            this.panelAdminLogo.Controls.Add(this.lblAdmin);
            this.panelAdminLogo.Controls.Add(this.imgAdminIcon);
            this.panelAdminLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminLogo.Location = new System.Drawing.Point(0, 0);
            this.panelAdminLogo.Name = "panelAdminLogo";
            this.panelAdminLogo.Size = new System.Drawing.Size(296, 314);
            this.panelAdminLogo.TabIndex = 0;
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.dgvQuestions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuestions.AutoGenerateColumns = false;
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionIDDataGridViewTextBoxColumn,
            this.classLevelDataGridViewTextBoxColumn,
            this.LessonName});
            this.dgvQuestions.DataSource = this.questionInformationsBindingSource5;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuestions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuestions.EnableHeadersVisualStyles = false;
            this.dgvQuestions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.dgvQuestions.Location = new System.Drawing.Point(296, 0);
            this.dgvQuestions.MultiSelect = false;
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvQuestions.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQuestions.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.dgvQuestions.RowTemplate.Height = 40;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(978, 1055);
            this.dgvQuestions.TabIndex = 20;
            this.dgvQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestions_CellClick);
            // 
            // questionInformationsBindingSource5
            // 
            this.questionInformationsBindingSource5.DataMember = "QuestionInformations";
            this.questionInformationsBindingSource5.DataSource = this.dbStudentExamSystemDataSet1;
            // 
            // dbStudentExamSystemDataSet1
            // 
            this.dbStudentExamSystemDataSet1.DataSetName = "dbStudentExamSystemDataSet1";
            this.dbStudentExamSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelMenuSide
            // 
            this.panelMenuSide.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelMenuSide.Controls.Add(this.imgShowQuestion);
            this.panelMenuSide.Controls.Add(this.imgRejectIcon);
            this.panelMenuSide.Controls.Add(this.btnShowQuestion);
            this.panelMenuSide.Controls.Add(this.imgAcceptIcon);
            this.panelMenuSide.Controls.Add(this.btnReject);
            this.panelMenuSide.Controls.Add(this.imgExitIcon);
            this.panelMenuSide.Controls.Add(this.btnAccepted);
            this.panelMenuSide.Controls.Add(this.lblStick);
            this.panelMenuSide.Controls.Add(this.btnExit);
            this.panelMenuSide.Controls.Add(this.panelAdminLogo);
            this.panelMenuSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuSide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMenuSide.Location = new System.Drawing.Point(0, 0);
            this.panelMenuSide.Name = "panelMenuSide";
            this.panelMenuSide.Size = new System.Drawing.Size(296, 1055);
            this.panelMenuSide.TabIndex = 19;
            // 
            // dbStudentExamSystemDataSet
            // 
            this.dbStudentExamSystemDataSet.DataSetName = "dbStudentExamSystemDataSet";
            this.dbStudentExamSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbStudentExamSystemDataSetBindingSource
            // 
            this.dbStudentExamSystemDataSetBindingSource.DataSource = this.dbStudentExamSystemDataSet;
            this.dbStudentExamSystemDataSetBindingSource.Position = 0;
            // 
            // questionInformationsBindingSource3
            // 
            this.questionInformationsBindingSource3.DataMember = "QuestionInformations";
            this.questionInformationsBindingSource3.DataSource = this.dbStudentExamSystemDataSetBindingSource;
            // 
            // questionInformationsTableAdapter
            // 
            this.questionInformationsTableAdapter.ClearBeforeFill = true;
            // 
            // questionInformationsBindingSource4
            // 
            this.questionInformationsBindingSource4.DataMember = "QuestionInformations";
            this.questionInformationsBindingSource4.DataSource = this.dbStudentExamSystemDataSetBindingSource;
            // 
            // questionInformationsTableAdapter1
            // 
            this.questionInformationsTableAdapter1.ClearBeforeFill = true;
            // 
            // questionIDDataGridViewTextBoxColumn
            // 
            this.questionIDDataGridViewTextBoxColumn.DataPropertyName = "QuestionID";
            this.questionIDDataGridViewTextBoxColumn.HeaderText = "QuestionID";
            this.questionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.questionIDDataGridViewTextBoxColumn.Name = "questionIDDataGridViewTextBoxColumn";
            this.questionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classLevelDataGridViewTextBoxColumn
            // 
            this.classLevelDataGridViewTextBoxColumn.DataPropertyName = "ClassLevel";
            this.classLevelDataGridViewTextBoxColumn.HeaderText = "ClassLevel";
            this.classLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classLevelDataGridViewTextBoxColumn.Name = "classLevelDataGridViewTextBoxColumn";
            this.classLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LessonName
            // 
            this.LessonName.DataPropertyName = "LessonName";
            this.LessonName.HeaderText = "LessonName";
            this.LessonName.MinimumWidth = 6;
            this.LessonName.Name = "LessonName";
            this.LessonName.ReadOnly = true;
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 1055);
            this.Controls.Add(this.imgQuestion);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.panelMenuSide);
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminScreen";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionInformationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionInformationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionInformationsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgShowQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRejectIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAcceptIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdminIcon)).EndInit();
            this.panelAdminLogo.ResumeLayout(false);
            this.panelAdminLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionInformationsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudentExamSystemDataSet1)).EndInit();
            this.panelMenuSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbStudentExamSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudentExamSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionInformationsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionInformationsBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource questionInformationsBindingSource;
        private System.Windows.Forms.PictureBox imgQuestion;
        private System.Windows.Forms.BindingSource questionInformationsBindingSource1;
        private System.Windows.Forms.BindingSource questionInformationsBindingSource2;
        private System.Windows.Forms.PictureBox imgShowQuestion;
        private System.Windows.Forms.PictureBox imgRejectIcon;
        private System.Windows.Forms.Button btnShowQuestion;
        private System.Windows.Forms.PictureBox imgAcceptIcon;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.PictureBox imgExitIcon;
        private System.Windows.Forms.Button btnAccepted;
        private System.Windows.Forms.Label lblStick;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox imgAdminIcon;
        private System.Windows.Forms.Panel panelAdminLogo;
        public System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Panel panelMenuSide;
        private System.Windows.Forms.BindingSource dbStudentExamSystemDataSetBindingSource;
        private dbStudentExamSystemDataSet dbStudentExamSystemDataSet;
        private System.Windows.Forms.BindingSource questionInformationsBindingSource3;
        private dbStudentExamSystemDataSetTableAdapters.QuestionInformationsTableAdapter questionInformationsTableAdapter;
        private System.Windows.Forms.BindingSource questionInformationsBindingSource4;
        private dbStudentExamSystemDataSet1 dbStudentExamSystemDataSet1;
        private System.Windows.Forms.BindingSource questionInformationsBindingSource5;
        private dbStudentExamSystemDataSet1TableAdapters.QuestionInformationsTableAdapter questionInformationsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
    }
}