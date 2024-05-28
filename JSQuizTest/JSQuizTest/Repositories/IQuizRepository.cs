using JSQuizTest.Models;

namespace JSQuizTest.Repositories
{
    public interface IQuizRepository : IDisposable
    {
        public IEnumerable<Quiz> GetQuizzes();
        public Quiz? GetQuizById(int QuizId);
        public void InsertQuiz(Quiz Quiz);
        public void DeleteQuiz(int QuizId);
        public void UpdateQuiz(Quiz Quiz);
        public void Save();
        public Task SaveAsync();
    }
}
