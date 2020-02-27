namespace CalcForm
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.number1 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reset_b = new System.Windows.Forms.Button();
            this.plus_b = new System.Windows.Forms.Button();
            this.minus_b = new System.Windows.Forms.Button();
            this.mult_b = new System.Windows.Forms.Button();
            this.div_b = new System.Windows.Forms.Button();
            this.calc_b = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dot_b = new System.Windows.Forms.Button();
            this.sign_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(14, 259);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(70, 70);
            this.number1.TabIndex = 0;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.Number_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(14, 183);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(70, 70);
            this.number4.TabIndex = 0;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.Number_Click);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(14, 107);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(70, 70);
            this.number7.TabIndex = 0;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.Number_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(90, 259);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(70, 70);
            this.number2.TabIndex = 0;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.Number_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(90, 183);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(70, 70);
            this.number5.TabIndex = 0;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.Number_Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(90, 107);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(70, 70);
            this.number8.TabIndex = 0;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.Number_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(166, 259);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(70, 70);
            this.number3.TabIndex = 0;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.Number_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(166, 183);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(70, 70);
            this.number6.TabIndex = 0;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.Number_Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(166, 107);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(70, 70);
            this.number9.TabIndex = 0;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.Number_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Noto Sans CJK KR Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 43);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // reset_b
            // 
            this.reset_b.Location = new System.Drawing.Point(257, 107);
            this.reset_b.Name = "reset_b";
            this.reset_b.Size = new System.Drawing.Size(70, 34);
            this.reset_b.TabIndex = 0;
            this.reset_b.Text = "RESET";
            this.reset_b.UseVisualStyleBackColor = true;
            this.reset_b.Click += new System.EventHandler(this.Reset_Click);
            // 
            // plus_b
            // 
            this.plus_b.Location = new System.Drawing.Point(257, 183);
            this.plus_b.Name = "plus_b";
            this.plus_b.Size = new System.Drawing.Size(70, 34);
            this.plus_b.TabIndex = 2;
            this.plus_b.Text = "+";
            this.plus_b.UseVisualStyleBackColor = true;
            this.plus_b.Click += new System.EventHandler(this.Operator_Click);
            // 
            // minus_b
            // 
            this.minus_b.Location = new System.Drawing.Point(257, 219);
            this.minus_b.Name = "minus_b";
            this.minus_b.Size = new System.Drawing.Size(70, 34);
            this.minus_b.TabIndex = 2;
            this.minus_b.Text = "-";
            this.minus_b.UseVisualStyleBackColor = true;
            this.minus_b.Click += new System.EventHandler(this.Operator_Click);
            // 
            // mult_b
            // 
            this.mult_b.Location = new System.Drawing.Point(257, 255);
            this.mult_b.Name = "mult_b";
            this.mult_b.Size = new System.Drawing.Size(70, 34);
            this.mult_b.TabIndex = 2;
            this.mult_b.Text = "×";
            this.mult_b.UseVisualStyleBackColor = true;
            this.mult_b.Click += new System.EventHandler(this.Operator_Click);
            // 
            // div_b
            // 
            this.div_b.Location = new System.Drawing.Point(257, 295);
            this.div_b.Name = "div_b";
            this.div_b.Size = new System.Drawing.Size(70, 34);
            this.div_b.TabIndex = 2;
            this.div_b.Text = "÷";
            this.div_b.UseVisualStyleBackColor = true;
            this.div_b.Click += new System.EventHandler(this.Operator_Click);
            // 
            // calc_b
            // 
            this.calc_b.Location = new System.Drawing.Point(257, 335);
            this.calc_b.Name = "calc_b";
            this.calc_b.Size = new System.Drawing.Size(70, 70);
            this.calc_b.TabIndex = 2;
            this.calc_b.Text = "=";
            this.calc_b.UseVisualStyleBackColor = true;
            this.calc_b.Click += new System.EventHandler(this.Calc_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(90, 335);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(70, 70);
            this.number0.TabIndex = 0;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.Number_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 18);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // dot_b
            // 
            this.dot_b.Location = new System.Drawing.Point(166, 335);
            this.dot_b.Name = "dot_b";
            this.dot_b.Size = new System.Drawing.Size(70, 70);
            this.dot_b.TabIndex = 0;
            this.dot_b.Text = ".";
            this.dot_b.UseVisualStyleBackColor = true;
            this.dot_b.Click += new System.EventHandler(this.Dot_Click);
            // 
            // sign_b
            // 
            this.sign_b.Location = new System.Drawing.Point(14, 335);
            this.sign_b.Name = "sign_b";
            this.sign_b.Size = new System.Drawing.Size(70, 70);
            this.sign_b.TabIndex = 0;
            this.sign_b.Text = "±";
            this.sign_b.UseVisualStyleBackColor = true;
            this.sign_b.Click += new System.EventHandler(this.Sign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(349, 417);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.calc_b);
            this.Controls.Add(this.div_b);
            this.Controls.Add(this.mult_b);
            this.Controls.Add(this.minus_b);
            this.Controls.Add(this.plus_b);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reset_b);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.sign_b);
            this.Controls.Add(this.dot_b);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.number1);
            this.Font = new System.Drawing.Font("Noto Sans CJK KR Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "간단한 계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button reset_b;
        private System.Windows.Forms.Button plus_b;
        private System.Windows.Forms.Button minus_b;
        private System.Windows.Forms.Button mult_b;
        private System.Windows.Forms.Button div_b;
        private System.Windows.Forms.Button calc_b;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dot_b;
        private System.Windows.Forms.Button sign_b;
    }
}

