//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Khronos_PMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log
    {
        public int ID { get; set; }
        public string TableID { get; set; }
        public System.DateTime Date { get; set; }
        public string Params { get; set; }
        public string OperationID { get; set; }
        public int UserID { get; set; }
    
        public virtual User User { get; set; }
    }
}