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
    
    public partial class sp_DrugClasses_SelectRow_Result
    {
        public int ID { get; set; }
        public Nullable<short> DrugCategoryID { get; set; }
        public Nullable<int> DrugSubCategoryID { get; set; }
        public string Name { get; set; }
        public string Dsc { get; set; }
        public byte[] ICon { get; set; }
        public Nullable<bool> Active { get; set; }
        public string DrugCategory_Name { get; set; }
        public string DrugSubCategory_Name { get; set; }
    }
}
