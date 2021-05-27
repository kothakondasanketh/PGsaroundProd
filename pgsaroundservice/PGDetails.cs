using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookPG_Service
{
    public class PGDetails
    {
       public string UserID{get;set;}
        public string PGAddress{get;set;}
        public string PGName{get;set;}
        public  string PGPhno{get;set;}
        public int Avialability{get;set;}
        public int CostPerDay{get;set;}
        public int CostPerMonth{get;set;}
        public string Area{get;set;}
        public string City{get;set;}
        public string State{get;set;}
        public string Country{get;set;}
        public string ConfirmationStas { get; set; }
        public List<Confirmation> ConfirmationLst { get; set; }

        public string AC{get;set;}
        public string NonAC{get;set;}
        public string NIFood{get;set;}
        public string SIFood{get;set;}
        public string Internet{get;set;}
        public string TV{get;set;}
        public string Hotwater{get;set;}
        public string Food3times{get;set;}
        public string NoFood{get;set;}
        public string Parkingspace{get;set;}
        public string Laundry{get;set;}
        public string Pgprofilepic{get;set;}
        public string Pgimg1{get;set;}
        public string Pgimg2{get;set;}
        public string Pgimg3{get;set;}
        public string Pgimg4{get;set;}
        public string Pgimg5{get;set;}
  
      }

    public class Confirmation
    {
        public string CornformationStatus{get;set;}
        public int CornformationStatusID{get;set;}

        
    }
}