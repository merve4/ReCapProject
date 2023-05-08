using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Utilities.Results
{
    //IDataResult: datayı-sonuçları ve mesajları barındırır
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
