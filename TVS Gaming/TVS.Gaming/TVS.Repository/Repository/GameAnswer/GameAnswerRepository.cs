using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Common.Constant;
using TVS.Common.Logging;
using TVS.Common.Resources;
using TVS.Repository.Repository.Generic;

namespace TVS.Repository.Repository.GameAnswer
{
    public class GameAnswerRepository :GenericRepository<Data.Models.GameAnswer>, IGameAnswerRepository
    {
        public List<Data.Models.GameAnswer> GetGameAnswersByQuestionId(int questionid)
        {
            try
            {
                if (questionid > 0)
                {
                    return  _tvsDbContext.GameAnswers.Where(x => x.QuestionId == questionid).ToList();
                }
                else
                {
                    throw new ArgumentException(Constants.INVALID_ARGS);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new Common.Exception.CustomException(ResourceManager.GetResource(Constants.DB_ERROR));
            }
            
        }
    }
}
