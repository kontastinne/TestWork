using System.Diagnostics.Contracts;
using System.Text;
using TestWork.Interfaces;
namespace TestWork.Classes
{
    public class HtmlSummaryWriter : ISummaryWriter
    {
        public string Write(List<ITask> tasks)
        {
            var grouped = tasks.GroupBy(t => t.Type);
            var builder = new StringBuilder();
            builder.AppendLine("<!DOCTYPE html>");
            builder.AppendLine("<html><head><meta charset='utf-8'><title>Сводка задач</title></head><body>");
            builder.AppendLine("<h1>Сводка задач</h1>");
            foreach(var group in grouped)
            {
                builder.AppendLine($"<p><strong>{group.Key}:  </strong>{group.Count()}</p>");
            }
            builder.AppendLine("</body></html>");
            var filePath = Path.Combine("wwwroot", "summaries", "summary.html");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, builder.ToString());


            return "/summaries/summary.html";
        }
    }
}
