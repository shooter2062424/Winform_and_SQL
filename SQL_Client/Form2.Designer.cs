namespace SQL_Client
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ShowBox = new System.Windows.Forms.TextBox();
            this.FetchData = new System.Windows.Forms.Button();
            this.Add10Data = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(399, 22);
            this.textBox2.TabIndex = 1;
            // 
            // ShowBox
            // 
            this.ShowBox.Location = new System.Drawing.Point(140, 234);
            this.ShowBox.Multiline = true;
            this.ShowBox.Name = "ShowBox";
            this.ShowBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowBox.Size = new System.Drawing.Size(399, 156);
            this.ShowBox.TabIndex = 2;
            // 
            // FetchData
            // 
            this.FetchData.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FetchData.Location = new System.Drawing.Point(327, 417);
            this.FetchData.Name = "FetchData";
            this.FetchData.Size = new System.Drawing.Size(169, 60);
            this.FetchData.TabIndex = 3;
            this.FetchData.Text = "GetData";
            this.FetchData.UseVisualStyleBackColor = true;
            this.FetchData.Click += new System.EventHandler(this.FetchData_Click);
            // 
            // Add10Data
            // 
            this.Add10Data.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Add10Data.Location = new System.Drawing.Point(95, 417);
            this.Add10Data.Name = "Add10Data";
            this.Add10Data.Size = new System.Drawing.Size(169, 60);
            this.Add10Data.TabIndex = 4;
            this.Add10Data.Text = "Add10Data";
            this.Add10Data.UseVisualStyleBackColor = true;
            this.Add10Data.Click += new System.EventHandler(this.Add10Data_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 519);
            this.Controls.Add(this.Add10Data);
            this.Controls.Add(this.FetchData);
            this.Controls.Add(this.ShowBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ShowBox;
        private System.Windows.Forms.Button FetchData;
        private System.Windows.Forms.Button Add10Data;
    }
}