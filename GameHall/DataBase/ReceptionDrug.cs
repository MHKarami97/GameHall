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
    
    public partial class ReceptionDrug
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
        public Nullable<int> ReceptionID { get; set; }
        public Nullable<byte> RowID { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public Nullable<int> AssistantID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public Nullable<short> DrugCategoryID { get; set; }
        public Nullable<int> DrugsubCategoryID { get; set; }
        public Nullable<int> DrugClassID { get; set; }
        public Nullable<short> DrugTypeID { get; set; }
        public Nullable<int> DrugID { get; set; }
        public Nullable<int> DrugCode { get; set; }
        public Nullable<double> Number { get; set; }
        public Nullable<byte> CountingUnitID { get; set; }
        public string ServDsc { get; set; }
        public string Dsc { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public Nullable<int> cuserid { get; set; }
        public Nullable<int> muserid { get; set; }
    }
}
