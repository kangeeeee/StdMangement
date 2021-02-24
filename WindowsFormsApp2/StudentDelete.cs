using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StudentDelete : Form
    {
        cStudentDelete cStudentDelete;
        public StudentDelete()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cStudentDelete = new cStudentDelete();
            if ((string)cb_sex.SelectedItem == "남자") // 콤보박스 남자선택시
            {
                if (cStudentDelete.Delete(cb_sex.SelectedItem.ToString(), txt_num.Text))
                {
                    MessageBox.Show("삭제가 완료되었습니다.");
                }
                else
                    MessageBox.Show("학번을 제대로 입력하세요.");
            }
            else if ((string)cb_sex.SelectedItem == "여자") // 콤보박스 여자선택시
            {
                if (cStudentDelete.Delete(cb_sex.SelectedItem.ToString(), txt_num.Text))
                {
                    MessageBox.Show("삭제가 완료되었습니다.");
                }
                else
                    MessageBox.Show("학번을 제대로 입력하세요.");
            }
            else // 성별자체를 입력하지 않았을 경우
                MessageBox.Show("성별을 선택하세요.");
        }
    }
}
