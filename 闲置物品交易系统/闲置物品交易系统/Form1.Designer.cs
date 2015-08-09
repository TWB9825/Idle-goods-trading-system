namespace 闲置物品交易系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SignButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.signInPwdText = new System.Windows.Forms.TextBox();
            this.signInUserText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignButton
            // 
            this.SignButton.Location = new System.Drawing.Point(297, 186);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(75, 23);
            this.SignButton.TabIndex = 13;
            this.SignButton.Text = "登录";
            this.SignButton.UseVisualStyleBackColor = true;
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(197, 186);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "注册";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // signInPwdText
            // 
            this.signInPwdText.Location = new System.Drawing.Point(272, 139);
            this.signInPwdText.Name = "signInPwdText";
            this.signInPwdText.PasswordChar = '*';
            this.signInPwdText.Size = new System.Drawing.Size(100, 21);
            this.signInPwdText.TabIndex = 11;
            this.signInPwdText.TextChanged += new System.EventHandler(this.signInPwdText_TextChanged);
            this.signInPwdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.signInPwdText_KeyDown);
            // 
            // signInUserText
            // 
            this.signInUserText.Location = new System.Drawing.Point(272, 101);
            this.signInUserText.Name = "signInUserText";
            this.signInUserText.Size = new System.Drawing.Size(100, 21);
            this.signInUserText.TabIndex = 10;
            this.signInUserText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.signInUserText_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "密  码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "用户名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tiranti Solid LET", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(189, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Share Our things";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 314);
            this.Controls.Add(this.SignButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.signInPwdText);
            this.Controls.Add(this.signInUserText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox signInPwdText;
        private System.Windows.Forms.TextBox signInUserText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}

