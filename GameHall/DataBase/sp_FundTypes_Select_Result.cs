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
    
    public partial class sp_FundTypes_Select_Result
    {
        public Nullable<int> FundCategoryID { get; set; }
        public Nullable<int> FundSubCategoryID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public Nullable<int> AssistantID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dsc { get; set; }
        public Nullable<bool> Active { get; set; }
        public string FundCategory_Name { get; set; }
        public string FundSubCategory_Name { get; set; }
    }
}
