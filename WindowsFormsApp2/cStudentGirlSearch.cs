using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    class cStudentGirlSearch
    {
        cStudent student;
        string connection = "Server=127.0.0.1;Database=student;Uid=root;Pwd=root";
        public List<cStudent> GirlSearch() // 학생객체정보를 리스트에 넣어서 반환
        { 
            string sex = "여자"; // 여자학생일 경우

            List<cStudent> cStudents = new List<cStudent>(); // 리스트 생성

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string Query = "select * from score where sex='" + sex + "' order by avg desc";

                MySqlCommand cmd = new MySqlCommand(Query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    student = new cGirl(); // 여자성적 조회니 여자 객체생성
                    student.Number = dr["num"].ToString();
                    student.Kor = dr["kor"].ToString();
                    student.Math = dr["math"].ToString();
                    student.Eng = dr["eng"].ToString();
                    student.Avg = dr["avg"].ToString();
                    cStudents.Add(student); // 리스트에 하나의 학생정보를 담아서 객체에 저장 후 리스트에 저장
                }
                return cStudents;  // 리스트를 반환
            }
        }
    }
}
