namespace WindowsFormsApp2
{
    partial class StudentMain
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_boySearch = new System.Windows.Forms.Button();
            this.btn_girlSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(387, 50);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 44);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "성적입력";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.BackColor = System.Drawing.SystemColors.Control;
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Location = new System.Drawing.Point(387, 104);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(94, 44);
            this.btn_modify.TabIndex = 1;
            this.btn_modify.Text = "성적수정";
            this.btn_modify.UseVisualStyleBackColor = false;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_boySearch
            // 
            this.btn_boySearch.BackColor = System.Drawing.SystemColors.Control;
            this.btn_boySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_boySearch.Location = new System.Drawing.Point(387, 204);
            this.btn_boySearch.Name = "btn_boySearch";
            this.btn_boySearch.Size = new System.Drawing.Size(94, 44);
            this.btn_boySearch.TabIndex = 2;
            this.btn_boySearch.Text = "남자성적조회";
            this.btn_boySearch.UseVisualStyleBackColor = false;
            this.btn_boySearch.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_girlSearch
            // 
            this.btn_girlSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btn_girlSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_girlSearch.Location = new System.Drawing.Point(387, 254);
            this.btn_girlSearch.Name = "btn_girlSearch";
            this.btn_girlSearch.Size = new System.Drawing.Size(94, 44);
            this.btn_girlSearch.TabIndex = 3;
            this.btn_girlSearch.Text = "여자성적조회";
            this.btn_girlSearch.UseVisualStyleBackColor = false;
            this.btn_girlSearch.Click += new System.EventHandler(this.btn_search1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 50);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(355, 248);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "동광학교의 학사일정";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(387, 154);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 44);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "성적삭제";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 332);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_girlSearch);
            this.Controls.Add(this.btn_boySearch);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_add);
            this.Name = "StudentMain";
            this.Text = "동광학교의 성적관리 프로그램";
            this.Load += new System.EventHandler(this.StudentMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_boySearch;
        private System.Windows.Forms.Button btn_girlSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
    }
}

