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
    
    public partial class Desk
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dsc { get; set; }
        public Nullable<byte> DeskStateID { get; set; }
        public Nullable<int> InventoryHeaderID { get; set; }
    }
}
