using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Domain.Types
{
    public class CustomHttpException : Exception
    {
        public int StatusCode { get; set; }
        public new string Message { get; set; }
        public CustomHttpException(HttpStatusCode httpStatusCode, string ResponseMessage)
        {
            StatusCode = (int)httpStatusCode;
            Message = ResponseMessage;
        }
    }
}
