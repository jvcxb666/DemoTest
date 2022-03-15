
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
            this.sort_type = new System.Windows.Forms.ComboBox();
            this.sort_column = new System.Windows.Forms.ComboBox();
            this.filter_click = new System.Windows.Forms.Button();
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
            this.seachBox.TextChanged += new System.EventHandler(this.seachBox_TextChanged);
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
            // sort_type
            // 
            this.sort_type.FormattingEnabled = true;
            this.sort_type.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.sort_type.Location = new System.Drawing.Point(253, 410);
            this.sort_type.Name = "sort_type";
            this.sort_type.Size = new System.Drawing.Size(235, 28);
            this.sort_type.TabIndex = 7;
            this.sort_type.SelectedIndexChanged += new System.EventHandler(this.sort_type_SelectedIndexChanged);
            // 
            // sort_column
            // 
            this.sort_column.FormattingEnabled = true;
            this.sort_column.Items.AddRange(new object[] {
            "company",
            "jobname",
            "email"});
            this.sort_column.Location = new System.Drawing.Point(12, 410);
            this.sort_column.Name = "sort_column";
            this.sort_column.Size = new System.Drawing.Size(235, 28);
            this.sort_column.TabIndex = 8;
            this.sort_column.SelectedIndexChanged += new System.EventHandler(this.sort_column_SelectedIndexChanged);
            // 
            // filter_click
            // 
            this.filter_click.Location = new System.Drawing.Point(494, 410);
            this.filter_click.Name = "filter_click";
            this.filter_click.Size = new System.Drawing.Size(120, 34);
            this.filter_click.TabIndex = 9;
            this.filter_click.Text = "filter";
            this.filter_click.UseVisualStyleBackColor = true;
            this.filter_click.Click += new System.EventHandler(this.filter_click_Click);
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.filter_click);
            this.Controls.Add(this.sort_column);
            this.Controls.Add(this.sort_type);
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
        private System.Windows.Forms.ComboBox sort_type;
        private System.Windows.Forms.ComboBox sort_column;
        private System.Windows.Forms.Button filter_click;
    }
}