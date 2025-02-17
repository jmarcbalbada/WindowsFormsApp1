namespace WindowsFormsApp1
{
    partial class Form1
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.excelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(305, 27);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(368, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(707, 25);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1041, 347);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(419, 447);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(125, 39);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(616, 447);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(125, 39);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(245, 447);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(125, 39);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // excelButton
            // 
            this.excelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelButton.Location = new System.Drawing.Point(924, 455);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(147, 31);
            this.excelButton.TabIndex = 6;
            this.excelButton.Text = "Export to Excel 🗎";
            this.excelButton.UseVisualStyleBackColor = true;
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 519);
            this.Controls.Add(this.excelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button excelButton;
    }
}