//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalFinanceManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Income
    {
        public int IncomeId { get; set; }
        public string Source { get; set; }
        public decimal Amount { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }
        public string Notes { get; set; }
        public string userName { get; set; }
    }
}
