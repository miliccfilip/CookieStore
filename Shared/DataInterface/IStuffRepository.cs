using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataInterface
{
    public interface IStuffRepository
    {
         List<Stuff> GetAllStuffs();
         int InsertStuff(Stuff s);
         int UpdateStuff(Stuff s);
         int DeleteStuff(int id);
         int GetStuffNewId();
    }
}
