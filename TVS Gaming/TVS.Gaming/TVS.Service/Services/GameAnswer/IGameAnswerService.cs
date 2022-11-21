namespace TVS.ApiService.Service.GameAnswer
{
    public interface IGameAnswerService
    {
        List<Data.Models.GameAnswer> GetAnswersByQuestionId(int questionId);
    }
}
