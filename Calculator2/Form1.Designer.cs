namespace Calculator2
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.textExp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnClear = new System.Windows.Forms.Button();
            this.newForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textExp
            // 
            this.textExp.Location = new System.Drawing.Point(12, 18);
            this.textExp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textExp.Multiline = true;
            this.textExp.Name = "textExp";
            this.textExp.Size = new System.Drawing.Size(486, 55);
            this.textExp.TabIndex = 0;
            this.textExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNum7
            // 
            this.btnNum7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum7.Location = new System.Drawing.Point(12, 135);
            this.btnNum7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(75, 60);
            this.btnNum7.TabIndex = 2;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum4.Location = new System.Drawing.Point(12, 204);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(75, 60);
            this.btnNum4.TabIndex = 3;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum1.Location = new System.Drawing.Point(12, 273);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(75, 60);
            this.btnNum1.TabIndex = 4;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum0.Location = new System.Drawing.Point(12, 342);
            this.btnNum0.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(157, 60);
            this.btnNum0.TabIndex = 5;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum8.Location = new System.Drawing.Point(93, 135);
            this.btnNum8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(75, 60);
            this.btnNum8.TabIndex = 6;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum5.Location = new System.Drawing.Point(93, 204);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(75, 60);
            this.btnNum5.TabIndex = 7;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum2.Location = new System.Drawing.Point(93, 273);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(75, 60);
            this.btnNum2.TabIndex = 8;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum9.Location = new System.Drawing.Point(177, 135);
            this.btnNum9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(75, 60);
            this.btnNum9.TabIndex = 10;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum6.Location = new System.Drawing.Point(177, 204);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(75, 60);
            this.btnNum6.TabIndex = 11;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum3.Location = new System.Drawing.Point(177, 273);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(75, 60);
            this.btnNum3.TabIndex = 12;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDot.Location = new System.Drawing.Point(177, 342);
            this.btnDot.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(75, 60);
            this.btnDot.TabIndex = 13;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlus.Location = new System.Drawing.Point(258, 135);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 60);
            this.btnPlus.TabIndex = 14;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMulti.Location = new System.Drawing.Point(258, 204);
            this.btnMulti.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 60);
            this.btnMulti.TabIndex = 15;
            this.btnMulti.Text = "×";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLeft.Location = new System.Drawing.Point(258, 273);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 60);
            this.btnLeft.TabIndex = 16;
            this.btnLeft.Text = "(";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEqual.Location = new System.Drawing.Point(258, 342);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(157, 60);
            this.btnEqual.TabIndex = 17;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinus.Location = new System.Drawing.Point(342, 135);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 60);
            this.btnMinus.TabIndex = 18;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDiv.Location = new System.Drawing.Point(342, 204);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 60);
            this.btnDiv.TabIndex = 19;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRight.Location = new System.Drawing.Point(342, 273);
            this.btnRight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 60);
            this.btnRight.TabIndex = 20;
            this.btnRight.Text = ")";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCE.Location = new System.Drawing.Point(423, 204);
            this.btnCE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(75, 129);
            this.btnCE.TabIndex = 21;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelResult.Location = new System.Drawing.Point(177, 78);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(321, 52);
            this.labelResult.TabIndex = 22;
            this.labelResult.Text = "0";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(423, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 59);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "←";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // newForm
            // 
            this.newForm.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.newForm.Location = new System.Drawing.Point(423, 342);
            this.newForm.Name = "newForm";
            this.newForm.Size = new System.Drawing.Size(74, 59);
            this.newForm.TabIndex = 24;
            this.newForm.Text = "Search";
            this.newForm.UseVisualStyleBackColor = true;
            this.newForm.Click += new System.EventHandler(this.newForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 408);
            this.Controls.Add(this.newForm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textExp);
            this.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Label labelResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button newForm;
    }
}

