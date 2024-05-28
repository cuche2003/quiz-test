using JSQuizTest.Models;

namespace JSQuizTest.Services
{
    public interface IChoiceService : IDisposable
    {
        public IEnumerable<Choice> GetChoices();
        public Choice? GetChoiceById(int choiceId);
        public void InsertChoice(Choice choice);
        public void DeleteChoice(int choiceId);
        public void UpdateChoice(Choice choice);
        public IEnumerable<Choice> GetChoicesByQuestionId(int questionId);
        public void Save();
        public Task SaveAsync();
    }
}
