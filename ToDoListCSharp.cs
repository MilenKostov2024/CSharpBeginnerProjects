List<string> taskList = new List<string>();
string option;
Console.Title = "To Do List";

while (true)
{
    Console.WriteLine("1. Add Task");
    Console.WriteLine("2. Show Task");
    Console.WriteLine("3. Remove Task");
    Console.WriteLine("4. Show Task List");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option (1-5): ");
    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.Write("Enter the task to add: ");
            string taskToAdd = Console.ReadLine();
            taskList.Add(taskToAdd);
            Console.WriteLine($"Task added.");
            break;

        case "2":
            Console.Write("Enter the task number to show: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= taskList.Count)
            {
                Console.WriteLine($"Task {taskNumber}: {taskList[taskNumber - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
            break;

        case "3":
            Console.Write("Enter the task number to remove: ");
            if (int.TryParse(Console.ReadLine(), out int removeNumber) && removeNumber > 0 && removeNumber <= taskList.Count)
            {
                string removedTask = taskList[removeNumber - 1];
                taskList.RemoveAt(removeNumber - 1);
                Console.WriteLine($"Task '{removedTask}' removed.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
            break;

        case "4":
            Console.WriteLine("\nCurrent Task List:");
            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {taskList[i]}");
            }
            break;

        case "5":
            Console.WriteLine("Exiting the program.");
            break;

        default:
            Console.WriteLine("Invalid option. Please choose a valid option (1-5).");
            break;
    }

} while (option != "5") ;
