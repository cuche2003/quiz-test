using JSQuizTest.Models;
using JSQuizTest.Repositories;

namespace JSQuizTest.Services
{
    public class QuestionService(IQuestionRepository repository) : IQuestionService
    {
        public IEnumerable<Question> GetQuestions()
        {
            return repository.GetQuestions();
        }
        public Question? GetQuestionById(int questionId)
        {
            return repository.GetQuestionById(questionId);
        }
        public void InsertQuestion(Question question)
        {
            repository.InsertQuestion(question);
        }
        public void DeleteQuestion(int questionId)
        {
            repository.DeleteQuestion(questionId);
        }
        public void UpdateQuestion(Question question)
        {
            repository.UpdateQuestion(question);
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
