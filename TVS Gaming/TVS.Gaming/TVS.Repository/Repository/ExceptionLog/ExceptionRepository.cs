﻿using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Repository.Repository.Generic;

namespace TVS.Repository.Repository.ExceptionLog
{
    public class ExceptionRepository: GenericRepository<Data.Models.LogException> , IExceptionRepository
    {

    }
}
