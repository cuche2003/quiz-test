using JSQuizTest.Models;

namespace JSQuizTest.Services
{
    public interface IQuizService : IDisposable
    {
        public IEnumerable<Quiz> GetQuizzes();
        public Quiz? GetQuizById(int quizId);
        public void InsertQuiz(Quiz quiz);
        public void DeleteQuiz(int quizId);
        public void UpdateQuiz(Quiz quiz);
        public void Save();
        public Task SaveAsync();
    }
}
