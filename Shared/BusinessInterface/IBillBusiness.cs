using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.BusinessInterface
{
    public interface IBillBusiness
    {
         bool InsertBill(Bill b);
         List<Bill> GetAllBills();
         bool DeleteBill(int idSelected);
         bool UpdateBill(Bill b);
         int GetNewBillId();
    }
}
