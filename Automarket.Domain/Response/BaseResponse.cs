using Automarket.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automarket.Domain.Response
{
    /// <summary>
    /// Классы которые выступают в качестве возвращяемых объектов для сервисов
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public string Descriprion { get; set; } // название ошибки если она случится

        public StatusCode StatusCode { get; set; } // код ошибки, если она будет

        public T Data { get; set; } // 
    }
}
