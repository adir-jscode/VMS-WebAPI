using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IRepo<Type,ID,RET>
    {
        RET Create(Type obj);
        List<Type> GetAll();
        Type GetById(ID id);
        RET Update(Type obj);

        bool Delete(ID id);
        Type Search(string name);
        List<Type> Filter(string keyword);

    }
}
