using System.Collections;
using System.Collections.Generic;
using System.Linq;
using progectGym.Data;
using progectGym.Models;

namespace progectGym.Services
{
    public class BalanceService
    {
        private ApplicationDbContext _context;

        public BalanceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Balance GetBalance(ApplicationUser user)
        {
            var balance = _context.Users.Find(user.Id).Balance;
            balance.Amount = SumTransactions(balance.Transactions);
            return balance;git 
        }

        private decimal SumTransactions(ICollection<Transaction> transactions, int n = 0)
        {
            if (n == transactions.Count)
            {
                return transactions.ElementAt(n).Amount;
            }

            return transactions.ElementAt(n).Amount + SumTransactions(transactions, n + 1);
        }
    }
}