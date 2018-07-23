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
    
    public partial class Cheque_Received
    {
        public int ID { get; set; }
        public Nullable<int> ChequeTypeID { get; set; }
        public Nullable<int> BankID { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
        public string AccountNumber { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
        public string ChequeNumber { get; set; }
        public Nullable<double> ChequeAmount { get; set; }
        public string Receiver { get; set; }
        public string Dsc { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<byte> ChequeStateID { get; set; }
        public Nullable<int> NoteID { get; set; }
        public Nullable<bool> Archive { get; set; }
        public Nullable<byte> ArchiveStateID { get; set; }
        public Nullable<System.DateTime> ArchiveDate { get; set; }
        public Nullable<int> ArchiveUserID { get; set; }
        public string ArchiveDsc { get; set; }
        public Nullable<System.DateTime> Create_Date { get; set; }
        public Nullable<System.DateTime> Modify_Date { get; set; }
        public Nullable<int> Rolid { get; set; }
        public Nullable<int> CUserID { get; set; }
        public Nullable<int> MUserID { get; set; }
        public Nullable<int> ImageID1 { get; set; }
        public Nullable<int> ImageID2 { get; set; }
        public Nullable<int> ImageID3 { get; set; }
        public Nullable<int> ImageID4 { get; set; }
    }
}
