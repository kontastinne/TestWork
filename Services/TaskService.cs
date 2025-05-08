using TestWork.Interfaces;

namespace TestWork.Services
{
    public class TaskService
    {
        private static readonly List<ITask> _tasks = new();
        public List<ITask> GetAllTasks() => _tasks;
        public void AddTask(ITask task)
        {
            task.Id = _tasks.Count + 1;
            _tasks.Add(task);
        }
        public ITask? GetByMyId(int id) => _tasks.FirstOrDefault(t => t.Id == id);
    }
}
