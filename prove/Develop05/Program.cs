using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        int totalPoints = 0;
        List <Goal> goals = new List<Goal>();

        while(option != "6")
        {
            Console.WriteLine("");
            Console.WriteLine($"You have {totalPoints} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select  choice from the menu: ");
            option = Console.ReadLine();

            if(option == "1")
            {
                Goal goal = new Goal();
                goal.GetGoalsSelector();
                Console.Write("Which goal would you like to create? ");
                string option2 = Console.ReadLine();

                if(option2 == "1")
                {
                    SimpleGoal goal1 = new SimpleGoal("---Simple Goal---", "Simple Goals are the simplest and conventional goals. You can create a goal and when this will be complete it, then you will receive points as a reward. ");
                    Console.Write("Enter a name for the goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter a short description of the goal: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter the quantity of points that you want to recieve when the goal will be completed: ");
                    string stPoints = Console.ReadLine();
                    int points = int.Parse(stPoints);
                    SimpleGoal goal1a = new SimpleGoal(name, description, points);
                    goals.Add(goal1a);
                }
                
                else if(option2 == "2")
                {
                    EternalGoal goal2 = new EternalGoal("---Eternal Goal---", "Eternal goal are goals that you always will repeit as mucha as you can. This kind of goal never can be completed, but you will receive points each time that you complete this goal. ");
                    Console.Write("Enter a name for the goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter a short description of the goal: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter the quantity of points that you want to recieve each time that you complete the goal: ");
                    string stPoints = Console.ReadLine();
                    int points = int.Parse(stPoints);
                    EternalGoal goal2a = new EternalGoal(name, description, points);
                    goals.Add(goal2a);
                }
                
                else if(option2 == "3")
                {
                    CheckListGoal goal3 = new CheckListGoal("---Check List Goal---", "Check List Goals is a goal that is composed. You will have the chance to set how many times you want to repeat the goal to accomplish it, each time you will receive points, and when all time had been completed, you will receive a bonus. ");
                    Console.Write("Enter a name for the goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter a short description of the goal: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter the quantity of points that you want to recieve when the goal will be completed: ");
                    string stPoints = Console.ReadLine();
                    int points = int.Parse(stPoints);
                    Console.Write("Enter the quantity of times need it, in order that the goal can be complete: ");
                    string stTimes = Console.ReadLine();
                    int times = int.Parse(stTimes);
                    Console.Write("Enter the quantity of bonus that you want to recieve when you complete the goal all times: ");
                    string stBonus = Console.ReadLine();
                    int bonus = int.Parse(stBonus);
                    CheckListGoal goal3a = new CheckListGoal(name, description, points, times, bonus);
                    goals.Add(goal3a);
                }
                
                else
                {
                    Console.WriteLine("The option that you wrote is not valid. Please try again. ");
                }

                
                
            }

            if (option == "2")
            {
                int count = 0;
                Console.WriteLine("");
                Console.WriteLine("The goals are: ");
                foreach (Goal goal in goals)
                {
                    count += 1;
                    Console.WriteLine($" {count}. [] " + goal.GetGoalIndicator());
                }
            }

            if (option == "5")
            {
                int count = 0;
                foreach (Goal goal in goals)
                {
                    count += 1;
                    Console.WriteLine($"{count} {goal.GetName()}");
                }
                Console.WriteLine("Enter the goal that you accomplished: ");
                string stGoalIndex = Console.ReadLine();
                int goalIndex = int.Parse(stGoalIndex);
                
                
            }
        
        }

        
    }


}