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
    
    public partial class Order
    {
        public int ID { get; set; }
        public Nullable<short> DayID { get; set; }
        public string Recever { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string Customer_ContactName { get; set; }
        public string Customer_General { get; set; }
        public string Customer_HomeAddress { get; set; }
        public Nullable<int> DriverID { get; set; }
        public Nullable<int> CarID { get; set; }
        public Nullable<int> DeskID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<double> Takh { get; set; }
        public Nullable<double> Bed { get; set; }
        public Nullable<double> Bes { get; set; }
        public Nullable<byte> PaymentStateID { get; set; }
        public string Dsc { get; set; }
        public Nullable<System.DateTime> Create_Date { get; set; }
        public Nullable<System.DateTime> Modify_Date { get; set; }
        public Nullable<int> Rolid { get; set; }
        public Nullable<int> CUserID { get; set; }
        public Nullable<int> MUserID { get; set; }
    }
}
