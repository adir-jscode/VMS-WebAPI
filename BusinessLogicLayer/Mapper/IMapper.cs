using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Mapper
{
    public interface IMapper<S,D>
    {
        S Map(D obj);
        D Map(S obj);
        List<D> Map(List<S> obj);
    }
}
