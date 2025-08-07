using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsEinkaufDatenzugriff
    {

        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public static bool GetEinkaufDatenByParfümID(int parfümNummer, ref string parfümName, ref string parfümCode, ref string hauptBatchNummer,
                    ref float? lagerBestandHaupt, ref string sekundäreBatchNummer,ref float? lagerBestandSekundär, ref int preisKategorie,  ref DateTime erstellungsDatum)
        {

            bool isfound = false;
            string abfrage = @"SELECT * From  Einkauf Where parfümNummer= @parfümNummer";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                parfümName = (string)reader["parfümName"];
                                parfümCode = (string)reader["parfümCode"];
                                hauptBatchNummer = reader["HauptLotNr"] != DBNull.Value ? (string)reader["HauptLotNr"] : null;
                                sekundäreBatchNummer = reader["SekundärLotNr"] != DBNull.Value ? (string)reader["SekundärLotNr"] : null;
                                lagerBestandHaupt = reader["HauptLagerbestand"] != DBNull.Value ? Convert.ToSingle(reader["HauptLagerbestand"]) : (float?)null;
                                lagerBestandSekundär = reader["SekundärLagerbestand"] != DBNull.Value ? Convert.ToSingle(reader["SekundärLagerbestand"]): (float?)null;
                                preisKategorie = (int)reader["preisKategorie"];
                                erstellungsDatum = (DateTime)reader["erstellungsDatum"];
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

        public static bool GetEinkaufDatenByParfümName(ref int parfümNummer, string parfümName, ref string parfümCode, ref string hauptBatchNummer,
                    ref float? lagerBestandHaupt, ref string sekundäreBatchNummer, ref float? lagerBestandSekundär, ref int preisKategorie, ref DateTime erstellungsDatum)
        {

            bool isfound = false;

            string abfrage = @"SELECT * From Einkauf Where parfümName = @parfümName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@parfümName",parfümName);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                parfümNummer = (int)reader["parfümNummer"];
                                parfümCode = (string)reader["parfümCode"];
                                hauptBatchNummer = reader["HauptLotNr"] != DBNull.Value ? (string)reader["HauptLotNr"] : null;
                                sekundäreBatchNummer = reader["SekundärLotNr"] != DBNull.Value ? (string)reader["SekundärLotNr"] : null;
                                lagerBestandHaupt = reader["HauptLagerbestand"] != DBNull.Value ? Convert.ToSingle(reader["HauptLagerbestand"]) : (float?)null;
                                lagerBestandSekundär = reader["SekundärLagerbestand"] != DBNull.Value ? Convert.ToSingle(reader["SekundärLagerbestand"]) : (float?)null;
                                preisKategorie = (int)reader["preisKategorie"];
                                erstellungsDatum = (DateTime)reader["erstellungsDatum"];

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



        public static DataTable GetAllEinkaufDaten()
        {
            DataTable dt = new DataTable();

            string abfrage = @"Select * From  Einkauf
                                                  Order by erstellungsDatum Desc";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return dt;
        }
        public static bool AddNewEinkaufDaten(int parfümNummer, string parfümName, string parfümCode, string hauptBatchNummer,
                    float? lagerBestandHaupt, string sekundäreBatchNummer, float? lagerBestandSekundär, 
                    int preisKategorie, DateTime erstellungsDatum)
        {
            int rowAffected = 0;

            string abfrage = @"Insert into Einkauf (parfümNummer,parfümName,parfümCode,HauptLotNr,HauptLagerbestand, SekundärLotNr
                                             ,SekundärLagerbestand,preisKategorie, erstellungsDatum)
                                        Values  (@parfümNummer,@parfümName,@parfümCode,@HauptLotNr,@HauptLagerbestand, @SekundärLotNr
                                             ,@SekundärLagerbestand,@preisKategorie, @erstellungsDatum)";
       
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        // Über Parameter hinzufügen
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);
                        command.Parameters.AddWithValue("@parfümName", parfümName);
                        command.Parameters.AddWithValue("@parfümCode", parfümCode);
                        command.Parameters.AddWithValue("@HauptLotNr", hauptBatchNummer ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@HauptLagerbestand", lagerBestandHaupt ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@SekundärLotNr", sekundäreBatchNummer??(object)DBNull.Value);
                        command.Parameters.AddWithValue("@SekundärLagerbestand", lagerBestandSekundär ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@preisKategorie", preisKategorie);
                        command.Parameters.AddWithValue("@erstellungsDatum", erstellungsDatum);

                        connection.Open();

                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return (rowAffected > 0);
        }

        public static bool UpdateEinkaufDaten(int parfümNummer, string parfümName, string parfümCode, string hauptBatchNummer,
                    float? lagerBestandHaupt, string sekundäreBatchNummer, float? lagerBestandSekundär,
                    int preisKategorie, DateTime erstellungsDatum)
        {
            int RowAffected = 0;
            string abfrage = @"Update Einkauf  Set
                                                  parfümName = @parfümName,
                                                  parfümCode  = @parfümCode,
                                                  HauptLotNr= @HauptLotNr,
                                                    HauptLagerbestand= @HauptLagerbestand,
                                                    SekundärLotNr = @SekundärLotNr,
                                                   SekundärLagerbestand = @SekundärLagerbestand,
                                                  preisKategorie = @preisKategorie,
                                                  erstellungsDatum = @erstellungsDatum
                                            Where parfümNummer = @parfümNummer";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        // Über Parameter hinzufügen
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);
                        command.Parameters.AddWithValue("@parfümName", parfümName);
                        command.Parameters.AddWithValue("@parfümCode", parfümCode);
                        command.Parameters.AddWithValue("@HauptLotNr", hauptBatchNummer ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@HauptLagerbestand", lagerBestandHaupt ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@SekundärLotNr", sekundäreBatchNummer ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@SekundärLagerbestand", lagerBestandSekundär ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@preisKategorie", preisKategorie);
                        command.Parameters.AddWithValue("@erstellungsDatum", erstellungsDatum);

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


        public static bool UpdateLagerBestandHaupt(int parfümNummer, float? lagerBestandHaupt)
        {
            int RowAffected = 0;
            string abfrage = @"Update Einkauf  Set
                                                  HauptLagerbestand = @HauptLagerbestand,
                                                  erstellungsDatum = GetDate()
                                            Where parfümNummer = @parfümNummer";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        // Parameter hinzufügen
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);
                        command.Parameters.AddWithValue("@HauptLagerbestand", lagerBestandHaupt);

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
        public static bool UpdateLagerbestandSekundäre(int parfümNummer, string sekundärBatchNummer, float? lagerBestandSekundär)
        {
            int RowAffected = 0;
            string abfrage = @"Update Einkauf Set
                            SekundärLagerbestand = @SekundärLagerbestand,
                            HauptLotNr = SekundärLotNr,     -- Hier wird die aktuelle Sekundärnummer zur Hauptnummer
                            SekundärLotNr = NULL,          -- Sekundärnummer wird gelöscht
                            erstellungsDatum = GetDate()
                        Where parfümNummer = @parfümNummer";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        // Parameter setzen
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);
                        command.Parameters.AddWithValue("@SekundärLagerbestand", lagerBestandSekundär ?? (object)DBNull.Value);
                       // command.Parameters.AddWithValue("@lagerBestandSekundär", lagerBestandSekundär ?? (object)DBNull.Value);

                        connection.Open();
                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Fehlerbehandlung
                Console.WriteLine("Fehler: " + ex.Message);
            }

            return RowAffected > 0;
        }
        public static bool DeleteEinkaufDaten(int parfümNummer)
        {
            int RowAffected = 0;

            string abfrage = @"Delete From Einkauf Where ParfümNummer = @parfümNummer";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);

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
        public static bool IstParfümNummerVerfügbar(int parfümNummer)
        {
            bool istVerfügbar = false;

            string abfrage = @"Select 1 From Einkauf where parfümNummer = @parfümNummer";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);

                        //Öffene die verbindung und ausführe den Befehl
                        connection.Open();

                        object result = command.ExecuteScalar();
                        istVerfügbar = (result != null && (int)result == 1);
                    }
                }
            }
            catch (SqlException ex)
            {
                istVerfügbar = false;
                throw;
            }
            return istVerfügbar;
        }
    }
}
