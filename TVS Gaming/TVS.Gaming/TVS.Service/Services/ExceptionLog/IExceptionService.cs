using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS.Service.Services.ExceptionLog
{
    public interface IExceptionService
    {
        Task<Data.Models.LogException> InsertLogException(string errMsg, string stackTrace, string pageName,
          string methodName, string extra1, string moduleName, string sourceSystem);
    }
}
