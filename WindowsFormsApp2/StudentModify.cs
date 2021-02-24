using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StudentModify : Form
    {

        cStudentUpdate cStudentUpdate;
        cStudentSearch cStudentSearch ;
         
        public StudentModify()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e) // 성적 수정전 학생의 성적을 불러옴
        {
            cStudentSearch = new cStudentSearch();
            try
            {
                if (cStudentSearch.Search(cb_sex.SelectedItem.ToString(), txt_number.Text).Contains(null))
                { // 리스트에 null 값이 반환되게 되면 학번을 잘못입력한 경우나 학생이 없는경우

                    MessageBox.Show("학번을 잘못 입력하였습니다.");
                }
                else // 해당학생의 성적을 텍스트박스로 나타냄
                {
                    txt_kor.Text = cStudentSearch.Search(cb_sex.SelectedItem.ToString(), txt_number.Text)[0];
                    txt_math.Text = cStudentSearch.Search(cb_sex.SelectedItem.ToString(), txt_number.Text)[1];
                    txt_eng.Text = cStudentSearch.Search(cb_sex.SelectedItem.ToString(), txt_number.Text)[2];
                    btn_modify.Enabled = true; // 수정버튼을 사용할 수 있게 만들어줌
                    MessageBox.Show("학생의 성적을 불러오는데 성공했습니다.");
                    btn_search.Enabled = false; // 조회버튼을 잠금
                }
            }
            catch(Exception) // 성별을 입력하지 않고 조회버튼을 누를 시 오류 예외처리
            {
                MessageBox.Show("성별을 선택하세요.");
            }
           
        }

        private void btn_modify_Click(object sender, EventArgs e) // 수정버튼을 누를 시
        {
            cStudentUpdate = new cStudentUpdate();
            if ((string)cb_sex.SelectedItem == "남자")
            {
                if (cStudentUpdate.Update(cb_sex.SelectedItem.ToString(), txt_number.Text, txt_kor.Text, txt_math.Text, txt_eng.Text))
                    MessageBox.Show("성적이 성공적으로 수정되었습니다.");
                else
                    MessageBox.Show("올바른 성적 값을 입력하세요.");
            }
            else
            {
                if (cStudentUpdate.Update(cb_sex.SelectedItem.ToString(), txt_number.Text, txt_kor.Text, txt_math.Text, txt_eng.Text))
                    MessageBox.Show("성적이 성공적으로 수정되었습니다.");
                else
                    MessageBox.Show("올바른 성적 값을 입력하세요.");
            }
        }
    }
}
