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
    
    public partial class sp_Customers_Select_Result
    {
        public Nullable<int> CustomerGroupID { get; set; }
        public Nullable<int> CustomerSubGroupID { get; set; }
        public Nullable<short> CustomGroupID { get; set; }
        public int ID { get; set; }
        public Nullable<byte> SexTypeID { get; set; }
        public Nullable<short> JobID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Meli { get; set; }
        public Nullable<int> EmailID { get; set; }
        public Nullable<int> WebSiteID { get; set; }
        public Nullable<int> AddressID { get; set; }
        public Nullable<int> PhoneNumberID1 { get; set; }
        public Nullable<int> PhoneNumberID2 { get; set; }
        public Nullable<int> PhoneNumberID3 { get; set; }
        public Nullable<int> PhoneNumberID4 { get; set; }
        public string SMS { get; set; }
        public Nullable<int> ImageID { get; set; }
        public Nullable<int> IdentificationID { get; set; }
        public Nullable<int> EducationID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public string Dsc { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Del { get; set; }
        public Nullable<bool> Lock { get; set; }
        public Nullable<byte> Star { get; set; }
        public string RFID { get; set; }
        public Nullable<double> Mandeh { get; set; }
        public Nullable<double> ReceptionMandeh { get; set; }
        public Nullable<double> MaxBed { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public Nullable<int> Rolid { get; set; }
        public Nullable<int> cuserid { get; set; }
        public Nullable<int> muserid { get; set; }
        public Nullable<int> PhoneNumberID5 { get; set; }
        public Nullable<int> PhoneNumberID6 { get; set; }
        public string BankCardNo { get; set; }
        public string BankAccNo { get; set; }
        public Nullable<bool> fav { get; set; }
        public string RegisterDate_Shamsi { get; set; }
        public byte[] ImageFile { get; set; }
        public string Customer_FirstAndLastName { get; set; }
        public string CustomerGroup_Name { get; set; }
        public string CustomerSubGroup_Name { get; set; }
        public string CustomGroup_Name { get; set; }
        public string Job_Name { get; set; }
        public string SexType_Name { get; set; }
        public string SpecialSexType_Name { get; set; }
        public string Email { get; set; }
        public Nullable<byte> EmailTypeID { get; set; }
        public string WebSite { get; set; }
        public Nullable<byte> WebSiteTypeID { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public Nullable<byte> AddressTypeID { get; set; }
        public string PhoneNumber1 { get; set; }
        public Nullable<byte> PhoneTypeID1 { get; set; }
        public string PhoneType1_Name { get; set; }
        public string PhoneNumber2 { get; set; }
        public Nullable<byte> PhoneTypeID2 { get; set; }
        public string PhoneType2_Name { get; set; }
        public string PhoneNumber3 { get; set; }
        public Nullable<byte> PhoneTypeID3 { get; set; }
        public string PhoneType3_Name { get; set; }
        public string PhoneNumber4 { get; set; }
        public Nullable<byte> PhoneTypeID4 { get; set; }
        public string PhoneType4_Name { get; set; }
        public string PhoneNumber5 { get; set; }
        public Nullable<byte> PhoneTypeID5 { get; set; }
        public string PhoneType5_Name { get; set; }
        public string PhoneNumber6 { get; set; }
        public Nullable<byte> PhoneTypeID6 { get; set; }
        public string PhoneType6_Name { get; set; }
        public string Shsh { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public string BirthDay_Shamsi { get; set; }
        public string BirthPlace { get; set; }
        public string FatherName { get; set; }
        public Nullable<System.DateTime> MarriageDate { get; set; }
        public string MarriageDate_Shamsi { get; set; }
        public Nullable<byte> MarriageTypeID { get; set; }
        public string Identification_Dsc { get; set; }
        public string MarriageType_Name { get; set; }
        public string EducationType_Name { get; set; }
        public Nullable<short> EducationTypeID { get; set; }
        public string FieldStudy { get; set; }
        public Nullable<System.DateTime> GraduationDate { get; set; }
        public string Education_Dsc { get; set; }
        public string CompanyName { get; set; }
        public string CompanyRegisterCode { get; set; }
        public string CompanyEconomicCode { get; set; }
        public string Profession { get; set; }
        public string AdminName { get; set; }
        public string Secretary { get; set; }
        public string OfficePost { get; set; }
        public string Company_Dsc { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string WebSite1 { get; set; }
        public string WebSite2 { get; set; }
        public string WebSite3 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string PostalCode1 { get; set; }
        public string PostalCode2 { get; set; }
        public string PostalCode3 { get; set; }
        public string General { get; set; }
        public string Home1 { get; set; }
        public string Home2 { get; set; }
        public string Office1 { get; set; }
        public string Office2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Mobile3 { get; set; }
        public string Assistant { get; set; }
        public string Other { get; set; }
        public string State_Name { get; set; }
        public string Region_Name { get; set; }
        public string Alley_Name { get; set; }
        public string CUser_Name { get; set; }
        public string MUser_Name { get; set; }
    }
}
