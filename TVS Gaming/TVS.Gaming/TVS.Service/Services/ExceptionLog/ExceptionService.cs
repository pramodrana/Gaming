using log4net.Core;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Common.Constant;
using TVS.Common.Exception;
using TVS.Common.Logging;
using TVS.Common.Resources;
using TVS.Repository.Repository.ExceptionLog;
using TVS.Repository.Repository.Generic;

namespace TVS.Service.Services.ExceptionLog
{
    public class ExceptionService : IExceptionService
    {
        #region Private Variables
        private readonly IExceptionRepository _exceptionRepository;
        #endregion

        #region Conctructor
        public ExceptionService(IExceptionRepository exceptionRepository)
        {
            this._exceptionRepository = exceptionRepository;
        }
        #endregion


        /// <summary>
        /// Insert Log Exception
        /// </summary>
        /// <param name="errMsg"></param>
        /// <param name="stackTrace"></param>
        /// <param name="pageName"></param>
        /// <param name="methodName"></param>
        /// <param name="extra1"></param>
        /// <param name="extra2"></param>
        /// <param name="extra3"></param>
        /// <param name="moduleName"></param>
        /// <param name="sourceSystem"></param>
        /// <returns></returns>
        public async Task<Data.Models.LogException> InsertLogException(string errMsg, string stackTrace, string pageName,
         string methodName, string extra1, string moduleName, string sourceSystem)
        {
            try
            {
                if (string.IsNullOrEmpty(errMsg) && string.IsNullOrEmpty(stackTrace) && string.IsNullOrEmpty(pageName) || string.IsNullOrEmpty(methodName) || string.IsNullOrEmpty(moduleName) || string.IsNullOrEmpty(sourceSystem))
                {
                    Data.Models.LogException logException = new()
                    {
                        ErrorMessage = errMsg,
                        StackTrace = stackTrace,
                        PageName = pageName,
                        MethodName = methodName,
                        Extra1 = extra1,
                        //logException.Extra2 = extra2;
                        //logException.Extra3 = extra3;
                        Modulename = moduleName,
                        SourceSystem = sourceSystem
                    };
                    await _exceptionRepository.Insert(logException);
                    await _exceptionRepository.Save();
                    return logException;
                }
                else
                {
                    throw new ArgumentException(Constants.INVALID_ARGS);
                }  
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new CustomException(ResourceManager.GetResource(Constants.DB_SAVE_ERROR));
            }            
        }
    }
}
