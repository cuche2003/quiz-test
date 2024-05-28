using JSQuizTest.Models;
using JSQuizTest.Repositories;

namespace JSQuizTest.Services
{
    public class ChoiceService(IChoiceRepository repository) : IChoiceService
    {
        public IEnumerable<Choice> GetChoices()
        {
            return repository.GetChoices();
        }
        public Choice? GetChoiceById(int choiceId)
        {
            return repository.GetChoiceById(choiceId);
        }
        public void InsertChoice(Choice choice)
        {
            repository.InsertChoice(choice);
        }
        public void DeleteChoice(int choiceId)
        {
            repository.DeleteChoice(choiceId);
        }
        public void UpdateChoice(Choice choice)
        {
            repository.UpdateChoice(choice);
        }
        public IEnumerable<Choice> GetChoicesByQuestionId(int questionId)
        {
            return repository.GetChoicesByQuestionId(questionId);
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
