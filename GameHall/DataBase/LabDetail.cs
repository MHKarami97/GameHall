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
    
    public partial class LabDetail
    {
        public int ID { get; set; }
        public int LabID { get; set; }
        public Nullable<int> LabTypeID { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public Nullable<int> AssistantID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public Nullable<System.DateTime> PatientBirthDaye { get; set; }
        public Nullable<short> PatientAge { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<short> LabGroupID { get; set; }
        public Nullable<int> LabSubGroupID { get; set; }
        public Nullable<int> LabTestID { get; set; }
        public Nullable<int> LabResultID { get; set; }
        public Nullable<int> LabUnitID { get; set; }
        public Nullable<int> LabRefrenceRangeID { get; set; }
        public string Dsc { get; set; }
        public Nullable<bool> Archive { get; set; }
        public Nullable<byte> ArchiveStateID { get; set; }
        public Nullable<System.DateTime> ArchiveDate { get; set; }
        public Nullable<int> ArchiveUserID { get; set; }
        public string ArchiveDsc { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public Nullable<int> cuserid { get; set; }
        public Nullable<int> muserid { get; set; }
    }
}
