namespace AnimalHospital
{
    partial class Form3
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPw = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.lblPwCheck = new System.Windows.Forms.Label();
            this.txtPwCheck = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "이름";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(23, 101);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(43, 15);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "아이디";
            // 
            // lblPw
            // 
            this.lblPw.AutoSize = true;
            this.lblPw.Location = new System.Drawing.Point(23, 140);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(55, 15);
            this.lblPw.TabIndex = 2;
            this.lblPw.Text = "비밀번호";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 23);
            this.txtName.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(117, 101);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(152, 23);
            this.txtId.TabIndex = 4;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(117, 137);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.Size = new System.Drawing.Size(152, 23);
            this.txtPw.TabIndex = 5;
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(290, 63);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(75, 166);
            this.btnSignup.TabIndex = 6;
            this.btnSignup.Text = "회원가입";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblPwCheck
            // 
            this.lblPwCheck.AutoSize = true;
            this.lblPwCheck.Location = new System.Drawing.Point(23, 175);
            this.lblPwCheck.Name = "lblPwCheck";
            this.lblPwCheck.Size = new System.Drawing.Size(83, 15);
            this.lblPwCheck.TabIndex = 7;
            this.lblPwCheck.Text = "비밀번호 확인";
            // 
            // txtPwCheck
            // 
            this.txtPwCheck.Location = new System.Drawing.Point(117, 172);
            this.txtPwCheck.Name = "txtPwCheck";
            this.txtPwCheck.PasswordChar = '*';
            this.txtPwCheck.Size = new System.Drawing.Size(152, 23);
            this.txtPwCheck.TabIndex = 8;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(23, 209);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(55, 15);
            this.lblCode.TabIndex = 9;
            this.lblCode.Text = "인증문자";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(117, 206);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '*';
            this.txtCode.Size = new System.Drawing.Size(152, 23);
            this.txtCode.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 269);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtPwCheck);
            this.Controls.Add(this.lblPwCheck);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPw);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblName);
            this.Name = "Form3";
            this.Text = "회원가입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblId;
        private Label lblPw;
        private TextBox txtName;
        private TextBox txtId;
        private TextBox txtPw;
        private Button btnSignup;
        private Label lblPwCheck;
        private TextBox txtPwCheck;
        private Label lblCode;
        private TextBox txtCode;
    }
}