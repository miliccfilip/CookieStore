using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataInterface
{
    public interface IBillRepository
    {
         List<Bill> GetAllBills();
         int InsertBill(Bill b);
         int UpdateBill(Bill b);
         int DeleteBill(int id);
         int GetNewBillId();
    }
}
