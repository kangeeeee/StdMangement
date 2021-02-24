using MySql.Data.MySqlClient;
using System;

namespace WindowsFormsApp2
{
    class cStudentUpdate
    {
        cStudent student;
        string connection = "Server=127.0.0.1;Database=student;Uid=root;Pwd=root";
        public bool Update(string sex, string num, string kor, string math, string eng)
        {
            if (sex == "남자") // 콤보박스의 성별이 남자일경우
            { 
                try
                {
                    student = new cBoy(); // 남자 객체(엔티티) 생성
                    student.Number = num;
                    student.Kor = kor;
                    student.Math = math;
                    student.Eng = eng;
                    student.Avg = ((int.Parse(student.Kor) + int.Parse(student.Math) + int.Parse(student.Eng)) / 3).ToString();
                    string Query = "update score set kor='" + student.Kor + "',math='" + student.Math + "',eng='" + student.Eng + "',avg='" + student.Avg + "' where num='" + student.Number + "'";
                    // sql Update 구문
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(Query, conn);
                        cmd.ExecuteNonQuery();
                    }
                    return true; // 올바르게 sql문이 실행되었으면 true 반환

                }
                catch (MySqlException e)
                {
                    return false; // sql 오류시 false 반환

                }
                catch(FormatException e)
                {
                    return false; // 입력을 전부다 하지 않을시 false 반환
                }
            }
            else if (sex == "여자") // 콤보박스의 성별이 여자일 경우
            { 
                try
                {
                    student = new cGirl();
                    student.Number = num;
                    student.Kor = kor;
                    student.Math = math;
                    student.Eng = eng;
                    student.Avg = ((int.Parse(student.Kor) + int.Parse(student.Math) + int.Parse(student.Eng)) / 3).ToString();
                    string Query = "update score set kor='" + student.Kor + "',math='" + student.Math + "',eng='" + student.Eng + "',avg='" + student.Avg + "' where num='" + student.Number + "'";
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(Query, conn);
                        cmd.ExecuteNonQuery();
                    }
                    return true;

                }
                catch (MySqlException e)
                {
                    return false; 
                }
                catch (FormatException e)
                {
                    return false;
                }
            }
            else // 성별을 받지 않았을 경우 false 반환
                return false;
            
         } 
    }
}
