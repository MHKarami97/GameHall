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
    
    public partial class sp_CRMResults_Select_Result
    {
        public string CRMResultCategory_Name { get; set; }
        public string CRMResultSubCategory_Name { get; set; }
        public Nullable<short> CRMResultCategoryID { get; set; }
        public Nullable<int> CRMResultSubCategoryID { get; set; }
        public short ID { get; set; }
        public string Name { get; set; }
        public string Dsc { get; set; }
        public Nullable<bool> SendSMS { get; set; }
        public string SMSMessage { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
