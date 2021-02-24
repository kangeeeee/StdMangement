namespace WindowsFormsApp2
{
    partial class StudentModify
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
            this.l_num = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.l_kor = new System.Windows.Forms.Label();
            this.l_math = new System.Windows.Forms.Label();
            this.l_eng = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_kor = new System.Windows.Forms.TextBox();
            this.txt_math = new System.Windows.Forms.TextBox();
            this.txt_eng = new System.Windows.Forms.TextBox();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.l_sex = new System.Windows.Forms.Label();
            this.btn_modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_num
            // 
            this.l_num.AutoSize = true;
            this.l_num.Location = new System.Drawing.Point(25, 75);
            this.l_num.Name = "l_num";
            this.l_num.Size = new System.Drawing.Size(29, 12);
            this.l_num.TabIndex = 0;
            this.l_num.Text = "학번";
            // 
            // txt_number
            // 
            this.txt_number.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_number.Location = new System.Drawing.Point(77, 72);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(70, 21);
            this.txt_number.TabIndex = 1;
            // 
            // l_kor
            // 
            this.l_kor.AutoSize = true;
            this.l_kor.Location = new System.Drawing.Point(25, 142);
            this.l_kor.Name = "l_kor";
            this.l_kor.Size = new System.Drawing.Size(29, 12);
            this.l_kor.TabIndex = 2;
            this.l_kor.Text = "국어";
            // 
            // l_math
            // 
            this.l_math.AutoSize = true;
            this.l_math.Location = new System.Drawing.Point(25, 193);
            this.l_math.Name = "l_math";
            this.l_math.Size = new System.Drawing.Size(29, 12);
            this.l_math.TabIndex = 3;
            this.l_math.Text = "수학";
            // 
            // l_eng
            // 
            this.l_eng.AutoSize = true;
            this.l_eng.Location = new System.Drawing.Point(25, 250);
            this.l_eng.Name = "l_eng";
            this.l_eng.Size = new System.Drawing.Size(29, 12);
            this.l_eng.TabIndex = 4;
            this.l_eng.Text = "영어";
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(160, 36);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(63, 57);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "조회";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_kor
            // 
            this.txt_kor.Location = new System.Drawing.Point(77, 142);
            this.txt_kor.Name = "txt_kor";
            this.txt_kor.Size = new System.Drawing.Size(70, 21);
            this.txt_kor.TabIndex = 6;
            // 
            // txt_math
            // 
            this.txt_math.Location = new System.Drawing.Point(77, 193);
            this.txt_math.Name = "txt_math";
            this.txt_math.Size = new System.Drawing.Size(70, 21);
            this.txt_math.TabIndex = 7;
            // 
            // txt_eng
            // 
            this.txt_eng.Location = new System.Drawing.Point(77, 241);
            this.txt_eng.Name = "txt_eng";
            this.txt_eng.Size = new System.Drawing.Size(70, 21);
            this.txt_eng.TabIndex = 8;
            // 
            // cb_sex
            // 
            this.cb_sex.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cb_sex.ForeColor = System.Drawing.Color.Black;
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.cb_sex.Location = new System.Drawing.Point(77, 40);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(70, 20);
            this.cb_sex.TabIndex = 9;
            // 
            // l_sex
            // 
            this.l_sex.AutoSize = true;
            this.l_sex.Location = new System.Drawing.Point(25, 43);
            this.l_sex.Name = "l_sex";
            this.l_sex.Size = new System.Drawing.Size(29, 12);
            this.l_sex.TabIndex = 10;
            this.l_sex.Text = "성별";
            // 
            // btn_modify
            // 
            this.btn_modify.Enabled = false;
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_modify.Location = new System.Drawing.Point(153, 142);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(70, 120);
            this.btn_modify.TabIndex = 11;
            this.btn_modify.Text = "수정";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // StudentModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(246, 286);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.l_sex);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.txt_eng);
            this.Controls.Add(this.txt_math);
            this.Controls.Add(this.txt_kor);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.l_eng);
            this.Controls.Add(this.l_math);
            this.Controls.Add(this.l_kor);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.l_num);
            this.Name = "StudentModify";
            this.Text = "학생 성적 수정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_num;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label l_kor;
        private System.Windows.Forms.Label l_math;
        private System.Windows.Forms.Label l_eng;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_kor;
        private System.Windows.Forms.TextBox txt_math;
        private System.Windows.Forms.TextBox txt_eng;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.Label l_sex;
        private System.Windows.Forms.Button btn_modify;
    }
}