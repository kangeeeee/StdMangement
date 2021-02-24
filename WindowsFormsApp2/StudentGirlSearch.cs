using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StudentGirlSearch : Form
    {

        cStudentGirlSearch cStudentGirlSearch;
        public StudentGirlSearch()
        {
            InitializeComponent();
        }

        private void StudentGirlSearch_Load(object sender, EventArgs e)
        {
            cStudentGirlSearch = new cStudentGirlSearch();
            dataGridView1.DataSource = cStudentGirlSearch.GirlSearch();
        }
    }
}
