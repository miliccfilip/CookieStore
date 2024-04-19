using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataInterface
{
    public interface IBillItemRepository
    {
         List<BillItem> GetAllBillItems();
         int InsertBillItem(BillItem bi);
         int UpdateBillItem(BillItem bi);
         int DeleteBillItem(int billId, int articleId);
    }
}
