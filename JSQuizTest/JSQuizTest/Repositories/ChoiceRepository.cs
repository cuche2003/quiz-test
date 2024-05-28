using JSQuizTest.Data;
using JSQuizTest.Models;
using Microsoft.EntityFrameworkCore;

namespace JSQuizTest.Repositories
{
    public class ChoiceRepository(ApplicationDbContext db) : IChoiceRepository
    {
        public IEnumerable<Choice> GetChoices()
        {
            return [.. db.Choice];
        }

        public Choice? GetChoiceById(int id)
        {
            return db.Choice.Find(id);
        }

        public void InsertChoice(Choice choice)
        {
            db.Choice.Add(choice);
        }

        public void DeleteChoice(int id)
        {
            var choice = db.Choice.Find(id);
            db.Choice.Remove(choice!);
        }
        public void UpdateChoice(Choice choice)
        {
            db.Entry(choice).State = EntityState.Modified;
        }

        public IEnumerable<Choice> GetChoicesByQuestionId(int questionId)
        {
            return db.Choice.Where(c => c.QuestionId == questionId);
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
