//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameHall.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChequeBook
    {
        public short ID { get; set; }
        public Nullable<int> BankID { get; set; }
        public Nullable<short> ChequeBookTypeid { get; set; }
        public Nullable<int> FirstSerial { get; set; }
        public Nullable<byte> PageCount { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public string Dsc { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> Create_Date { get; set; }
        public Nullable<System.DateTime> Modify_Date { get; set; }
        public Nullable<int> Rolid { get; set; }
        public Nullable<int> CUserID { get; set; }
        public Nullable<int> MUserID { get; set; }
    }
}
