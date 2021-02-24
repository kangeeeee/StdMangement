using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StudentAdd : Form
    {
        cStudentAdd cStudentAdd;
        public StudentAdd()
        {
            InitializeComponent();
        } 
        private void Btn_add_Click(object sender, EventArgs e) // 입력버튼클릭
        {
            cStudentAdd = new cStudentAdd();
            if ((string)cb_sex.SelectedItem == "남자") // 콤보박스 남자선택시
            {
                if (cStudentAdd.Add(cb_sex.SelectedItem.ToString(), txt_number.Text, txt_kor.Text, txt_math.Text, txt_eng.Text))
                    MessageBox.Show("성적이 추가 완료되었습니다.");
                else
                    MessageBox.Show("성적 입력 오류입니다, 다시입력해주세요.");
            }
            else if ((string)cb_sex.SelectedItem == "여자") // 콤보박스 여자선택시
            {
                if (cStudentAdd.Add(cb_sex.SelectedItem.ToString(), txt_number.Text, txt_kor.Text, txt_math.Text, txt_eng.Text))
                    MessageBox.Show("성적이 추가 완료되었습니다.");
                else
                    MessageBox.Show("성적 입력 오류입니다, 다시입력해주세요.");
            }
            else // 성별자체를 입력하지 않았을 경우
                MessageBox.Show("성별을 선택하세요.");
        }
 
    }

}
