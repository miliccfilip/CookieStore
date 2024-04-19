using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.BusinessInterface
{
    public interface IStuffBusiness
    {
        bool InsertStuff(Stuff s);
        List<Stuff> GetAllStuffs();
        bool DeleteStuff(int idSelected);
        bool UpdateStuff(Stuff s);
        Stuff GetSelectedStuff(int idSelected);

        int GetStuffNewId();
    }
}
