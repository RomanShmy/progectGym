using System.Collections;
using System.Collections.Generic;

namespace progectGym.Models
{
    public class Balance
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}