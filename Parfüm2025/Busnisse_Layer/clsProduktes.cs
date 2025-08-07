
using System;
using System.Data;
using ParfümDb_DataLayer;
namespace ParfümDb_BusinessLayer
{
    public class clsProduktes
    {
        //#nullable enable

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? ProduktID { get; set; }
        public string ProduktName { get; set; }
        public int? GekaufteMenge { get; set; }
        public int? GelieferteMenge { get; set; }
        public bool? HauptGeschäft { get; set; }
        public bool? DezGeschäft { get; set; }
        public int? Total { get; set; }


        public clsProduktes()
        {
            this.ProduktID = null;
            this.ProduktName = "";
            this.GekaufteMenge = 0;
            this.GelieferteMenge = 0;
            this.HauptGeschäft = false;
            this.DezGeschäft = false;
            this.Total = 0;
            Mode = enMode.AddNew;
        }


        private clsProduktes(
int? ProduktID, string ProduktName, int? GekaufteMenge, int? GelieferteMenge, bool? HauptGeschäft, bool? DezGeschäft, int? Total)        {
            this.ProduktID = ProduktID;
            this.ProduktName = ProduktName;
            this.GekaufteMenge = GekaufteMenge;
            this.GelieferteMenge = GelieferteMenge;
            this.HauptGeschäft = HauptGeschäft;
            this.DezGeschäft = DezGeschäft;
            this.Total = Total;
            Mode = enMode.Update;
        }


       private bool _AddNewProduktes()
       {
        this.ProduktID = clsProduktesData.AddNewProduktes(
this.ProduktName, this.GekaufteMenge, this.GelieferteMenge, this.HauptGeschäft, this.DezGeschäft, this.Total);
        return (this.ProduktID != null);
       }


       public static bool AddNewProduktes(
ref int? ProduktID, string ProduktName, int? GekaufteMenge, int? GelieferteMenge, bool? HauptGeschäft, bool? DezGeschäft, int? Total)        {
        ProduktID = clsProduktesData.AddNewProduktes(
ProduktName, GekaufteMenge, GelieferteMenge, HauptGeschäft, DezGeschäft, Total);

        return (ProduktID != null);

       }


       private bool _UpdateProduktes()
       {
        return clsProduktesData.UpdateProduktesByID(
this.ProduktID, this.ProduktName, this.GekaufteMenge, this.GelieferteMenge, this.HauptGeschäft, this.DezGeschäft, this.Total);
       }


       public static bool UpdateProduktesByID(
int? ProduktID, string ProduktName, int? GekaufteMenge, int? GelieferteMenge, bool? HauptGeschäft, bool? DezGeschäft, int? Total)        {
        return clsProduktesData.UpdateProduktesByID(
ProduktID, ProduktName, GekaufteMenge, GelieferteMenge, HauptGeschäft, DezGeschäft, Total);

        }


       public static clsProduktes FindByProduktID(int? ProduktID)

        {
            if (ProduktID == null)
            {
                return null;
            }
            string ProduktName = "";
            int? GekaufteMenge = 0;
            int? GelieferteMenge = 0;
            bool? HauptGeschäft = false;
            bool? DezGeschäft = false;
            int? Total = 0;
            bool IsFound = clsProduktesData.GetProduktesInfoByID(ProduktID,
 ref ProduktName,  ref GekaufteMenge,  ref GelieferteMenge,  ref HauptGeschäft,  ref DezGeschäft,  ref Total);

           if (IsFound)
               return new clsProduktes(
ProduktID, ProduktName, GekaufteMenge, GelieferteMenge, HauptGeschäft, DezGeschäft, Total);
            else
                return null;
            }


       public static DataTable GetAllProduktes()
       {

        return clsProduktesData.GetAllProduktes();

       }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewProduktes())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateProduktes();

            }
        
            return false;
        }



       public static bool DeleteProduktes(int ProduktID)
       {

        return clsProduktesData.DeleteProduktes(ProduktID);

       }


        public enum ProduktesColumn
         {
            ProduktID,
            ProduktName,
            GekaufteMenge,
            GelieferteMenge,
            HauptGeschäft,
            DezGeschäft,
            Total
         }


        public enum SearchMode
        {
            Anywhere,
            StartsWith,
            EndsWith,
            ExactMatch
        }
    

        public static DataTable SearchData(ProduktesColumn ChosenColumn, string SearchValue, SearchMode Mode = SearchMode.Anywhere)
        {
            if (string.IsNullOrWhiteSpace(SearchValue))
                return new DataTable();

            string modeValue = Mode.ToString(); // Get the mode as string for passing to the stored procedure

            return clsProduktesData.SearchData(ChosenColumn.ToString(), SearchValue, modeValue);
        }        
    }
}
