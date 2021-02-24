using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    class cInformationSystem
    {
        cInformation cInformation; // 정보 엔티티
        string connection = "Server=127.0.0.1;Database=student;Uid=root;Pwd=root";
        public List<cInformation> Information() // 객체 리스트 반환
        {
            List<cInformation> list = new List<cInformation>(); 
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string Query = "select * from information order by date"; // information 테이블에 있는 내용 긁어오는 sql문
                 MySqlCommand cmd = new MySqlCommand(Query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read()) // 한 필드의 데이터를 읽어서 객체에 저장
                {
                    cInformation = new cInformation();
                    cInformation.Date = dr["date"].ToString();
                    cInformation.Information = dr["information"].ToString();
                    list.Add(cInformation); // 리스트에 객체저장
                }
                return list; // 리스트 반환
            }
        }
    }
}
