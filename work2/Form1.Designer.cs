namespace work2
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
            this.Operator = new System.Windows.Forms.ComboBox();
            this.BtnCompute = new System.Windows.Forms.Button();
            this.TextNum1 = new System.Windows.Forms.TextBox();
            this.TextNum2 = new System.Windows.Forms.TextBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Operator
            // 
            this.Operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Operator.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Operator.FormattingEnabled = true;
            this.Operator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.Operator.Location = new System.Drawing.Point(212, 78);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(57, 23);
            this.Operator.TabIndex = 1;
            // 
            // BtnCompute
            // 
            this.BtnCompute.Location = new System.Drawing.Point(135, 196);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(75, 23);
            this.BtnCompute.TabIndex = 3;
            this.BtnCompute.Text = "COMPUTE";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // TextNum1
            // 
            this.TextNum1.Location = new System.Drawing.Point(71, 78);
            this.TextNum1.Name = "TextNum1";
            this.TextNum1.Size = new System.Drawing.Size(100, 25);
            this.TextNum1.TabIndex = 0;
            // 
            // TextNum2
            // 
            this.TextNum2.Location = new System.Drawing.Point(301, 78);
            this.TextNum2.Name = "TextNum2";
            this.TextNum2.Size = new System.Drawing.Size(100, 25);
            this.TextNum2.TabIndex = 2;
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.ForeColor = System.Drawing.Color.Red;
            this.LblMsg.Location = new System.Drawing.Point(176, 153);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(15, 15);
            this.LblMsg.TabIndex = 3;
            this.LblMsg.Text = " ";
            this.LblMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "First operand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second operand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Operator";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(258, 196);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(483, 337);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.Operator);
            this.Controls.Add(this.TextNum2);
            this.Controls.Add(this.TextNum1);
            this.Controls.Add(this.BtnCompute);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCompute;
        private System.Windows.Forms.TextBox TextNum1;
        private System.Windows.Forms.TextBox TextNum2;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.ComboBox Operator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnClear;
    }
}

