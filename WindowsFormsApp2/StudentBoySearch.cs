using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StudentBoySearch : Form
    {
        cStudentBoySearch cStudentBoySearch;
        public StudentBoySearch()
        {
            InitializeComponent();
        } 
        private void StudentSearch_Load(object sender, EventArgs e)
        {
            cStudentBoySearch = new cStudentBoySearch();
            dataGridView1.DataSource = cStudentBoySearch.BoySearch(); 
        }
    }
}
