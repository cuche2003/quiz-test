using JSQuizTest.Models;
using JSQuizTest.Repositories;

namespace JSQuizTest.Services
{
    public class QuizService(IQuizRepository repository) : IQuizService
    {
        public IEnumerable<Quiz> GetQuizzes()
        {
            return repository.GetQuizzes();
        }
        public Quiz? GetQuizById(int quizId)
        {
            return repository.GetQuizById(quizId);
        }
        public void InsertQuiz(Quiz quiz)
        {
            repository.InsertQuiz(quiz);
        }
        public void DeleteQuiz(int quizId)
        {
            repository.DeleteQuiz(quizId);
        }
        public void UpdateQuiz(Quiz quiz)
        {
            repository.UpdateQuiz(quiz);
        }
        public void Save()
        {
            repository.Save();
        }
        public async Task SaveAsync()
        {
            await repository.SaveAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    repository.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
