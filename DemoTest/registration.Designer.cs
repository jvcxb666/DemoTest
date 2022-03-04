
namespace DemoTest
{
    partial class registration
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
            this.Back_button = new System.Windows.Forms.Button();
            this.Register_submit = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(716, 405);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(83, 36);
            this.Back_button.TabIndex = 0;
            this.Back_button.Text = "back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Register_submit
            // 
            this.Register_submit.Location = new System.Drawing.Point(264, 228);
            this.Register_submit.Name = "Register_submit";
            this.Register_submit.Size = new System.Drawing.Size(300, 50);
            this.Register_submit.TabIndex = 7;
            this.Register_submit.Text = "Register";
            this.Register_submit.UseVisualStyleBackColor = true;
            this.Register_submit.Click += new System.EventHandler(this.Register_submit_Click);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(264, 196);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(300, 26);
            this.PassBox.TabIndex = 6;
            this.PassBox.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(290, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registration";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(264, 164);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(300, 26);
            this.EmailBox.TabIndex = 4;
            this.EmailBox.Text = "Email";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(264, 132);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(300, 26);
            this.NameBox.TabIndex = 8;
            this.NameBox.Text = "Name";
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Register_submit);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.Back_button);
            this.Name = "registration";
            this.Text = "registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Register_submit;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox NameBox;
    }
}