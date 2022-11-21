using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS.Repository.Repository.GameAnswer
{
    public interface IGameAnswerRepository
    {
        List<Data.Models.GameAnswer> GetGameAnswersByQuestionId(int questionid);
    }
}
