using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Data_Layer
{
    public class clsRechnungsdetailsDatenzugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        public static  string connectionString { get { return ConnectionString; } }

        public static bool GetRechnungsDetailsByID(int detailsID, ref int belegID, ref int parfümNummer,
              ref float verkaufsMenge, ref float HauptLagerbestand, ref decimal normalPreis, ref decimal gesamtPreis, ref bool lagerbestandAktualisiert)
        {

            bool isfound = false;
            string abfrage = @"SELECT * From  RechnungsDetails Where detailID= @detailID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        command.Parameters.AddWithValue("@detailID", detailsID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                belegID = (int)reader["belegID"];
                                parfümNummer = (int)reader["parfümNummer"];                              
                                verkaufsMenge = (float)reader["verkaufsMenge"];
                                HauptLagerbestand = (float)reader["HauptLagerbestand"];
                                normalPreis = (decimal)reader["normalPreis"];
                                gesamtPreis = (decimal)reader["gesamtPreis"];
                                lagerbestandAktualisiert = (bool)reader["lagerbestandAktualisiert"];
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                isfound = false;
                throw;
            }

            return isfound;
        }
        public static DataTable GetRecordAnzahlProSeite(int ZeileProseite, int SeiteNummer)
        {
            DataTable dt = new DataTable();
           using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using(SqlCommand command = new SqlCommand("Sp_GetRechnungsRecordsProSeite", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ZeileProSeite", ZeileProseite);
                        command.Parameters.AddWithValue("@SeiteNummer", SeiteNummer);

                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
                catch(SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return dt;
        }

        public static int AddNewRechnungsDetailsDaten(int belegID, int parfümNummer,float verkaufsMenge,
             float HauptLagerbestand, decimal normalerPreis, decimal gesamtPreis, bool lagerbestandAktualisiert)
        {
            int detailsID = -1;

            string abfrage = @"Insert into RechnungsDetails (belegID, parfümNummer,verkaufsMenge,HauptLagerbestand, normalPreis, gesamtPreis, lagerbestandAktualisiert)
                                        Values  (@belegID, @parfümNummer, @verkaufsMenge, @HauptLagerbestand, @normalPreis, @gesamtPreis, @lagerbestandAktualisiert)
                                 Select Scope_Identity()";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        // Über Parameter hinzufügen
                        command.Parameters.AddWithValue("@belegID", belegID);
                       command.Parameters.AddWithValue("@parfümNummer", parfümNummer);              
                        command.Parameters.AddWithValue("@verkaufsMenge", verkaufsMenge);
                        command.Parameters.AddWithValue("@HauptLagerbestand", HauptLagerbestand);
                        command.Parameters.AddWithValue("@normalPreis", normalerPreis);
                        command.Parameters.AddWithValue("@gesamtPreis", gesamtPreis);
                        command.Parameters.AddWithValue("@lagerbestandAktualisiert", lagerbestandAktualisiert);


                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                            detailsID = InsertedID;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return detailsID;
        }

        public static bool UpdateRechnungsDetails(int detailID, int belegID, int parfümNummer, float verkaufsMenge,
             float HauptLagerbestand, decimal normalerPreis, decimal gesamtPreis, bool lagerbestandAktualisiert)
        {
            int RowAffected = 0;
            string abfrage = @"Update RechnungsDetails 
                                                    Set
                                                   belegID = @belegID,
                                                  parfümNummer = @parfümNummer,                                              
                                                  verkaufsMenge = @verkaufsMenge,
                                                  HauptLagerbestand = @HauptLagerbestand,
                                                  normalPreis  = @normalPreis,
                                                  gesamtPreis = @gesamtPreis,
                                     lagerbestandAktualisiert = @lagerbestandAktualisiert

                                          Where detailID = @detailID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        // Parameter hinzufügen
                        command.Parameters.AddWithValue("@detailID", detailID);
                        command.Parameters.AddWithValue("@belegID", belegID);
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);            
                        command.Parameters.AddWithValue("@verkaufsMenge", verkaufsMenge);
                        command.Parameters.AddWithValue("@HauptLagerbestand", HauptLagerbestand);
                        command.Parameters.AddWithValue("@normalPreis", normalerPreis);
                        command.Parameters.AddWithValue("@gesamtPreis", gesamtPreis);
                        command.Parameters.AddWithValue("@lagerbestandAktualisiert", lagerbestandAktualisiert);
            
                        connection.Open();
                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return RowAffected > 0;
        }
        public static bool DeleteRechnungsDetails(int detailID)
        {
            int RowAffected = 0;

            string abfrage = @"Delete From RechnungsDetails Where detailID = @detailID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@detailID", detailID);

                        //Öffene die verbindung und ausführe den Befehl
                        connection.Open();
                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return RowAffected > 0;
        }

        public static bool SetzeLagerbestandAktualisiert(int detailID, float HauptLagerbestand, bool lagerbestandAktualisiert)
        {
            int RowAffected = 0;

            string abfrage = @"Update RechnungsDetails 
                                         Set
                                         lagerbestandAktualisiert = @lagerbestandAktualisiert,
                                          HauptLagerbestand   = @HauptLagerbestand
                                  Where detailID = @detailID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@detailID", detailID);
                        command.Parameters.AddWithValue("@lagerbestandAktualisiert", lagerbestandAktualisiert);
                        command.Parameters.AddWithValue("@HauptLagerbestand", HauptLagerbestand);

                        //Öffene die verbindung und ausführe den Befehl
                        connection.Open();
                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return RowAffected > 0;
        }
    }
}

