namespace CShwWeek8
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
            this.Idlabel = new System.Windows.Forms.Label();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.customerInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customId = new System.Windows.Forms.TextBox();
            this.customName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.odId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SureAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.goodsId = new System.Windows.Forms.TextBox();
            this.goodName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.goodPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.goodsNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Idlabel
            // 
            this.Idlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Idlabel.AutoSize = true;
            this.Idlabel.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Idlabel.Location = new System.Drawing.Point(25, 26);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(36, 24);
            this.Idlabel.TabIndex = 0;
            this.Idlabel.Text = "Id";
            // 
            // Idtxt
            // 
            this.Idtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Idtxt.Location = new System.Drawing.Point(67, 25);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(81, 25);
            this.Idtxt.TabIndex = 1;
            // 
            // customerInfo
            // 
            this.customerInfo.AutoSize = true;
            this.customerInfo.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.customerInfo.Location = new System.Drawing.Point(25, 72);
            this.customerInfo.Name = "customerInfo";
            this.customerInfo.Size = new System.Drawing.Size(110, 24);
            this.customerInfo.TabIndex = 2;
            this.customerInfo.Text = "顾客信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // customId
            // 
            this.customId.Location = new System.Drawing.Point(67, 108);
            this.customId.Name = "customId";
            this.customId.Size = new System.Drawing.Size(81, 25);
            this.customId.TabIndex = 4;
            // 
            // customName
            // 
            this.customName.Location = new System.Drawing.Point(272, 111);
            this.customName.Name = "customName";
            this.customName.Size = new System.Drawing.Size(81, 25);
            this.customName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(25, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "订单列表";
            // 
            // odId
            // 
            this.odId.Location = new System.Drawing.Point(84, 198);
            this.odId.Name = "odId";
            this.odId.Size = new System.Drawing.Size(81, 25);
            this.odId.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "订单Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(32, 324);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(749, 194);
            this.dataGridView.TabIndex = 11;
            // 
            // SureAdd
            // 
            this.SureAdd.Location = new System.Drawing.Point(620, 524);
            this.SureAdd.Name = "SureAdd";
            this.SureAdd.Size = new System.Drawing.Size(146, 37);
            this.SureAdd.TabIndex = 12;
            this.SureAdd.Text = "确认添加/修改";
            this.SureAdd.UseVisualStyleBackColor = true;
            this.SureAdd.Click += new System.EventHandler(this.SureAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "物品信息:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "物品Id";
            // 
            // goodsId
            // 
            this.goodsId.Location = new System.Drawing.Point(187, 227);
            this.goodsId.Name = "goodsId";
            this.goodsId.Size = new System.Drawing.Size(81, 25);
            this.goodsId.TabIndex = 15;
            // 
            // goodName
            // 
            this.goodName.Location = new System.Drawing.Point(379, 227);
            this.goodName.Name = "goodName";
            this.goodName.Size = new System.Drawing.Size(81, 25);
            this.goodName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "物品名";
            // 
            // goodPrice
            // 
            this.goodPrice.Location = new System.Drawing.Point(563, 227);
            this.goodPrice.Name = "goodPrice";
            this.goodPrice.Size = new System.Drawing.Size(81, 25);
            this.goodPrice.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(497, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "物品单价";
            // 
            // goodsNum
            // 
            this.goodsNum.Location = new System.Drawing.Point(187, 258);
            this.goodsNum.Name = "goodsNum";
            this.goodsNum.Size = new System.Drawing.Size(81, 25);
            this.goodsNum.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "物品数";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 573);
            this.Controls.Add(this.goodsNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.goodPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.goodName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.goodsId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SureAdd);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.odId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerInfo);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.Idlabel);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.Label customerInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customId;
        private System.Windows.Forms.TextBox customName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox odId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button SureAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox goodsId;
        private System.Windows.Forms.TextBox goodName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox goodPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox goodsNum;
        private System.Windows.Forms.Label label9;
    }
}