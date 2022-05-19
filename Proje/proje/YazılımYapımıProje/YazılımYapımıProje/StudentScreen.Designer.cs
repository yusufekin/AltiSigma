
namespace YazılımYapımıProje
{
    partial class StudentScreen
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
            System.Environment.Exit(0);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentScreen));
            this.panelDashBoard = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.picLogoIcon = new System.Windows.Forms.PictureBox();
            this.lblConstUserName = new System.Windows.Forms.Label();
            this.lblConstUserID = new System.Windows.Forms.Label();
            this.btnStartExam = new System.Windows.Forms.Button();
            this.panelExamModul = new System.Windows.Forms.Panel();
            this.panelDashBoard.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDashBoard
            // 
            this.panelDashBoard.BackColor = System.Drawing.Color.DimGray;
            this.panelDashBoard.Controls.Add(this.btnSettings);
            this.panelDashBoard.Controls.Add(this.btnLeave);
            this.panelDashBoard.Controls.Add(this.pnlMenu);
            this.panelDashBoard.Controls.Add(this.btnStartExam);
            this.panelDashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDashBoard.Location = new System.Drawing.Point(0, 0);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(296, 1055);
            this.panelDashBoard.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.DimGray;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 438);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(296, 46);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "AYARLAR";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.DimGray;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLeave.ForeColor = System.Drawing.Color.White;
            this.btnLeave.Location = new System.Drawing.Point(0, 490);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(296, 46);
            this.btnLeave.TabIndex = 3;
            this.btnLeave.Text = "ÇIKIŞ YAP";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.lblUserID);
            this.pnlMenu.Controls.Add(this.lblUserName);
            this.pnlMenu.Controls.Add(this.picLogoIcon);
            this.pnlMenu.Controls.Add(this.lblConstUserName);
            this.pnlMenu.Controls.Add(this.lblConstUserID);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(296, 307);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(138, 238);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(46, 17);
            this.lblUserID.TabIndex = 15;
            this.lblUserID.Text = "label2";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(138, 206);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(46, 17);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "label1";
            // 
            // picLogoIcon
            // 
            this.picLogoIcon.Image = ((System.Drawing.Image)(resources.GetObject("picLogoIcon.Image")));
            this.picLogoIcon.Location = new System.Drawing.Point(28, 18);
            this.picLogoIcon.Name = "picLogoIcon";
            this.picLogoIcon.Size = new System.Drawing.Size(196, 157);
            this.picLogoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoIcon.TabIndex = 2;
            this.picLogoIcon.TabStop = false;
            // 
            // lblConstUserName
            // 
            this.lblConstUserName.AutoSize = true;
            this.lblConstUserName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConstUserName.ForeColor = System.Drawing.Color.White;
            this.lblConstUserName.Location = new System.Drawing.Point(3, 201);
            this.lblConstUserName.Name = "lblConstUserName";
            this.lblConstUserName.Size = new System.Drawing.Size(133, 22);
            this.lblConstUserName.TabIndex = 11;
            this.lblConstUserName.Text = "Kullanıcı Adı : ";
            // 
            // lblConstUserID
            // 
            this.lblConstUserID.AutoSize = true;
            this.lblConstUserID.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConstUserID.ForeColor = System.Drawing.Color.White;
            this.lblConstUserID.Location = new System.Drawing.Point(14, 233);
            this.lblConstUserID.Name = "lblConstUserID";
            this.lblConstUserID.Size = new System.Drawing.Size(121, 22);
            this.lblConstUserID.TabIndex = 13;
            this.lblConstUserID.Text = "Kullanıcı ID : ";
            // 
            // btnStartExam
            // 
            this.btnStartExam.BackColor = System.Drawing.Color.DimGray;
            this.btnStartExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartExam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartExam.ForeColor = System.Drawing.Color.White;
            this.btnStartExam.Location = new System.Drawing.Point(0, 386);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(296, 46);
            this.btnStartExam.TabIndex = 1;
            this.btnStartExam.Text = "SINAVA BAŞLA";
            this.btnStartExam.UseVisualStyleBackColor = false;
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // panelExamModul
            // 
            this.panelExamModul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExamModul.Location = new System.Drawing.Point(296, 0);
            this.panelExamModul.Name = "panelExamModul";
            this.panelExamModul.Size = new System.Drawing.Size(978, 1055);
            this.panelExamModul.TabIndex = 3;
            // 
            // StudentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 1055);
            this.Controls.Add(this.panelExamModul);
            this.Controls.Add(this.panelDashBoard);
            this.Name = "StudentScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentScreen_FormClosed);
            this.Load += new System.EventHandler(this.StudentScreen_Load);
            this.panelDashBoard.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDashBoard;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnStartExam;
        private System.Windows.Forms.Panel panelExamModul;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox picLogoIcon;
        private System.Windows.Forms.Label lblConstUserName;
        private System.Windows.Forms.Label lblConstUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSettings;
    }
}