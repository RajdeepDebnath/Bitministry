//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class BankAccount
    {
        public BankAccount()
        {
            this.Transactions = new HashSet<Transaction>();
        }
    
        public string UserName { get; set; }
    
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}