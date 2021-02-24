namespace WindowsFormsApp2
{
    partial class StudentAdd
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
            this.l_sex = new System.Windows.Forms.Label();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.l_kor = new System.Windows.Forms.Label();
            this.l_math = new System.Windows.Forms.Label();
            this.l_eng = new System.Windows.Forms.Label();
            this.txt_kor = new System.Windows.Forms.TextBox();
            this.txt_math = new System.Windows.Forms.TextBox();
            this.txt_eng = new System.Windows.Forms.TextBox();
            this.l_num = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_sex
            // 
            this.l_sex.AutoSize = true;
            this.l_sex.ForeColor = System.Drawing.Color.Red;
            this.l_sex.Location = new System.Drawing.Point(15, 39);
            this.l_sex.Name = "l_sex";
            this.l_sex.Size = new System.Drawing.Size(29, 12);
            this.l_sex.TabIndex = 0;
            this.l_sex.Text = "성별";
            // 
            // cb_sex
            // 
            this.cb_sex.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.cb_sex.Location = new System.Drawing.Point(76, 36);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(77, 20);
            this.cb_sex.TabIndex = 1;
            // 
            // l_kor
            // 
            this.l_kor.AutoSize = true;
            this.l_kor.Location = new System.Drawing.Point(15, 124);
            this.l_kor.Name = "l_kor";
            this.l_kor.Size = new System.Drawing.Size(29, 12);
            this.l_kor.TabIndex = 2;
            this.l_kor.Text = "국어";
            // 
            // l_math
            // 
            this.l_math.AutoSize = true;
            this.l_math.Location = new System.Drawing.Point(15, 180);
            this.l_math.Name = "l_math";
            this.l_math.Size = new System.Drawing.Size(29, 12);
            this.l_math.TabIndex = 3;
            this.l_math.Text = "수학";
            // 
            // l_eng
            // 
            this.l_eng.AutoSize = true;
            this.l_eng.Location = new System.Drawing.Point(15, 231);
            this.l_eng.Name = "l_eng";
            this.l_eng.Size = new System.Drawing.Size(29, 12);
            this.l_eng.TabIndex = 4;
            this.l_eng.Text = "영어";
            // 
            // txt_kor
            // 
            this.txt_kor.BackColor = System.Drawing.Color.White;
            this.txt_kor.Location = new System.Drawing.Point(76, 121);
            this.txt_kor.Name = "txt_kor";
            this.txt_kor.Size = new System.Drawing.Size(77, 21);
            this.txt_kor.TabIndex = 5;
            // 
            // txt_math
            // 
            this.txt_math.Location = new System.Drawing.Point(76, 171);
            this.txt_math.Name = "txt_math";
            this.txt_math.Size = new System.Drawing.Size(77, 21);
            this.txt_math.TabIndex = 6;
            // 
            // txt_eng
            // 
            this.txt_eng.Location = new System.Drawing.Point(76, 222);
            this.txt_eng.Name = "txt_eng";
            this.txt_eng.Size = new System.Drawing.Size(77, 21);
            this.txt_eng.TabIndex = 7;
            // 
            // l_num
            // 
            this.l_num.AutoSize = true;
            this.l_num.ForeColor = System.Drawing.Color.Maroon;
            this.l_num.Location = new System.Drawing.Point(15, 75);
            this.l_num.Name = "l_num";
            this.l_num.Size = new System.Drawing.Size(29, 12);
            this.l_num.TabIndex = 8;
            this.l_num.Text = "학번";
            // 
            // txt_number
            // 
            this.txt_number.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_number.Location = new System.Drawing.Point(76, 72);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(77, 21);
            this.txt_number.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(17, 268);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(136, 42);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "성적입력";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "학생의 성적을 입력하세요.";
            // 
            // StudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(174, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.l_num);
            this.Controls.Add(this.txt_eng);
            this.Controls.Add(this.txt_math);
            this.Controls.Add(this.txt_kor);
            this.Controls.Add(this.l_eng);
            this.Controls.Add(this.l_math);
            this.Controls.Add(this.l_kor);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.l_sex);
            this.Name = "StudentAdd";
            this.Text = "학생 성적 입력";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_sex;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.Label l_kor;
        private System.Windows.Forms.Label l_math;
        private System.Windows.Forms.Label l_eng;
        private System.Windows.Forms.TextBox txt_kor;
        private System.Windows.Forms.TextBox txt_math;
        private System.Windows.Forms.TextBox txt_eng;
        private System.Windows.Forms.Label l_num;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
    }
}