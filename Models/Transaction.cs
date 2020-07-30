using System;

namespace progectGym.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        
        public int BalanceId { get; set; }
        public Balance Balance { get; set; }
    }
}