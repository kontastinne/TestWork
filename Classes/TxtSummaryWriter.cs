using System.Text;
using TestWork.Interfaces;
namespace TestWork.Classes
{
    public class TxtSummaryWriter : ISummaryWriter
    {
        public string Write(List<ITask> tasks)
        {
            var grouped = tasks.GroupBy(t => t.GetType().Name);
            var builder = new StringBuilder();

            builder.AppendLine("Сводка задач");
            builder.AppendLine("============");

            foreach (var group in grouped)
            {
                builder.AppendLine($"{group.Key}: {group.Count()}");
            }

            var fileName = "summary.txt";
            var filePath = Path.Combine("wwwroot", "summaries", fileName);

            Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);
            File.WriteAllText(filePath, builder.ToString(), Encoding.UTF8);

            // Возвращаем относительный путь для ссылки/перехода
            return $"/summaries/{fileName}";
        }
    }
}
