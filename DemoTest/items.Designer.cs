
namespace DemoTest
{
    partial class items
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
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.seachBox = new System.Windows.Forms.TextBox();
            this.search_submit = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.sort_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.order_job = new System.Windows.Forms.Button();
            this.order_email = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(12, 63);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 62;
            this.datagrid.RowTemplate.Height = 28;
            this.datagrid.Size = new System.Drawing.Size(954, 335);
            this.datagrid.TabIndex = 0;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellContentClick);
            // 
            // seachBox
            // 
            this.seachBox.Location = new System.Drawing.Point(12, 21);
            this.seachBox.Name = "seachBox";
            this.seachBox.Size = new System.Drawing.Size(300, 26);
            this.seachBox.TabIndex = 1;
            this.seachBox.Text = "search by company";
            // 
            // search_submit
            // 
            this.search_submit.Location = new System.Drawing.Point(318, 12);
            this.search_submit.Name = "search_submit";
            this.search_submit.Size = new System.Drawing.Size(131, 45);
            this.search_submit.TabIndex = 2;
            this.search_submit.Text = "search";
            this.search_submit.UseVisualStyleBackColor = true;
            this.search_submit.Click += new System.EventHandler(this.search_submit_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(455, 12);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(131, 45);
            this.reset_button.TabIndex = 3;
            this.reset_button.Text = "reset filters";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(835, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(131, 45);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "back";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // sort_submit
            // 
            this.sort_submit.Location = new System.Drawing.Point(188, 404);
            this.sort_submit.Name = "sort_submit";
            this.sort_submit.Size = new System.Drawing.Size(131, 45);
            this.sort_submit.TabIndex = 9;
            this.sort_submit.Text = "company";
            this.sort_submit.UseVisualStyleBackColor = true;
            this.sort_submit.Click += new System.EventHandler(this.sort_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "ORDER BY";
            // 
            // order_job
            // 
            this.order_job.Location = new System.Drawing.Point(325, 404);
            this.order_job.Name = "order_job";
            this.order_job.Size = new System.Drawing.Size(131, 45);
            this.order_job.TabIndex = 11;
            this.order_job.Text = "jobname";
            this.order_job.UseVisualStyleBackColor = true;
            this.order_job.Click += new System.EventHandler(this.order_job_Click);
            // 
            // order_email
            // 
            this.order_email.Location = new System.Drawing.Point(462, 404);
            this.order_email.Name = "order_email";
            this.order_email.Size = new System.Drawing.Size(131, 45);
            this.order_email.TabIndex = 12;
            this.order_email.Text = "email";
            this.order_email.UseVisualStyleBackColor = true;
            this.order_email.Click += new System.EventHandler(this.order_email_Click);
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.order_email);
            this.Controls.Add(this.order_job);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sort_submit);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.search_submit);
            this.Controls.Add(this.seachBox);
            this.Controls.Add(this.datagrid);
            this.Name = "items";
            this.Text = "items";
            this.Load += new System.EventHandler(this.items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.TextBox seachBox;
        private System.Windows.Forms.Button search_submit;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button sort_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button order_job;
        private System.Windows.Forms.Button order_email;
    }
}