namespace PathOfLeastResistance
{
    partial class DataGridGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRows = new System.Windows.Forms.ComboBox();
            this.comboBoxColumns = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxMinRange = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMaxRange = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDidPathMakeIt = new System.Windows.Forms.Label();
            this.labelPathTaken = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTotalResistance = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows In Grid";
            // 
            // comboBoxRows
            // 
            this.comboBoxRows.FormattingEnabled = true;
            this.comboBoxRows.Location = new System.Drawing.Point(99, 30);
            this.comboBoxRows.Name = "comboBoxRows";
            this.comboBoxRows.Size = new System.Drawing.Size(47, 21);
            this.comboBoxRows.TabIndex = 1;
            this.comboBoxRows.Text = "1";
            // 
            // comboBoxColumns
            // 
            this.comboBoxColumns.FormattingEnabled = true;
            this.comboBoxColumns.Location = new System.Drawing.Point(99, 57);
            this.comboBoxColumns.Name = "comboBoxColumns";
            this.comboBoxColumns.Size = new System.Drawing.Size(47, 21);
            this.comboBoxColumns.TabIndex = 3;
            this.comboBoxColumns.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columns In Grid";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 306);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate Grid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxMinRange
            // 
            this.comboBoxMinRange.FormattingEnabled = true;
            this.comboBoxMinRange.Location = new System.Drawing.Point(255, 30);
            this.comboBoxMinRange.Name = "comboBoxMinRange";
            this.comboBoxMinRange.Size = new System.Drawing.Size(47, 21);
            this.comboBoxMinRange.TabIndex = 7;
            this.comboBoxMinRange.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Min Number Range";
            // 
            // comboBoxMaxRange
            // 
            this.comboBoxMaxRange.FormattingEnabled = true;
            this.comboBoxMaxRange.Location = new System.Drawing.Point(255, 57);
            this.comboBoxMaxRange.Name = "comboBoxMaxRange";
            this.comboBoxMaxRange.Size = new System.Drawing.Size(47, 21);
            this.comboBoxMaxRange.TabIndex = 9;
            this.comboBoxMaxRange.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max Number Range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Did Water Make It To The Other Side? ";
            // 
            // labelDidPathMakeIt
            // 
            this.labelDidPathMakeIt.AutoSize = true;
            this.labelDidPathMakeIt.Location = new System.Drawing.Point(212, 397);
            this.labelDidPathMakeIt.Name = "labelDidPathMakeIt";
            this.labelDidPathMakeIt.Size = new System.Drawing.Size(35, 13);
            this.labelDidPathMakeIt.TabIndex = 11;
            this.labelDidPathMakeIt.Text = "label6";
            // 
            // labelPathTaken
            // 
            this.labelPathTaken.AutoSize = true;
            this.labelPathTaken.Location = new System.Drawing.Point(212, 410);
            this.labelPathTaken.Name = "labelPathTaken";
            this.labelPathTaken.Size = new System.Drawing.Size(35, 13);
            this.labelPathTaken.TabIndex = 13;
            this.labelPathTaken.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Path Taken:";
            // 
            // labelTotalResistance
            // 
            this.labelTotalResistance.AutoSize = true;
            this.labelTotalResistance.Location = new System.Drawing.Point(212, 423);
            this.labelTotalResistance.Name = "labelTotalResistance";
            this.labelTotalResistance.Size = new System.Drawing.Size(35, 13);
            this.labelTotalResistance.TabIndex = 15;
            this.labelTotalResistance.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Total Resistance:";
            // 
            // DataGridGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 507);
            this.Controls.Add(this.labelTotalResistance);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelPathTaken);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelDidPathMakeIt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMaxRange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMinRange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxColumns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRows);
            this.Controls.Add(this.label1);
            this.Name = "DataGridGenerator";
            this.Text = "Data Grid Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRows;
        private System.Windows.Forms.ComboBox comboBoxColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxMinRange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMaxRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDidPathMakeIt;
        private System.Windows.Forms.Label labelPathTaken;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTotalResistance;
        private System.Windows.Forms.Label label10;
    }
}

