using System;
using System.Data.SqlClient;


namespace bazy
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql = "";
            SqlDataReader read = null;

            //SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS; Initial Catalog=komis1; Integrated Security=true");

            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS; Initial Catalog=komis1; User=Krystyna; Password=123456");
            try
            {
                conn.Open();
                Console.WriteLine("Prawidłowe połącznie z bazą danych\n");
                sql = "select * from [user]";
                SqlCommand result = new SqlCommand(sql, conn);
                read = result.ExecuteReader();
                while (read.Read())
                {
                    Console.WriteLine("imię: {0}",read[1]);
                }


            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }

            Console.ReadKey();
        }

    }
}
