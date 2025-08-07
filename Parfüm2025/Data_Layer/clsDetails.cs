
using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace ParfümDb_DataLayer
{
    public class clsDetailsData
    {

        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        public static bool GetDetailsInfoByID(int? DetailsID , ref int ParfümNummer, ref string Beschreibung)
            {
                bool isFound = false;

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Details WHERE DetailsID = @DetailsID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DetailsID", DetailsID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        { 
                            if (reader.Read())
                            {

                                // The record was found
                                isFound = true;

                                ParfümNummer = (int)reader["ParfümNummer"];
                                Beschreibung = reader["Beschreibung"] != DBNull.Value ? reader["Beschreibung"].ToString() : null;



                            }
                        }

                    }
                }
                return isFound;

            }

        public static bool GetDetailsInfoByParfümNummer(ref int? DetailsID,  int ParfümNummer, ref string Beschreibung)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Details WHERE ParfümNummer = @ParfümNummer";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ParfümNummer", ParfümNummer);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            // The record was found
                            isFound = true;

                            DetailsID = (int)reader["DetailsID"];
                            Beschreibung = reader["Beschreibung"] != DBNull.Value ? reader["Beschreibung"].ToString() : null;



                        }
                    }

                }
            }
            return isFound;

        }

        public static DataTable GetAllDetails()
{
    DataTable dt = new DataTable();

    using (SqlConnection connection = new SqlConnection(ConnectionString))
    {
        string query = "SELECT * FROM Details";

        using (SqlCommand command = new SqlCommand(query, connection))
        {

            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                    dt.Load(reader);
            }
        }
    }
    return dt;

}

         public static int? AddNewDetails(int ParfümNummer, string Beschreibung)
        {
            int? DetailsID = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = @"Insert Into Details ([ParfümNummer],[Beschreibung])
                            Values (@ParfümNummer,@Beschreibung)
                            SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ParfümNummer", ParfümNummer);
                    command.Parameters.AddWithValue("@Beschreibung", Beschreibung ?? (object)DBNull.Value);


                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        DetailsID = insertedID;
                    }
                }

            }
            return DetailsID;

        }


         public static bool UpdateDetailsByID(int? DetailsID, int ParfümNummer, string Beschreibung)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = @"Update Details
                                    set 
                                         [ParfümNummer] = @ParfümNummer,
                                         [Beschreibung] = @Beschreibung
                                  where [DetailsID]= @DetailsID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetailsID", DetailsID);
                    command.Parameters.AddWithValue("@ParfümNummer", ParfümNummer);
                    command.Parameters.AddWithValue("@Beschreibung", Beschreibung ?? (object)DBNull.Value);


                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }

            }

            return (rowsAffected > 0);
        }


        public static bool DeleteDetails(int DetailsID)
{
    int rowsAffected = 0;

    using (SqlConnection connection = new SqlConnection(ConnectionString))
    {
        string query = @"Delete Details 
                        where DetailsID = @DetailsID";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@DetailsID", DetailsID);


            connection.Open();
            
            rowsAffected = command.ExecuteNonQuery();


        }

    }
    
    return (rowsAffected > 0);

}
        
        public static DataTable SearchData(string ColumnName, string Data)
{
    DataTable dt = new DataTable();

    using (SqlConnection connection = new SqlConnection(ConnectionString))
    {
        string query = $@"select * from Details
                    where {ColumnName} Like '' + @Data + '%';";

        using (SqlCommand Command = new SqlCommand(query, connection))
        {
            Command.Parameters.AddWithValue("@Data", Data);


            connection.Open();

            using (SqlDataReader reader = Command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
        }
        
    }

    return dt;
}
    }
}
