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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.modelID = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.GetNext = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LoadImg = new System.Windows.Forms.Button();
            this.SendImg2Sql = new System.Windows.Forms.Button();
            this.hasImg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(354, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "pwd";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(24, 349);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(519, 55);
            this.dataGrid.TabIndex = 4;
            // 
            // imgBox
            // 
            this.imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBox.Cursor = System.Windows.Forms.Cursors.No;
            this.imgBox.Location = new System.Drawing.Point(38, 107);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(203, 205);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox.TabIndex = 5;
            this.imgBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(106, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(35, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Spec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(285, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(361, 119);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(144, 22);
            this.id.TabIndex = 9;
            // 
            // modelID
            // 
            this.modelID.Location = new System.Drawing.Point(361, 177);
            this.modelID.Name = "modelID";
            this.modelID.Size = new System.Drawing.Size(144, 22);
            this.modelID.TabIndex = 10;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(361, 234);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(144, 22);
            this.gender.TabIndex = 11;
            // 
            // GetNext
            // 
            this.GetNext.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GetNext.Location = new System.Drawing.Point(306, 422);
            this.GetNext.Name = "GetNext";
            this.GetNext.Size = new System.Drawing.Size(185, 59);
            this.GetNext.TabIndex = 12;
            this.GetNext.Text = "GetNext";
            this.GetNext.UseVisualStyleBackColor = true;
            this.GetNext.Click += new System.EventHandler(this.GetNext_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(285, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Model ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(285, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gender";
            // 
            // LoadImg
            // 
            this.LoadImg.Location = new System.Drawing.Point(24, 434);
            this.LoadImg.Name = "LoadImg";
            this.LoadImg.Size = new System.Drawing.Size(105, 40);
            this.LoadImg.TabIndex = 15;
            this.LoadImg.Text = "LoadImg";
            this.LoadImg.UseVisualStyleBackColor = true;
            this.LoadImg.Click += new System.EventHandler(this.LoadImg_Click);
            // 
            // SendImg2Sql
            // 
            this.SendImg2Sql.Location = new System.Drawing.Point(151, 434);
            this.SendImg2Sql.Name = "SendImg2Sql";
            this.SendImg2Sql.Size = new System.Drawing.Size(107, 40);
            this.SendImg2Sql.TabIndex = 16;
            this.SendImg2Sql.Text = "SendImg2SQL";
            this.SendImg2Sql.UseVisualStyleBackColor = true;
            this.SendImg2Sql.Click += new System.EventHandler(this.SendImg2Sql_Click);
            // 
            // hasImg
            // 
            this.hasImg.Location = new System.Drawing.Point(361, 286);
            this.hasImg.Name = "hasImg";
            this.hasImg.Size = new System.Drawing.Size(144, 22);
            this.hasImg.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(285, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "HasImg";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 519);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hasImg);
            this.Controls.Add(this.SendImg2Sql);
            this.Controls.Add(this.LoadImg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GetNext);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.modelID);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox modelID;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.Button GetNext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LoadImg;
        private System.Windows.Forms.Button SendImg2Sql;
        private System.Windows.Forms.TextBox hasImg;
        private System.Windows.Forms.Label label8;
    }
}