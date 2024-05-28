using JSQuizTest.Data;
using JSQuizTest.Models;
using Microsoft.EntityFrameworkCore;

namespace JSQuizTest.Repositories
{
    public class QuestionRepository(ApplicationDbContext db) : IQuestionRepository
    {
        public IEnumerable<Question> GetQuestions()
        {
            return [.. db.Question];
        }

        public Question? GetQuestionById(int id)
        {
            return db.Question.Find(id);
        }

        public void InsertQuestion(Question question)
        {
            db.Question.Add(question);
        }

        public void DeleteQuestion(int id)
        {
            var question = db.Question.Find(id);
            db.Question.Remove(question!);
        }
        public void UpdateQuestion(Question question)
        {
            db.Entry(question).State = EntityState.Modified;
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
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
