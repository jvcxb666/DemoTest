
namespace DemoTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.Login_submit = new System.Windows.Forms.Button();
            this.Reg_redirect = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(257, 134);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(300, 26);
            this.EmailBox.TabIndex = 0;
            this.EmailBox.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(277, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Authorization";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(257, 166);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(300, 26);
            this.PassBox.TabIndex = 2;
            this.PassBox.Text = "Password";
            // 
            // Login_submit
            // 
            this.Login_submit.Location = new System.Drawing.Point(257, 198);
            this.Login_submit.Name = "Login_submit";
            this.Login_submit.Size = new System.Drawing.Size(300, 50);
            this.Login_submit.TabIndex = 3;
            this.Login_submit.Text = "Login";
            this.Login_submit.UseVisualStyleBackColor = true;
            this.Login_submit.Click += new System.EventHandler(this.Login_submit_Click);
            // 
            // Reg_redirect
            // 
            this.Reg_redirect.Location = new System.Drawing.Point(257, 254);
            this.Reg_redirect.Name = "Reg_redirect";
            this.Reg_redirect.Size = new System.Drawing.Size(300, 50);
            this.Reg_redirect.TabIndex = 4;
            this.Reg_redirect.Text = "Registration";
            this.Reg_redirect.UseVisualStyleBackColor = true;
            this.Reg_redirect.Click += new System.EventHandler(this.Reg_redirect_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(713, 399);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 39);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.Reg_redirect);
            this.Controls.Add(this.Login_submit);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailBox);
            this.Name = "Form1";
            this.Text = "index";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button Login_submit;
        private System.Windows.Forms.Button Reg_redirect;
        private System.Windows.Forms.Button exit_button;
    }
}

