using Automarket.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automarket.Domain.Interfaces
{
    public interface IBaseResponse<T>
    {
        string Descriprion { get; set; } // название ошибки если она случится

        StatusCode StatusCode { get; set; }

        T Data { get; set; }

    }
}
