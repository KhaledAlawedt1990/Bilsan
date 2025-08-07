
using System;
using System.Data;
using Busnisse_Layer;
using ParfümDb_DataLayer;

namespace ParfümDb_BusinessLayer
{
    public class clsDetails
    {
        

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

              public int? DetailsID { get; set; }
        public int ParfümNummer { get; set; }
        public string Beschreibung { get; set; }
        public clsParfüm ParfümInfo { get; set; }

        public clsDetails()
        {
            this.DetailsID = null;
            this.DetailsID = null;
            this.ParfümNummer = 0;
            this.Beschreibung = null;
            Mode = enMode.AddNew;
        }


        private clsDetails(
int? DetailsID,int ParfümNummer, string Beschreibung          )
        {
            this.DetailsID = DetailsID;
            this.ParfümNummer = ParfümNummer;
            this.ParfümInfo = clsParfüm.FindByParfümNummer(this.ParfümNummer);
            this.Beschreibung = Beschreibung;
            Mode = enMode.Update;
        }


       private bool _AddNewDetails()
       {
        this.DetailsID = clsDetailsData.AddNewDetails(
this.ParfümNummer, this.Beschreibung);

            return (this.DetailsID != null);

       }


       public static bool AddNewDetails(
ref int? DetailsID,int ParfümNummer, string Beschreibung)
        {
        DetailsID = clsDetailsData.AddNewDetails(
ParfümNummer, Beschreibung);

            return (DetailsID != null);

       }


       private bool _UpdateDetails()
       {
        return clsDetailsData.UpdateDetailsByID(
this.DetailsID, this.ParfümNummer, this.Beschreibung       );
       }


       public static bool UpdateDetailsByID(
int? DetailsID,int ParfümNummer, string Beschreibung          )
        {
        return clsDetailsData.UpdateDetailsByID(
DetailsID, ParfümNummer, Beschreibung);

        }


       public static clsDetails FindByDetailsID(int? DetailsID)

        {
            if (DetailsID == null)
            {
                return null;
            }
            int ParfümNummer = 0;
            string Beschreibung = null;
            bool IsFound = clsDetailsData.GetDetailsInfoByID(DetailsID,
 ref ParfümNummer,  ref Beschreibung);

           if(IsFound)
               return new clsDetails(
 DetailsID,  ParfümNummer,  Beschreibung);
            else
                return  null;
        }

        public static clsDetails FindByParfümID(int ParfümNummer)

        {
            int? DetailsID = 0;
            string Beschreibung = null;
            bool IsFound = clsDetailsData.GetDetailsInfoByParfümNummer( ref DetailsID,
  ParfümNummer, ref Beschreibung);

            if (IsFound)
                return new clsDetails(
  DetailsID, ParfümNummer, Beschreibung);
            else
                return null;
        }


        public static DataTable GetAllDetails()
       {

        return clsDetailsData.GetAllDetails();

       }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewDetails())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateDetails();

            }
        
            return false;
        }



       public static bool DeleteDetails(int DetailsID)
       {

        return clsDetailsData.DeleteDetails(DetailsID);

       }


        public enum enDetailsColumns
         {
            DetailsID,
            ParfümNummer,
            Beschreibung
         }


        //public static DataTable SearchData(enDetailsColumns enChose, string Data)
        //{
        //    if(!SqlHelper.IsSafeInput(Data))
        //        return null;
            
        //    return clsDetailsData.SearchData(enChose.ToString(), Data);

        //}        



    }
}
