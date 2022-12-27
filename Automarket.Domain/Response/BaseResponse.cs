using Automarket.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automarket.Domain.Response
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public string Descroprion { get; set; }

        public StatusCode StatusCode { get; set; }

        public T Data { get; set; }
    }
}
