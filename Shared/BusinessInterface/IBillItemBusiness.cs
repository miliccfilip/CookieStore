using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.BusinessInterface
{
    public interface IBillItemBusiness
    {
         bool InsertBillItem(BillItem b);
         List<BillItem> GetAllBillItems();
        bool DeleteBillItem(int idBill, int idArticle);
         bool UpdateBillItem(BillItem b);
    }
}
