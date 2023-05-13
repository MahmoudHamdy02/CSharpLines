﻿namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.linesView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.colorButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.findIntersectionsButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstXBox = new System.Windows.Forms.TextBox();
            this.firstYBox = new System.Windows.Forms.TextBox();
            this.secondXBox = new System.Windows.Forms.TextBox();
            this.secondYBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colFirstX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecondX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecondY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.linesView);
            this.splitContainer1.Panel1.Click += new System.EventHandler(this.splitContainer1_Panel1_Click);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1158, 577);
            this.splitContainer1.SplitterDistance = 731;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // linesView
            // 
            this.linesView.HideSelection = false;
            this.linesView.Location = new System.Drawing.Point(601, 270);
            this.linesView.Name = "linesView";
            this.linesView.Size = new System.Drawing.Size(121, 97);
            this.linesView.TabIndex = 0;
            this.linesView.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.colorButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.updateButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.removeButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.findIntersectionsButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.firstXBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.firstYBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.secondXBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.secondYBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 573);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // colorButton
            // 
            this.colorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorButton.Location = new System.Drawing.Point(3, 92);
            this.colorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(78, 41);
            this.colorButton.TabIndex = 1;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateButton.Location = new System.Drawing.Point(87, 92);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(78, 41);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Location = new System.Drawing.Point(171, 92);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(78, 41);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // findIntersectionsButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.findIntersectionsButton, 2);
            this.findIntersectionsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findIntersectionsButton.Location = new System.Drawing.Point(255, 92);
            this.findIntersectionsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findIntersectionsButton.Name = "findIntersectionsButton";
            this.findIntersectionsButton.Size = new System.Drawing.Size(162, 41);
            this.findIntersectionsButton.TabIndex = 3;
            this.findIntersectionsButton.Text = "Find Intersections";
            this.findIntersectionsButton.UseVisualStyleBackColor = true;
            this.findIntersectionsButton.Click += new System.EventHandler(this.findIntersectionsButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(339, 2);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.tableLayoutPanel1.SetRowSpan(this.addButton, 2);
            this.addButton.Size = new System.Drawing.Size(78, 86);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "First X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Second X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Second Y";
            // 
            // firstXBox
            // 
            this.firstXBox.Location = new System.Drawing.Point(87, 2);
            this.firstXBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstXBox.Name = "firstXBox";
            this.firstXBox.Size = new System.Drawing.Size(75, 24);
            this.firstXBox.TabIndex = 10;
            this.firstXBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // firstYBox
            // 
            this.firstYBox.Location = new System.Drawing.Point(87, 47);
            this.firstYBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstYBox.Name = "firstYBox";
            this.firstYBox.Size = new System.Drawing.Size(75, 24);
            this.firstYBox.TabIndex = 10;
            // 
            // secondXBox
            // 
            this.secondXBox.Location = new System.Drawing.Point(255, 2);
            this.secondXBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondXBox.Name = "secondXBox";
            this.secondXBox.Size = new System.Drawing.Size(75, 24);
            this.secondXBox.TabIndex = 10;
            // 
            // secondYBox
            // 
            this.secondYBox.Location = new System.Drawing.Point(255, 47);
            this.secondYBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondYBox.Name = "secondYBox";
            this.secondYBox.Size = new System.Drawing.Size(75, 24);
            this.secondYBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Y";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirstX,
            this.colFirstY,
            this.colSecondX,
            this.colSecondY,
            this.colColor});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 5);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(414, 432);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // colFirstX
            // 
            this.colFirstX.HeaderText = "FirstX";
            this.colFirstX.MinimumWidth = 6;
            this.colFirstX.Name = "colFirstX";
            // 
            // colFirstY
            // 
            this.colFirstY.HeaderText = "FirstY";
            this.colFirstY.MinimumWidth = 6;
            this.colFirstY.Name = "colFirstY";
            // 
            // colSecondX
            // 
            this.colSecondX.HeaderText = "SecondX";
            this.colSecondX.MinimumWidth = 6;
            this.colSecondX.Name = "colSecondX";
            // 
            // colSecondY
            // 
            this.colSecondY.HeaderText = "SecondY";
            this.colSecondY.MinimumWidth = 6;
            this.colSecondY.Name = "colSecondY";
            // 
            // colColor
            // 
            this.colColor.HeaderText = "Color";
            this.colColor.MinimumWidth = 6;
            this.colColor.Name = "colColor";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1158, 577);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button findIntersectionsButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstXBox;
        private System.Windows.Forms.TextBox firstYBox;
        private System.Windows.Forms.TextBox secondXBox;
        private System.Windows.Forms.TextBox secondYBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView linesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecondX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecondY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
    }
}
