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
    
    public partial class sp_Cars_Select_Result
    {
        public int ID { get; set; }
        public Nullable<int> DriverID { get; set; }
        public string Name { get; set; }
        public string CarClass { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Plak { get; set; }
        public string Bimeh { get; set; }
        public string LandLord { get; set; }
        public string Country { get; set; }
        public Nullable<int> ImageID1 { get; set; }
        public Nullable<int> ImageID2 { get; set; }
        public Nullable<int> ImageID3 { get; set; }
        public string Dsc { get; set; }
        public Nullable<System.DateTime> Create_Date { get; set; }
        public Nullable<System.DateTime> Modify_Date { get; set; }
        public Nullable<int> CUserID { get; set; }
        public Nullable<int> MUserID { get; set; }
        public byte[] imageFile { get; set; }
        public string Driver_Name { get; set; }
        public string Driver_FatherName { get; set; }
        public string Driver_Shsh { get; set; }
        public string Driver_General { get; set; }
        public string Driver_Home { get; set; }
        public string Driver_Mobile { get; set; }
        public string Driver_HomeAddress { get; set; }
        public string Driver_Email { get; set; }
        public Nullable<System.DateTime> Driver_BirthDay { get; set; }
        public string Driver_BirthPlace { get; set; }
        public Nullable<System.DateTime> Driver_CertificateExp { get; set; }
        public string Driver_Meli { get; set; }
        public string CUser_Name { get; set; }
        public string MUser_Name { get; set; }
    }
}
