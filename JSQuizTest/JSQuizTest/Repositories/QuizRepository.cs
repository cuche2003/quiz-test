using JSQuizTest.Data;
using JSQuizTest.Models;
using Microsoft.EntityFrameworkCore;

namespace JSQuizTest.Repositories
{
    public class QuizRepository(ApplicationDbContext db) : IQuizRepository
    {
        public IEnumerable<Quiz> GetQuizzes()
        {
            return [.. db.Quiz];
        }

        public Quiz? GetQuizById(int id)
        {
            return db.Quiz.Find(id);
        }

        public void InsertQuiz(Quiz quiz)
        {
            db.Quiz.Add(quiz);
        }

        public void DeleteQuiz(int id)
        {
            var quiz = db.Quiz.Find(id);
            db.Quiz.Remove(quiz!);
        }
        public void UpdateQuiz(Quiz quiz)
        {
            db.Entry(quiz).State = EntityState.Modified;
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
