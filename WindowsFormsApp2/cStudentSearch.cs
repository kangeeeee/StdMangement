using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    class cStudentSearch
    {
        string connection = "Server=127.0.0.1;Database=student;Uid=root;Pwd=root";
        cStudent student;
        public List<string> Search(string sex, string num) // 리스트 값을 반환해줌
        {
            List<string> list = new List<string>();
            if (sex == "남자") // 성별이 남자일경우
            {
                student = new cBoy(); 
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        conn.Open();
                        string Query = "select kor,math,eng from score where num='" + num + "'";
                        MySqlCommand cmd = new MySqlCommand(Query, conn);
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read()) // sql에서 데이터를 읽음
                        {
                        student.Kor = dr["kor"].ToString();
                        student.Math = dr["math"].ToString();
                        student.Eng = dr["eng"].ToString(); 
                        }
                    list.Add(student.Kor); // 읽어온 데이터를 추가
                    list.Add(student.Math);
                    list.Add(student.Eng);
                    return list; // 리스트를 반환한다.
                    }
                
                  
            }
            else if (sex == "여자") // 성별이 남자일경우
            {
                student = new cGirl();
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string Query = "select kor,math,eng from score where num='" + num + "'";
                    MySqlCommand cmd = new MySqlCommand(Query, conn);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        student.Kor = dr["kor"].ToString();
                        student.Math = dr["math"].ToString();
                        student.Eng = dr["eng"].ToString(); 
                    }
                    list.Add(student.Kor);
                    list.Add(student.Math);
                    list.Add(student.Eng);
                    return list;
                }

            }
            else // 잘못된 값을 전송받았을 시
                return list; // 리스트엔 null 값이 들어있는걸 반환한다.
            
            
        }
    }
}
