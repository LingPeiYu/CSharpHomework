namespace CShwWeek8
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonForSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderData = new System.Windows.Forms.DataGridView();
            this.buttonForExport = new System.Windows.Forms.Button();
            this.buttonForImport = new System.Windows.Forms.Button();
            this.buttonOfSort = new System.Windows.Forms.Button();
            this.textBoxForSearch = new System.Windows.Forms.TextBox();
            this.comboBoxForSort = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonForQuery = new System.Windows.Forms.Button();
            this.textBoxForQuery = new System.Windows.Forms.TextBox();
            this.comboBoxForQuery = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonForRemove = new System.Windows.Forms.Button();
            this.buttonForAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonForSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OrderData);
            this.panel1.Controls.Add(this.buttonForExport);
            this.panel1.Controls.Add(this.buttonForImport);
            this.panel1.Controls.Add(this.buttonOfSort);
            this.panel1.Controls.Add(this.textBoxForSearch);
            this.panel1.Controls.Add(this.comboBoxForSort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 595);
            this.panel1.TabIndex = 0;
            // 
            // buttonForSearch
            // 
            this.buttonForSearch.Location = new System.Drawing.Point(15, 185);
            this.buttonForSearch.Name = "buttonForSearch";
            this.buttonForSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonForSearch.TabIndex = 7;
            this.buttonForSearch.Text = "Search";
            this.buttonForSearch.UseVisualStyleBackColor = true;
            this.buttonForSearch.Click += new System.EventHandler(this.buttonForSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // OrderData
            // 
            this.OrderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderData.Location = new System.Drawing.Point(212, 44);
            this.OrderData.Name = "OrderData";
            this.OrderData.RowTemplate.Height = 27;
            this.OrderData.Size = new System.Drawing.Size(795, 491);
            this.OrderData.TabIndex = 5;
            // 
            // buttonForExport
            // 
            this.buttonForExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForExport.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonForExport.Location = new System.Drawing.Point(44, 500);
            this.buttonForExport.Name = "buttonForExport";
            this.buttonForExport.Size = new System.Drawing.Size(117, 49);
            this.buttonForExport.TabIndex = 4;
            this.buttonForExport.Text = "Export";
            this.buttonForExport.UseVisualStyleBackColor = true;
            this.buttonForExport.Click += new System.EventHandler(this.buttonForExport_Click);
            // 
            // buttonForImport
            // 
            this.buttonForImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForImport.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonForImport.Location = new System.Drawing.Point(44, 445);
            this.buttonForImport.Name = "buttonForImport";
            this.buttonForImport.Size = new System.Drawing.Size(117, 49);
            this.buttonForImport.TabIndex = 3;
            this.buttonForImport.Text = "Import";
            this.buttonForImport.UseVisualStyleBackColor = true;
            this.buttonForImport.Click += new System.EventHandler(this.buttonForImport_Click);
            // 
            // buttonOfSort
            // 
            this.buttonOfSort.Location = new System.Drawing.Point(114, 54);
            this.buttonOfSort.Name = "buttonOfSort";
            this.buttonOfSort.Size = new System.Drawing.Size(75, 23);
            this.buttonOfSort.TabIndex = 2;
            this.buttonOfSort.Text = "Sort";
            this.buttonOfSort.UseVisualStyleBackColor = true;
            this.buttonOfSort.Click += new System.EventHandler(this.buttonOfSort_Click);
            // 
            // textBoxForSearch
            // 
            this.textBoxForSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxForSearch.Location = new System.Drawing.Point(44, 154);
            this.textBoxForSearch.Name = "textBoxForSearch";
            this.textBoxForSearch.Size = new System.Drawing.Size(86, 25);
            this.textBoxForSearch.TabIndex = 1;
            // 
            // comboBoxForSort
            // 
            this.comboBoxForSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForSort.FormattingEnabled = true;
            this.comboBoxForSort.Location = new System.Drawing.Point(12, 54);
            this.comboBoxForSort.Name = "comboBoxForSort";
            this.comboBoxForSort.Size = new System.Drawing.Size(96, 23);
            this.comboBoxForSort.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonForQuery);
            this.panel2.Controls.Add(this.textBoxForQuery);
            this.panel2.Controls.Add(this.comboBoxForQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(213, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 53);
            this.panel2.TabIndex = 1;
            // 
            // buttonForQuery
            // 
            this.buttonForQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForQuery.Location = new System.Drawing.Point(637, 19);
            this.buttonForQuery.Name = "buttonForQuery";
            this.buttonForQuery.Size = new System.Drawing.Size(135, 23);
            this.buttonForQuery.TabIndex = 2;
            this.buttonForQuery.Text = "Query";
            this.buttonForQuery.UseVisualStyleBackColor = true;
            this.buttonForQuery.Click += new System.EventHandler(this.buttonForQuery_Click);
            // 
            // textBoxForQuery
            // 
            this.textBoxForQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxForQuery.Location = new System.Drawing.Point(146, 19);
            this.textBoxForQuery.Name = "textBoxForQuery";
            this.textBoxForQuery.Size = new System.Drawing.Size(484, 25);
            this.textBoxForQuery.TabIndex = 1;
            // 
            // comboBoxForQuery
            // 
            this.comboBoxForQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForQuery.FormattingEnabled = true;
            this.comboBoxForQuery.Location = new System.Drawing.Point(7, 19);
            this.comboBoxForQuery.Name = "comboBoxForQuery";
            this.comboBoxForQuery.Size = new System.Drawing.Size(133, 23);
            this.comboBoxForQuery.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonForRemove);
            this.panel3.Controls.Add(this.buttonForAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(213, 535);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(795, 60);
            this.panel3.TabIndex = 2;
            // 
            // buttonForRemove
            // 
            this.buttonForRemove.Location = new System.Drawing.Point(502, 3);
            this.buttonForRemove.Name = "buttonForRemove";
            this.buttonForRemove.Size = new System.Drawing.Size(112, 45);
            this.buttonForRemove.TabIndex = 1;
            this.buttonForRemove.Text = "Remove";
            this.buttonForRemove.UseVisualStyleBackColor = true;
            this.buttonForRemove.Click += new System.EventHandler(this.buttonForRemove_Click);
            // 
            // buttonForAdd
            // 
            this.buttonForAdd.Location = new System.Drawing.Point(233, 3);
            this.buttonForAdd.Name = "buttonForAdd";
            this.buttonForAdd.Size = new System.Drawing.Size(112, 45);
            this.buttonForAdd.TabIndex = 0;
            this.buttonForAdd.Text = "Add/Update";
            this.buttonForAdd.UseVisualStyleBackColor = true;
            this.buttonForAdd.Click += new System.EventHandler(this.buttonForAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(212, 54);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(794, 478);
            this.dataGridView.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonForImport;
        private System.Windows.Forms.Button buttonOfSort;
        private System.Windows.Forms.TextBox textBoxForSearch;
        private System.Windows.Forms.ComboBox comboBoxForSort;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonForQuery;
        private System.Windows.Forms.TextBox textBoxForQuery;
        private System.Windows.Forms.ComboBox comboBoxForQuery;
        private System.Windows.Forms.Button buttonForExport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonForRemove;
        private System.Windows.Forms.Button buttonForAdd;
        private System.Windows.Forms.DataGridView OrderData;
        private System.Windows.Forms.Button buttonForSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

