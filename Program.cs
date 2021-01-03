using System;


namespace Student_DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report\n\n");
            Console.WriteLine("What is your name?");
            String studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            String currCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            String pageNumber = Console.ReadLine();
            int pgN = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            String needHelp = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            String positiveExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide>? Please be specific");
            String Feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            String hrsStudy = Console.ReadLine();
            int hours = Convert.ToInt32(hrsStudy);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.\n\nHave a great day!");
            

        }
    }
}
