using System;
using System.Collections.Generic;

class Task
{
    public int TaskId { get; set; }
    public string Description { get; set; }
}

class TaskManager
{
    private List<Task> taskList = new List<Task>();

    public void AddTask(Task newTask)
    {
        taskList.Add(newTask);
    }

    public void RemoveTask(int taskId)
    {
        Task taskToRemove = taskList.Find(task => task.TaskId == taskId);
        if (taskToRemove != null)
        {
            taskList.Remove(taskToRemove);
            Console.WriteLine($"Завдання з ідентифікатором {taskId} успішно видалено .");
        }
        else
        {
            Console.WriteLine($"Завдання з ідентифікатором  {taskId} не знайдено.");
        }
    }

    public void DisplayAllTasks()
    {
        Console.WriteLine("Task List:");
        foreach (Task task in taskList)
        {
            Console.WriteLine($"Task ID: {task.TaskId}, Description: {task.Description}");
        }
    }
}

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

       
        taskManager.AddTask(new Task { TaskId = 1, Description = "Complete project A" });
        taskManager.AddTask(new Task { TaskId = 2, Description = "Attend team meeting" });
        taskManager.AddTask(new Task { TaskId = 3, Description = "Review and revise documentation" });

    
        taskManager.DisplayAllTasks();

    
        taskManager.RemoveTask(2);

       
        taskManager.DisplayAllTasks();
    }
}
