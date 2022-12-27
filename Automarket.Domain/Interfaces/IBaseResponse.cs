using System;
using System.Collections.Generic;
using System.Text;

namespace Automarket.Domain.Interfaces
{
    public interface IBaseResponse<T>
    {
        T Data { get; set; }
    }
}
