namespace CayleyTree
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
            this.pnlDrawPlat = new System.Windows.Forms.Panel();
            this.lblRecursion = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblRightPer = new System.Windows.Forms.Label();
            this.lblLeftPer = new System.Windows.Forms.Label();
            this.lblRightAngle = new System.Windows.Forms.Label();
            this.lblLeftAngle = new System.Windows.Forms.Label();
            this.lblPenColor = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.tbStatement = new System.Windows.Forms.TextBox();
            this.hsbRecursion = new System.Windows.Forms.HScrollBar();
            this.hsbLength = new System.Windows.Forms.HScrollBar();
            this.hsbRightAngle = new System.Windows.Forms.HScrollBar();
            this.hsbLeftAngle = new System.Windows.Forms.HScrollBar();
            this.hsbRightPer = new System.Windows.Forms.HScrollBar();
            this.hsbLeftPer = new System.Windows.Forms.HScrollBar();
            this.lblDrawX = new System.Windows.Forms.Label();
            this.hsbDrawX = new System.Windows.Forms.HScrollBar();
            this.lblDrawY = new System.Windows.Forms.Label();
            this.hsbDrawY = new System.Windows.Forms.HScrollBar();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // pnlDrawPlat
            // 
            this.pnlDrawPlat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawPlat.Location = new System.Drawing.Point(4, 0);
            this.pnlDrawPlat.Name = "pnlDrawPlat";
            this.pnlDrawPlat.Size = new System.Drawing.Size(620, 540);
            this.pnlDrawPlat.TabIndex = 0;
            // 
            // lblRecursion
            // 
            this.lblRecursion.AutoSize = true;
            this.lblRecursion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRecursion.Location = new System.Drawing.Point(640, 9);
            this.lblRecursion.Name = "lblRecursion";
            this.lblRecursion.Size = new System.Drawing.Size(88, 16);
            this.lblRecursion.TabIndex = 1;
            this.lblRecursion.Text = "递归深度：";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLength.Location = new System.Drawing.Point(640, 58);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(88, 16);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "主干长度：";
            // 
            // lblRightPer
            // 
            this.lblRightPer.AutoSize = true;
            this.lblRightPer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRightPer.Location = new System.Drawing.Point(640, 186);
            this.lblRightPer.Name = "lblRightPer";
            this.lblRightPer.Size = new System.Drawing.Size(120, 16);
            this.lblRightPer.TabIndex = 3;
            this.lblRightPer.Text = "右分支长度比：";
            // 
            // lblLeftPer
            // 
            this.lblLeftPer.AutoSize = true;
            this.lblLeftPer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeftPer.Location = new System.Drawing.Point(640, 225);
            this.lblLeftPer.Name = "lblLeftPer";
            this.lblLeftPer.Size = new System.Drawing.Size(120, 16);
            this.lblLeftPer.TabIndex = 4;
            this.lblLeftPer.Text = "左分支长度比：";
            // 
            // lblRightAngle
            // 
            this.lblRightAngle.AutoSize = true;
            this.lblRightAngle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRightAngle.Location = new System.Drawing.Point(640, 105);
            this.lblRightAngle.Name = "lblRightAngle";
            this.lblRightAngle.Size = new System.Drawing.Size(104, 16);
            this.lblRightAngle.TabIndex = 5;
            this.lblRightAngle.Text = "右分支角度：";
            // 
            // lblLeftAngle
            // 
            this.lblLeftAngle.AutoSize = true;
            this.lblLeftAngle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeftAngle.Location = new System.Drawing.Point(640, 143);
            this.lblLeftAngle.Name = "lblLeftAngle";
            this.lblLeftAngle.Size = new System.Drawing.Size(104, 16);
            this.lblLeftAngle.TabIndex = 6;
            this.lblLeftAngle.Text = "左分支角度：";
            // 
            // lblPenColor
            // 
            this.lblPenColor.AutoSize = true;
            this.lblPenColor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPenColor.Location = new System.Drawing.Point(640, 353);
            this.lblPenColor.Name = "lblPenColor";
            this.lblPenColor.Size = new System.Drawing.Size(88, 16);
            this.lblPenColor.TabIndex = 7;
            this.lblPenColor.Text = "画笔颜色：";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(685, 382);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 15;
            this.btnDraw.Text = "绘制";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // tbStatement
            // 
            this.tbStatement.Location = new System.Drawing.Point(643, 411);
            this.tbStatement.Multiline = true;
            this.tbStatement.Name = "tbStatement";
            this.tbStatement.ReadOnly = true;
            this.tbStatement.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbStatement.Size = new System.Drawing.Size(171, 125);
            this.tbStatement.TabIndex = 16;
            // 
            // hsbRecursion
            // 
            this.hsbRecursion.Location = new System.Drawing.Point(643, 30);
            this.hsbRecursion.Maximum = 120;
            this.hsbRecursion.Minimum = 20;
            this.hsbRecursion.Name = "hsbRecursion";
            this.hsbRecursion.Size = new System.Drawing.Size(140, 14);
            this.hsbRecursion.TabIndex = 17;
            this.hsbRecursion.TabStop = true;
            this.hsbRecursion.Value = 20;
            // 
            // hsbLength
            // 
            this.hsbLength.Location = new System.Drawing.Point(643, 81);
            this.hsbLength.Maximum = 400;
            this.hsbLength.Minimum = 50;
            this.hsbLength.Name = "hsbLength";
            this.hsbLength.Size = new System.Drawing.Size(140, 14);
            this.hsbLength.TabIndex = 18;
            this.hsbLength.TabStop = true;
            this.hsbLength.Value = 50;
            // 
            // hsbRightAngle
            // 
            this.hsbRightAngle.Location = new System.Drawing.Point(643, 125);
            this.hsbRightAngle.Maximum = 360;
            this.hsbRightAngle.Minimum = 10;
            this.hsbRightAngle.Name = "hsbRightAngle";
            this.hsbRightAngle.Size = new System.Drawing.Size(140, 14);
            this.hsbRightAngle.TabIndex = 19;
            this.hsbRightAngle.TabStop = true;
            this.hsbRightAngle.Value = 10;
            // 
            // hsbLeftAngle
            // 
            this.hsbLeftAngle.Location = new System.Drawing.Point(643, 164);
            this.hsbLeftAngle.Maximum = 360;
            this.hsbLeftAngle.Minimum = 10;
            this.hsbLeftAngle.Name = "hsbLeftAngle";
            this.hsbLeftAngle.Size = new System.Drawing.Size(140, 14);
            this.hsbLeftAngle.TabIndex = 20;
            this.hsbLeftAngle.TabStop = true;
            this.hsbLeftAngle.Value = 10;
            // 
            // hsbRightPer
            // 
            this.hsbRightPer.LargeChange = 2;
            this.hsbRightPer.Location = new System.Drawing.Point(643, 207);
            this.hsbRightPer.Maximum = 10;
            this.hsbRightPer.Minimum = 1;
            this.hsbRightPer.Name = "hsbRightPer";
            this.hsbRightPer.Size = new System.Drawing.Size(140, 14);
            this.hsbRightPer.TabIndex = 21;
            this.hsbRightPer.TabStop = true;
            this.hsbRightPer.Value = 1;
            // 
            // hsbLeftPer
            // 
            this.hsbLeftPer.LargeChange = 2;
            this.hsbLeftPer.Location = new System.Drawing.Point(643, 244);
            this.hsbLeftPer.Maximum = 10;
            this.hsbLeftPer.Minimum = 1;
            this.hsbLeftPer.Name = "hsbLeftPer";
            this.hsbLeftPer.Size = new System.Drawing.Size(140, 14);
            this.hsbLeftPer.TabIndex = 22;
            this.hsbLeftPer.TabStop = true;
            this.hsbLeftPer.Value = 1;
            // 
            // lblDrawX
            // 
            this.lblDrawX.AutoSize = true;
            this.lblDrawX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDrawX.Location = new System.Drawing.Point(643, 262);
            this.lblDrawX.Name = "lblDrawX";
            this.lblDrawX.Size = new System.Drawing.Size(72, 16);
            this.lblDrawX.TabIndex = 23;
            this.lblDrawX.Text = "横坐标：";
            // 
            // hsbDrawX
            // 
            this.hsbDrawX.Location = new System.Drawing.Point(643, 282);
            this.hsbDrawX.Maximum = 600;
            this.hsbDrawX.Minimum = 20;
            this.hsbDrawX.Name = "hsbDrawX";
            this.hsbDrawX.Size = new System.Drawing.Size(140, 14);
            this.hsbDrawX.TabIndex = 24;
            this.hsbDrawX.TabStop = true;
            this.hsbDrawX.Value = 20;
            // 
            // lblDrawY
            // 
            this.lblDrawY.AutoSize = true;
            this.lblDrawY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDrawY.Location = new System.Drawing.Point(640, 303);
            this.lblDrawY.Name = "lblDrawY";
            this.lblDrawY.Size = new System.Drawing.Size(72, 16);
            this.lblDrawY.TabIndex = 25;
            this.lblDrawY.Text = "纵坐标：";
            // 
            // hsbDrawY
            // 
            this.hsbDrawY.Location = new System.Drawing.Point(643, 324);
            this.hsbDrawY.Maximum = 500;
            this.hsbDrawY.Minimum = 20;
            this.hsbDrawY.Name = "hsbDrawY";
            this.hsbDrawY.Size = new System.Drawing.Size(140, 14);
            this.hsbDrawY.TabIndex = 26;
            this.hsbDrawY.TabStop = true;
            this.hsbDrawY.Value = 20;
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.Location = new System.Drawing.Point(721, 350);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(75, 23);
            this.btnSelectColor.TabIndex = 0;
            this.btnSelectColor.Text = "取色";
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Click += new System.EventHandler(this.BtnSelectColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 548);
            this.Controls.Add(this.btnSelectColor);
            this.Controls.Add(this.hsbDrawY);
            this.Controls.Add(this.lblDrawY);
            this.Controls.Add(this.hsbDrawX);
            this.Controls.Add(this.lblDrawX);
            this.Controls.Add(this.hsbLeftPer);
            this.Controls.Add(this.hsbRightPer);
            this.Controls.Add(this.hsbLeftAngle);
            this.Controls.Add(this.hsbRightAngle);
            this.Controls.Add(this.hsbLength);
            this.Controls.Add(this.hsbRecursion);
            this.Controls.Add(this.tbStatement);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lblPenColor);
            this.Controls.Add(this.lblLeftAngle);
            this.Controls.Add(this.lblRightAngle);
            this.Controls.Add(this.lblLeftPer);
            this.Controls.Add(this.lblRightPer);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblRecursion);
            this.Controls.Add(this.pnlDrawPlat);
            this.Name = "Form1";
            this.Text = "Cayley Tree";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawPlat;
        private System.Windows.Forms.Label lblRecursion;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblRightPer;
        private System.Windows.Forms.Label lblLeftPer;
        private System.Windows.Forms.Label lblRightAngle;
        private System.Windows.Forms.Label lblLeftAngle;
        private System.Windows.Forms.Label lblPenColor;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox tbStatement;
        private System.Windows.Forms.HScrollBar hsbRecursion;
        private System.Windows.Forms.HScrollBar hsbLength;
        private System.Windows.Forms.HScrollBar hsbRightAngle;
        private System.Windows.Forms.HScrollBar hsbLeftAngle;
        private System.Windows.Forms.HScrollBar hsbRightPer;
        private System.Windows.Forms.HScrollBar hsbLeftPer;
        private System.Windows.Forms.Label lblDrawX;
        private System.Windows.Forms.HScrollBar hsbDrawX;
        private System.Windows.Forms.Label lblDrawY;
        private System.Windows.Forms.HScrollBar hsbDrawY;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

