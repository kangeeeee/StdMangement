using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StudentMain : Form
    { 
        public StudentMain()
        { 
            InitializeComponent();  
        } 
        private void Btn_add_Click(object sender, EventArgs e) //성적입력
        {
            StudentAdd add= new StudentAdd();
            add.ShowDialog();
        } 
        private void btn_modify_Click(object sender, EventArgs e) //성적수정
        {
            StudentModify modify = new StudentModify();
            modify.ShowDialog();
        }
        private void btn_search_Click(object sender, EventArgs e) //남학생 성적조회
        {
            StudentBoySearch boySearch = new StudentBoySearch();
            boySearch.ShowDialog();
        } 
        private void btn_search1_Click(object sender, EventArgs e) //여학생 성적조회
        {
            StudentGirlSearch girlSearch = new StudentGirlSearch();
            girlSearch.ShowDialog();
        } 
        private void StudentMain_Load(object sender, EventArgs e) // 메인폼이 켜질때 학사일정을 불러옴
        {
            cInformationSystem cInformationSystem = new cInformationSystem();
            dataGridView1.DataSource = cInformationSystem.Information();
        }

        private void btn_delete_Click(object sender, EventArgs e) // 성적삭제
        {
            StudentDelete studentDelete = new StudentDelete();
            studentDelete.ShowDialog(); 
        }
    }
}
