using JSQuizTest.Models;

namespace JSQuizTest.Services
{
    public interface IQuestionService : IDisposable
    {
        public IEnumerable<Question> GetQuestions();
        public Question? GetQuestionById(int questionId);
        public void InsertQuestion(Question question);
        public void DeleteQuestion(int questionId);
        public void UpdateQuestion(Question question);
        public void Save();
        public Task SaveAsync();
    }
}
