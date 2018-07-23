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
    
    public partial class sp_Cheque_Received_SelectRow_Result
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
        public string Customer_FullName { get; set; }
        public string Customer_FirstName { get; set; }
        public string Customer_LastName { get; set; }
        public string Customer_Meli { get; set; }
        public string Customer_Email { get; set; }
        public string Customer_WebSite { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_PhoneNumber1 { get; set; }
        public Nullable<byte> Customer_PhoneTypeID1 { get; set; }
        public string Customer_PhoneType1_Name { get; set; }
        public string Customer_PhoneNumber2 { get; set; }
        public Nullable<byte> Customer_PhoneTypeID2 { get; set; }
        public string Customer_PhoneType2_Name { get; set; }
        public string Customer_PhoneNumber3 { get; set; }
        public Nullable<byte> Customer_PhoneTypeID3 { get; set; }
        public string Customer_PhoneType3_Name { get; set; }
        public string Customer_PhoneNumber4 { get; set; }
        public Nullable<byte> Customer_PhoneTypeID4 { get; set; }
        public string Customer_PhoneType4_Name { get; set; }
        public string Customer_Shsh { get; set; }
        public Nullable<System.DateTime> Customer_BirthDay { get; set; }
        public string Customer_BirthPlace { get; set; }
        public string Customer_FatherName { get; set; }
        public string ChequeState_Name { get; set; }
        public string Bank_BankName { get; set; }
        public string Bank_BankBranch { get; set; }
        public string Bank_AccountNumber { get; set; }
        public string Bank_Dsc { get; set; }
        public string Bank_Tel { get; set; }
        public string Bank_Info { get; set; }
        public string CUser_Name { get; set; }
        public string MUser_Name { get; set; }
        public string ArchiveUser_Name { get; set; }
    }
}
