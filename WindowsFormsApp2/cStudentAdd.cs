using MySql.Data.MySqlClient;
using System;

namespace WindowsFormsApp2
{
    class cStudentAdd
    {
        cStudent student;
        string connection = "Server=127.0.0.1;Database=student;Uid=root;Pwd=root";
        public bool Add(string sex,string num,string kor,string math,string eng)
        {
            if (sex == "남자") // 콤보박스의 성별이 남자일경우
            {
                student = new cBoy();
                student.Number = num;
                student.Kor = kor;
                student.Math = math;
                student.Eng = eng;
                 
                // sql insert문
                try
                {
                    student.Avg = ((int.Parse(student.Kor) + int.Parse(student.Math) + int.Parse(student.Eng)) / 3).ToString();
                    string Query = "INSERT INTO score(sex,num,kor,math,eng,avg) VALUES('" + student.Sex + "', '" + student.Number + "', '" + student.Kor + "', '" + student.Math + "','" + student.Eng + "','" + student.Avg + "')";
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
                catch(FormatException) // 모든 값을 넣지 않았을 시 오류
                {
                    return false;
                }
            }
            else if (sex == "여자") // 콤보박스의 성별이 남자일경우
            {
                student = new cGirl();
                student.Number = num;
                student.Kor = kor;
                student.Math = math;
                student.Eng = eng;
                 
                try
                {
                    student.Avg = ((int.Parse(student.Kor) + int.Parse(student.Math) + int.Parse(student.Eng)) / 3).ToString();
                    string Query = "INSERT INTO score(sex,num,kor,math,eng,avg) VALUES('" + student.Sex + "', '" + student.Number + "', '" + student.Kor + "', '" + student.Math + "','" + student.Eng + "','" + student.Avg + "')";
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
                catch (FormatException) // 모든 값을 넣지 않았을 시 오류
                {
                    return false;
                }
            }
            else
                return false;
            
        }

    }
}
