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
    
    public partial class sp_PatientDiseaseHistories_Select_Result
    {
        public short ID { get; set; }
        public Nullable<short> DepartmentID { get; set; }
        public string Name { get; set; }
        public string Dsc { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> IsChecked { get; set; }
        public string Disease_Dsc { get; set; }
        public string Disease_Name_DSC { get; set; }
    }
}
