using MySql.Data.MySqlClient;
using System;

namespace WindowsFormsApp2
{
    class cStudentDelete
    {
        string connection = "Server=127.0.0.1;Database=student;Uid=root;Pwd=root";
        cStudent student;
        public bool Delete(string sex,string num) // 콤보박스의 성별, 학번을 전달받음
        {
            if (sex == "남자") // 남학생일 경우
            {
                string select = "select num from score where num='" + num + "'";  // 먼저 학번을 읽어와야 함으로
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(select, conn);
                        cmd.ExecuteNonQuery();
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read()) // 전달받은 학생의 학번과 일치하는 경우
                        {
                            student = new cBoy(); // 남학생 객체를 생성함
                            student.Number = num; // 학번을 저장
                        }

                    }
                    string Query = "delete from score where num='" + student.Number + "'"; // 전달받은 학번을 삭제하는 쿼리문
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(Query, conn);
                        cmd.ExecuteNonQuery();  
                    }
                    return true; // 삭제가 완료되었을 경우 참값반환
                }
                catch (MySqlException) // 학번을 전달받았는데 데이터가 없을 경우 false 반환
                {
                    return false;
                }
                catch (NullReferenceException) // 학번을 입력하지 않고 삭제버튼을 눌렀을 시 false 반환
                {
                    return false;
                }

            }
            else if (sex == "여자") // 여학생일 경우 남학생과 동일함
            {
                string select = "select num from score where num='" + num + "'";
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(select, conn);
                        cmd.ExecuteNonQuery();
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            student = new cGirl();
                            student.Number = num;
                        }

                    }
                    string Query = "delete from score where num='" + student.Number + "'";
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(Query, conn);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (MySqlException)
                {
                    return false;
                }
                catch (NullReferenceException)
                {
                    return false;
                }
            }
            else // 성별을 선택하지도 않았을 시 false 반환
                return false;
        }
    }
}
