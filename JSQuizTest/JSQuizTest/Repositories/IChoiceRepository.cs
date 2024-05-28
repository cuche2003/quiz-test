using JSQuizTest.Models;

namespace JSQuizTest.Repositories
{
    public interface IChoiceRepository : IDisposable
    {
        public IEnumerable<Choice> GetChoices();
        public Choice? GetChoiceById(int ChoiceId);
        public void InsertChoice(Choice Choice);
        public void DeleteChoice(int ChoiceId);
        public void UpdateChoice(Choice Choice);
        public IEnumerable<Choice> GetChoicesByQuestionId(int QuestionId);
        public void Save();
        public Task SaveAsync();
    }
}
