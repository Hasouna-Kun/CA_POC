using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Domain.Types
{
    public class ResultOfAction<T>  where T : class
    {
        public ResultOfAction(HttpStatusCode statusCode, string responseMessage, T data)
        {
            StatusCode = (int)statusCode;
            Message = responseMessage;
            Data = data;
        }
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
