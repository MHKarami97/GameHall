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
    
    public partial class Visit
    {
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<int> VisitCategoryID { get; set; }
        public Nullable<int> VisitSubCategoryID { get; set; }
        public Nullable<int> DiagnosisID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> BodyID { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public string Dsc { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> AutoSelect { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public Nullable<int> cuserid { get; set; }
        public Nullable<int> muserid { get; set; }
        public Nullable<bool> Del { get; set; }
        public Nullable<bool> Lock { get; set; }
    }
}
