
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Configuration;

namespace ParfümDb_DataLayer
{
    public class clsProduktesData
    {
        //#nullable enable
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        public static bool GetProduktesInfoByID(int? ProduktID , ref string ProduktName, ref int? GekaufteMenge, ref int? GelieferteMenge, ref bool? HauptGeschäft, ref bool? DezGeschäft, ref int? Total)
{
    bool isFound = false;

    try
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            string query = "SP_Get_Produktes_ByID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Ensure correct parameter assignment
                command.Parameters.AddWithValue("@ProduktID", ProduktID ?? (object)DBNull.Value);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                { 
                    if (reader.Read())
                    {
                        // The record was found
                        isFound = true;

                                ProduktName = (string)reader["ProduktName"];
                                GekaufteMenge = reader["GekaufteMenge"] != DBNull.Value ? (int?)reader["GekaufteMenge"] : null;
                                GelieferteMenge = reader["GelieferteMenge"] != DBNull.Value ? (int?)reader["GelieferteMenge"] : null;
                                HauptGeschäft = reader["HauptGeschäft"] != DBNull.Value ? (bool?)reader["HauptGeschäft"] : null;
                                DezGeschäft = reader["DezGeschäft"] != DBNull.Value ? (bool?)reader["DezGeschäft"] : null;
                                Total = reader["Total"] != DBNull.Value ? (int?)reader["Total"] : null;

                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
                // Handle all exceptions in a general way  
                throw new Exception(ex.Message);
    }

    return isFound;
}

        public static DataTable GetAllProduktes()
{
    DataTable dt = new DataTable();

    try
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            string query = "SP_Get_All_Produktes";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure; 

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
                // Handle all exceptions in a general way
                throw new Exception(ex.Message);
            }

    return dt;
}

        public static int? AddNewProduktes(string ProduktName, int? GekaufteMenge, int? GelieferteMenge, bool? HauptGeschäft, bool? DezGeschäft, int? Total)
    {
        int? ProduktID = null;

        try
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = @"SP_Add_Produktes";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ProduktName", ProduktName);
                    command.Parameters.AddWithValue("@GekaufteMenge", GekaufteMenge ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GelieferteMenge", GelieferteMenge ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@HauptGeschäft", HauptGeschäft ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DezGeschäft", DezGeschäft ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Total", Total ?? (object)DBNull.Value);


                    SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIdParam);

                    connection.Open();
                    command.ExecuteNonQuery();

                    // Bring added value
                    if (outputIdParam.Value != DBNull.Value)
                    {
                        ProduktID = (int)outputIdParam.Value;
                    }

                }
            }
        }
        catch (Exception ex)
        {
                // Handle all exceptions in a general way
                throw new Exception(ex.Message);
            }

            return ProduktID;
    }

        public static bool UpdateProduktesByID(int? ProduktID, string ProduktName, int? GekaufteMenge, int? GelieferteMenge, bool? HauptGeschäft, bool? DezGeschäft, int? Total)
{
    int rowsAffected = 0;

    try
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            string query = $@"SP_Update_Produktes_ByID"; 

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Create the parameters for the stored procedure
                    command.Parameters.AddWithValue("@ProduktID", ProduktID);
                    command.Parameters.AddWithValue("@ProduktName", ProduktName);
                    command.Parameters.AddWithValue("@GekaufteMenge", GekaufteMenge ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GelieferteMenge", GelieferteMenge ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@HauptGeschäft", HauptGeschäft ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DezGeschäft", DezGeschäft ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Total", Total ?? (object)DBNull.Value);


                // Open the connection and execute the update
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
                // Handle exceptions
                // Handle all exceptions in a general way
                throw new Exception(ex.Message);
    }

    return (rowsAffected > 0);
}

        public static bool DeleteProduktes(int ProduktID)
{
    int rowsAffected = 0;

    try
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            string query = $@"SP_Delete_Produktes_ByID";  

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ProduktID", ProduktID);

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
                // Handle all exceptions in a general way
                throw new Exception(ex.Message);
     }

    return (rowsAffected > 0);
}
        
        public static DataTable SearchData(string ColumnName, string SearchValue, string Mode = "Anywhere")
{
    DataTable dt = new DataTable();

    try
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            string query = $@"SP_Search_Produktes_ByColumn";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ColumnName", ColumnName);
                command.Parameters.AddWithValue("@SearchValue", SearchValue);
                command.Parameters.AddWithValue("@Mode", Mode);  // Added Mode parameter

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }

                    reader.Close();
                }
            }
        }
    }
    catch (Exception ex)
    {
                // Handle all exceptions in a general way
                throw new Exception(ex.Message);
       }

    return dt;
}
    }
}
