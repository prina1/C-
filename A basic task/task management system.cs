using System;
using System.Collections.Generic;

class TaskManager
{
    //using list to store tasks 
    private List<TaskItem>taskList;

    //using a stack to store completed tasks 
    private Stack<TaskItem>completedTasks;

    //using a queue to store pending tasks
    private Queue<TaskItem>pendingTasks;

    //using a dictionary to store tasks with quique IDS
    private Dictionary<int,TaskItem>taskDictionary;
    
    public TaskManager()
    {

        taskList = new List<TaskItem>();
        completedTasks = new Stack<TaskItem>();
        pendingTasks = new Queue<TaskItem>();
        taskDictionary = new Dictionary<int,TaskItem>();
        
    }
    public void AddTask(string description, int priority)
    {
        TaskItem newTask = new TaskItem(description,priority);

        //adding to the l;ist 
        taskList.Add(newTask);

        //adding to the queue
        pendingTasks.Enqueue(newTask);

        //adding to the dictionary
        int taskid = taskDictionary.Count+1;
        taskDictionary.Add(taskid, newTask);

        }
        class TaskItem
        {
            public string description {get; set;}
            public int priority {get; set;}
            public TaskItem(string description, int priority)
            {
                this.description = description;
                this.priority = priority;

            }
            

        }

}