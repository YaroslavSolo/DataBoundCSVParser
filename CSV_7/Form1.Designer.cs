namespace CSV_7
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ToolMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfRows = new System.Windows.Forms.NumericUpDown();
            this.SelectFilter = new System.Windows.Forms.ComboBox();
            this.SelectSort = new System.Windows.Forms.ComboBox();
            this.AppendFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericXCoord = new System.Windows.Forms.NumericUpDown();
            this.NumericYCoord = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FilterKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.ToolMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericXCoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYCoord)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.ColumnHeadersHeight = 27;
            this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DataGridView.Location = new System.Drawing.Point(0, 126);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 50;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(1006, 337);
            this.DataGridView.TabIndex = 0;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "csv";
            // 
            // ToolMenu
            // 
            this.ToolMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ToolMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.infoToolStripMenuItem});
            this.ToolMenu.Location = new System.Drawing.Point(0, 0);
            this.ToolMenu.Name = "ToolMenu";
            this.ToolMenu.Size = new System.Drawing.Size(1006, 28);
            this.ToolMenu.TabIndex = 1;
            this.ToolMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.dfToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.appendToToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // dfToolStripMenuItem
            // 
            this.dfToolStripMenuItem.Name = "dfToolStripMenuItem";
            this.dfToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.dfToolStripMenuItem.Text = "Save";
            this.dfToolStripMenuItem.Click += new System.EventHandler(this.dfToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // appendToToolStripMenuItem
            // 
            this.appendToToolStripMenuItem.Name = "appendToToolStripMenuItem";
            this.appendToToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.appendToToolStripMenuItem.Text = "Append to";
            this.appendToToolStripMenuItem.Click += new System.EventHandler(this.appendToToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.infoToolStripMenuItem.Text = "About";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.FilterKey);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NumericYCoord);
            this.panel1.Controls.Add(this.NumericXCoord);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NumberOfRows);
            this.panel1.Controls.Add(this.SelectFilter);
            this.panel1.Controls.Add(this.SelectSort);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 98);
            this.panel1.TabIndex = 2;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(594, 18);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(96, 54);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter by:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order by:";
            // 
            // NumberOfRows
            // 
            this.NumberOfRows.Location = new System.Drawing.Point(130, 18);
            this.NumberOfRows.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumberOfRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfRows.Name = "NumberOfRows";
            this.NumberOfRows.Size = new System.Drawing.Size(100, 22);
            this.NumberOfRows.TabIndex = 2;
            this.NumberOfRows.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumberOfRows.ValueChanged += new System.EventHandler(this.NumberOfRows_ValueChanged);
            // 
            // SelectFilter
            // 
            this.SelectFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectFilter.FormattingEnabled = true;
            this.SelectFilter.Location = new System.Drawing.Point(380, 49);
            this.SelectFilter.Name = "SelectFilter";
            this.SelectFilter.Size = new System.Drawing.Size(121, 24);
            this.SelectFilter.TabIndex = 1;
            this.SelectFilter.SelectedIndexChanged += new System.EventHandler(this.SelectFilter_SelectedIndexChanged);
            // 
            // SelectSort
            // 
            this.SelectSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectSort.FormattingEnabled = true;
            this.SelectSort.Location = new System.Drawing.Point(380, 17);
            this.SelectSort.Name = "SelectSort";
            this.SelectSort.Size = new System.Drawing.Size(121, 24);
            this.SelectSort.TabIndex = 0;
            this.SelectSort.SelectedIndexChanged += new System.EventHandler(this.SelectSort_SelectedIndexChanged);
            // 
            // AppendFileDialog
            // 
            this.AppendFileDialog.OverwritePrompt = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rows showed:";
            // 
            // NumericXCoord
            // 
            this.NumericXCoord.DecimalPlaces = 5;
            this.NumericXCoord.Location = new System.Drawing.Point(799, 19);
            this.NumericXCoord.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericXCoord.Name = "NumericXCoord";
            this.NumericXCoord.Size = new System.Drawing.Size(115, 22);
            this.NumericXCoord.TabIndex = 8;
            // 
            // NumericYCoord
            // 
            this.NumericYCoord.DecimalPlaces = 5;
            this.NumericYCoord.Location = new System.Drawing.Point(799, 51);
            this.NumericYCoord.Name = "NumericYCoord";
            this.NumericYCoord.Size = new System.Drawing.Size(115, 22);
            this.NumericYCoord.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(772, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y:";
            // 
            // FilterKey
            // 
            this.FilterKey.Location = new System.Drawing.Point(130, 50);
            this.FilterKey.Name = "FilterKey";
            this.FilterKey.Size = new System.Drawing.Size(100, 22);
            this.FilterKey.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Filter key:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.ToolMenu);
            this.MinimumSize = new System.Drawing.Size(1024, 512);
            this.Name = "Form1";
            this.Text = "DataBoundCSV";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ToolMenu.ResumeLayout(false);
            this.ToolMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericXCoord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYCoord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.MenuStrip ToolMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appendToToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox SelectFilter;
        private System.Windows.Forms.ComboBox SelectSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumberOfRows;
        private System.Windows.Forms.SaveFileDialog AppendFileDialog;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumericYCoord;
        private System.Windows.Forms.NumericUpDown NumericXCoord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FilterKey;
    }
}

