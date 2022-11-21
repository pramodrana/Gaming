using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TVS.Model.Models
{
    public class Response
    {
        public Response()
        {
        }

        /// Response class constructor
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="result"></param>
        /// <param name="message"></param>
        /// <param name="responseData"></param>
        public Response(HttpStatusCode statusCode, string result = null, string message = null)
        {
            StatusCode = (int)statusCode;
            Result = result;
            Message = message;
            //Data = responseData;

        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Result { get; set; }
        //public object Data { get; set; }

    }
}
