using TestWork.Interfaces;
using TestWork.Enums;
namespace TestWork.Classes
{
    public class BugTask : ITask
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public TaskType Type { get; set; }
        public DateTime Created { get; set; }
        public StatusOfTask Status { get; set; }
        public string GetShortInfo()
        {
            return $"[BUG] {Title} (создано {Created:dd.MM.yyyy} статус: {Status})";
        }
    }
}
