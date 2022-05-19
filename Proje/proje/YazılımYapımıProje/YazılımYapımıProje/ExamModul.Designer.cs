
namespace YazılımYapımıProje
{
    partial class ExamModul
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamModul));
            this.panelOptions = new System.Windows.Forms.Panel();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblStick = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblQuestionInfo = new System.Windows.Forms.Label();
            this.picBearDefault = new System.Windows.Forms.PictureBox();
            this.picBearFalse = new System.Windows.Forms.PictureBox();
            this.picBearTrue = new System.Windows.Forms.PictureBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imgExamQuestions = new System.Windows.Forms.PictureBox();
            this.ExamTimer = new System.Windows.Forms.Timer(this.components);
            this.rdBtnD = new OBYOrderManagementSystem.RadioSettings.RJRadioButton();
            this.rdBtnC = new OBYOrderManagementSystem.RadioSettings.RJRadioButton();
            this.rdBtnB = new OBYOrderManagementSystem.RadioSettings.RJRadioButton();
            this.rdBtnA = new OBYOrderManagementSystem.RadioSettings.RJRadioButton();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBearDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBearFalse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBearTrue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExamQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.White;
            this.panelOptions.Controls.Add(this.lblSecond);
            this.panelOptions.Controls.Add(this.lblStick);
            this.panelOptions.Controls.Add(this.lblMinute);
            this.panelOptions.Controls.Add(this.lblQuestionInfo);
            this.panelOptions.Controls.Add(this.picBearDefault);
            this.panelOptions.Controls.Add(this.picBearFalse);
            this.panelOptions.Controls.Add(this.rdBtnD);
            this.panelOptions.Controls.Add(this.picBearTrue);
            this.panelOptions.Controls.Add(this.rdBtnC);
            this.panelOptions.Controls.Add(this.rdBtnB);
            this.panelOptions.Controls.Add(this.rdBtnA);
            this.panelOptions.Controls.Add(this.btnNextQuestion);
            this.panelOptions.Controls.Add(this.button1);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOptions.Location = new System.Drawing.Point(0, 911);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(1024, 144);
            this.panelOptions.TabIndex = 4;
            this.panelOptions.Visible = false;
            // 
            // lblSecond
            // 
            this.lblSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecond.Location = new System.Drawing.Point(984, 100);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(20, 18);
            this.lblSecond.TabIndex = 113;
            this.lblSecond.Text = "--";
            // 
            // lblStick
            // 
            this.lblStick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStick.AutoSize = true;
            this.lblStick.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblStick.Location = new System.Drawing.Point(974, 99);
            this.lblStick.Name = "lblStick";
            this.lblStick.Size = new System.Drawing.Size(12, 18);
            this.lblStick.TabIndex = 112;
            this.lblStick.Text = ":";
            // 
            // lblMinute
            // 
            this.lblMinute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblMinute.Location = new System.Drawing.Point(951, 100);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(20, 18);
            this.lblMinute.TabIndex = 111;
            this.lblMinute.Text = "--";
            // 
            // lblQuestionInfo
            // 
            this.lblQuestionInfo.AutoSize = true;
            this.lblQuestionInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuestionInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lblQuestionInfo.Location = new System.Drawing.Point(34, 100);
            this.lblQuestionInfo.Name = "lblQuestionInfo";
            this.lblQuestionInfo.Size = new System.Drawing.Size(0, 18);
            this.lblQuestionInfo.TabIndex = 104;
            // 
            // picBearDefault
            // 
            this.picBearDefault.Image = ((System.Drawing.Image)(resources.GetObject("picBearDefault.Image")));
            this.picBearDefault.Location = new System.Drawing.Point(42, 59);
            this.picBearDefault.Name = "picBearDefault";
            this.picBearDefault.Size = new System.Drawing.Size(30, 30);
            this.picBearDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBearDefault.TabIndex = 97;
            this.picBearDefault.TabStop = false;
            // 
            // picBearFalse
            // 
            this.picBearFalse.Image = ((System.Drawing.Image)(resources.GetObject("picBearFalse.Image")));
            this.picBearFalse.Location = new System.Drawing.Point(42, 59);
            this.picBearFalse.Name = "picBearFalse";
            this.picBearFalse.Size = new System.Drawing.Size(30, 30);
            this.picBearFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBearFalse.TabIndex = 98;
            this.picBearFalse.TabStop = false;
            // 
            // picBearTrue
            // 
            this.picBearTrue.Image = ((System.Drawing.Image)(resources.GetObject("picBearTrue.Image")));
            this.picBearTrue.Location = new System.Drawing.Point(42, 59);
            this.picBearTrue.Name = "picBearTrue";
            this.picBearTrue.Size = new System.Drawing.Size(30, 30);
            this.picBearTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBearTrue.TabIndex = 99;
            this.picBearTrue.TabStop = false;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNextQuestion.FlatAppearance.BorderSize = 0;
            this.btnNextQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQuestion.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnNextQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnNextQuestion.Image")));
            this.btnNextQuestion.Location = new System.Drawing.Point(740, 38);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(98, 51);
            this.btnNextQuestion.TabIndex = 91;
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            this.btnNextQuestion.MouseLeave += new System.EventHandler(this.btnNextQuestion_MouseLeave);
            this.btnNextQuestion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNextQuestion_MouseMove);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(740, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 51);
            this.button1.TabIndex = 92;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imgExamQuestions
            // 
            this.imgExamQuestions.BackColor = System.Drawing.Color.White;
            this.imgExamQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgExamQuestions.Image = ((System.Drawing.Image)(resources.GetObject("imgExamQuestions.Image")));
            this.imgExamQuestions.Location = new System.Drawing.Point(0, 0);
            this.imgExamQuestions.Name = "imgExamQuestions";
            this.imgExamQuestions.Size = new System.Drawing.Size(1024, 911);
            this.imgExamQuestions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgExamQuestions.TabIndex = 5;
            this.imgExamQuestions.TabStop = false;
            // 
            // ExamTimer
            // 
            this.ExamTimer.Tick += new System.EventHandler(this.ExamTimer_Tick);
            // 
            // rdBtnD
            // 
            this.rdBtnD.AutoSize = true;
            this.rdBtnD.CheckedColor = System.Drawing.SystemColors.ControlText;
            this.rdBtnD.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.rdBtnD.Location = new System.Drawing.Point(617, 49);
            this.rdBtnD.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdBtnD.Name = "rdBtnD";
            this.rdBtnD.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdBtnD.Size = new System.Drawing.Size(57, 32);
            this.rdBtnD.TabIndex = 89;
            this.rdBtnD.TabStop = true;
            this.rdBtnD.Text = "D";
            this.rdBtnD.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdBtnD.UseVisualStyleBackColor = true;
            // 
            // rdBtnC
            // 
            this.rdBtnC.AutoSize = true;
            this.rdBtnC.CheckedColor = System.Drawing.SystemColors.ControlText;
            this.rdBtnC.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.rdBtnC.Location = new System.Drawing.Point(512, 49);
            this.rdBtnC.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdBtnC.Name = "rdBtnC";
            this.rdBtnC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdBtnC.Size = new System.Drawing.Size(55, 32);
            this.rdBtnC.TabIndex = 88;
            this.rdBtnC.TabStop = true;
            this.rdBtnC.Text = "C";
            this.rdBtnC.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdBtnC.UseVisualStyleBackColor = true;
            // 
            // rdBtnB
            // 
            this.rdBtnB.AutoSize = true;
            this.rdBtnB.CheckedColor = System.Drawing.SystemColors.ControlText;
            this.rdBtnB.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.rdBtnB.Location = new System.Drawing.Point(404, 49);
            this.rdBtnB.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdBtnB.Name = "rdBtnB";
            this.rdBtnB.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdBtnB.Size = new System.Drawing.Size(56, 32);
            this.rdBtnB.TabIndex = 87;
            this.rdBtnB.TabStop = true;
            this.rdBtnB.Text = "B";
            this.rdBtnB.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdBtnB.UseVisualStyleBackColor = true;
            // 
            // rdBtnA
            // 
            this.rdBtnA.AutoSize = true;
            this.rdBtnA.CheckedColor = System.Drawing.SystemColors.ControlText;
            this.rdBtnA.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.rdBtnA.Location = new System.Drawing.Point(282, 49);
            this.rdBtnA.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdBtnA.Name = "rdBtnA";
            this.rdBtnA.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdBtnA.Size = new System.Drawing.Size(57, 32);
            this.rdBtnA.TabIndex = 86;
            this.rdBtnA.TabStop = true;
            this.rdBtnA.Text = "A";
            this.rdBtnA.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdBtnA.UseVisualStyleBackColor = true;
            // 
            // ExamModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 1055);
            this.Controls.Add(this.imgExamQuestions);
            this.Controls.Add(this.panelOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamModul";
            this.Text = "ExamModul";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExamModul_FormClosed);
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBearDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBearFalse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBearTrue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExamQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblStick;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblQuestionInfo;
        private System.Windows.Forms.PictureBox picBearDefault;
        private System.Windows.Forms.PictureBox picBearFalse;
        private OBYOrderManagementSystem.RadioSettings.RJRadioButton rdBtnD;
        private System.Windows.Forms.PictureBox picBearTrue;
        private OBYOrderManagementSystem.RadioSettings.RJRadioButton rdBtnC;
        private OBYOrderManagementSystem.RadioSettings.RJRadioButton rdBtnB;
        private OBYOrderManagementSystem.RadioSettings.RJRadioButton rdBtnA;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imgExamQuestions;
        private System.Windows.Forms.Timer ExamTimer;
    }
}