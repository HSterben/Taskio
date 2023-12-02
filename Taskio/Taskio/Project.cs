using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Taskio
{
    internal class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public string Category { get; set; }
    }

    internal class Project
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
        public double CompletionPercentage { get; private set; }
        private string _filePath;

        public Project(string filePath)
        {
            _filePath = filePath;
            Name = Path.GetFileNameWithoutExtension(filePath);
            Tasks = new List<Task>();
            UpdateCompletionPercentage();
        }

        public Project()
        {
            Tasks = new List<Task>();
            UpdateCompletionPercentage();
        }

        public void CreateJSONFile(string directoryPath, string fileName)
        {
            _filePath = Path.Combine(directoryPath, fileName);
            Name = Path.GetFileNameWithoutExtension(fileName);
            var projectData = new ProjectData { Project = new ProjectContainer { Name = this.Name, Tasks = new List<Task>() } };
            string json = JsonConvert.SerializeObject(projectData, Formatting.Indented);
            File.WriteAllText(_filePath, json);
            UpdateCompletionPercentage();
        }

        public void LoadProject()
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                var projectData = JsonConvert.DeserializeObject<ProjectData>(json);
                if (projectData?.Project != null)
                {
                    this.Name = projectData.Project.Name;
                    this.Tasks = projectData.Project.Tasks;
                }
                else
                {
                    Tasks = new List<Task>();
                }
                UpdateCompletionPercentage();
            }
        }

        public void SaveTasks()
        {
            var projectData = new ProjectData { Project = new ProjectContainer { Name = this.Name, Tasks = this.Tasks } };
            string json = JsonConvert.SerializeObject(projectData, Formatting.Indented);
            File.WriteAllText(_filePath, json);
            UpdateCompletionPercentage();
        }

        public void DeleteTask(Task t)
        {
            Tasks.RemoveAll(task => task.Name == t.Name && task.Description == t.Description && task.Priority == t.Priority && task.Category == t.Category);
            SaveTasks();
            UpdateCompletionPercentage();
        }

        private void UpdateCompletionPercentage()
        {
            if (Tasks == null || !Tasks.Any())
            {
                CompletionPercentage = 0;
            }
            else
            {
                int totalTasks = Tasks.Count;
                int completedTasks = Tasks.Count(task => task.Category == "Done");
                CompletionPercentage = (double)completedTasks / totalTasks * 100;
            }
        }
    }

    internal class ProjectData
    {
        public ProjectContainer Project { get; set; }
    }

    internal class ProjectContainer
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
