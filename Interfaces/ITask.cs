using TestWork.Enums;
namespace TestWork.Interfaces
{
    public interface ITask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TaskType Type { get; set; }
        public DateTime Created { get; set; }
        public StatusOfTask Status { get; set; }
        public string GetShortInfo();
    }
}
