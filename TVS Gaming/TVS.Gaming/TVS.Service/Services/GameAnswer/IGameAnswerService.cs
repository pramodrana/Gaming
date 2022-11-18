namespace TVS.ApiService.Service.GameAnswer
{
    public interface IGameAnswerService
    {
        Task<List<Data.Models.GameAnswer>> GetAnswersByQuestionId(int questionId);
    }
}
