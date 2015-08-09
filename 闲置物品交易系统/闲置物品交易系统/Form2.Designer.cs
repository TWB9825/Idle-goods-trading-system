namespace 闲置物品交易系统
{
    partial class Form2
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
            this.registerCancelButton = new System.Windows.Forms.Button();
            this.registerConfimButton = new System.Windows.Forms.Button();
            this.registerClearButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.registerPwdAgainText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.registerPwdText = new System.Windows.Forms.TextBox();
            this.registerEmailText = new System.Windows.Forms.TextBox();
            this.registerPhoneText = new System.Windows.Forms.TextBox();
            this.registerSchoolText = new System.Windows.Forms.TextBox();
            this.registerUserText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerCancelButton
            // 
            this.registerCancelButton.Location = new System.Drawing.Point(373, 244);
            this.registerCancelButton.Name = "registerCancelButton";
            this.registerCancelButton.Size = new System.Drawing.Size(75, 23);
            this.registerCancelButton.TabIndex = 29;
            this.registerCancelButton.Text = "取消";
            this.registerCancelButton.UseVisualStyleBackColor = true;
            this.registerCancelButton.Click += new System.EventHandler(this.registerCancelButton_Click);
            // 
            // registerConfimButton
            // 
            this.registerConfimButton.Location = new System.Drawing.Point(276, 244);
            this.registerConfimButton.Name = "registerConfimButton";
            this.registerConfimButton.Size = new System.Drawing.Size(75, 23);
            this.registerConfimButton.TabIndex = 28;
            this.registerConfimButton.Text = "确定";
            this.registerConfimButton.UseVisualStyleBackColor = true;
            this.registerConfimButton.Click += new System.EventHandler(this.registerConfimButton_Click);
            // 
            // registerClearButton
            // 
            this.registerClearButton.Location = new System.Drawing.Point(174, 244);
            this.registerClearButton.Name = "registerClearButton";
            this.registerClearButton.Size = new System.Drawing.Size(75, 23);
            this.registerClearButton.TabIndex = 27;
            this.registerClearButton.Text = "清空";
            this.registerClearButton.UseVisualStyleBackColor = true;
            this.registerClearButton.Click += new System.EventHandler(this.registerClearButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "再次输入*";
            // 
            // registerPwdAgainText
            // 
            this.registerPwdAgainText.Location = new System.Drawing.Point(262, 198);
            this.registerPwdAgainText.Name = "registerPwdAgainText";
            this.registerPwdAgainText.PasswordChar = '*';
            this.registerPwdAgainText.Size = new System.Drawing.Size(100, 21);
            this.registerPwdAgainText.TabIndex = 25;
            this.registerPwdAgainText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.registerPwdAgainText_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "密  码*";
            // 
            // registerPwdText
            // 
            this.registerPwdText.Location = new System.Drawing.Point(262, 160);
            this.registerPwdText.Name = "registerPwdText";
            this.registerPwdText.PasswordChar = '*';
            this.registerPwdText.Size = new System.Drawing.Size(100, 21);
            this.registerPwdText.TabIndex = 23;
            this.registerPwdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.registerPwdText_KeyDown);
            // 
            // registerEmailText
            // 
            this.registerEmailText.Location = new System.Drawing.Point(262, 127);
            this.registerEmailText.Name = "registerEmailText";
            this.registerEmailText.Size = new System.Drawing.Size(100, 21);
            this.registerEmailText.TabIndex = 22;
            this.registerEmailText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.registerEmailText_KeyDown);
            // 
            // registerPhoneText
            // 
            this.registerPhoneText.Location = new System.Drawing.Point(262, 89);
            this.registerPhoneText.Name = "registerPhoneText";
            this.registerPhoneText.Size = new System.Drawing.Size(100, 21);
            this.registerPhoneText.TabIndex = 21;
            this.registerPhoneText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.registerPhoneText_KeyDown);
            // 
            // registerSchoolText
            // 
            this.registerSchoolText.Location = new System.Drawing.Point(262, 53);
            this.registerSchoolText.Name = "registerSchoolText";
            this.registerSchoolText.Size = new System.Drawing.Size(100, 21);
            this.registerSchoolText.TabIndex = 20;
            this.registerSchoolText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.registerSchoolText_KeyDown);
            // 
            // registerUserText
            // 
            this.registerUserText.Location = new System.Drawing.Point(262, 18);
            this.registerUserText.Name = "registerUserText";
            this.registerUserText.Size = new System.Drawing.Size(100, 21);
            this.registerUserText.TabIndex = 19;
            this.registerUserText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.registerUserText_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "邮  箱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "电  话*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "学  校*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "用户名*";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 314);
            this.Controls.Add(this.registerCancelButton);
            this.Controls.Add(this.registerConfimButton);
            this.Controls.Add(this.registerClearButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.registerPwdAgainText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registerPwdText);
            this.Controls.Add(this.registerEmailText);
            this.Controls.Add(this.registerPhoneText);
            this.Controls.Add(this.registerSchoolText);
            this.Controls.Add(this.registerUserText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerCancelButton;
        private System.Windows.Forms.Button registerConfimButton;
        private System.Windows.Forms.Button registerClearButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox registerPwdAgainText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox registerPwdText;
        private System.Windows.Forms.TextBox registerEmailText;
        private System.Windows.Forms.TextBox registerPhoneText;
        private System.Windows.Forms.TextBox registerSchoolText;
        private System.Windows.Forms.TextBox registerUserText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}