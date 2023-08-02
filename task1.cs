using System;
using System.Collections.Generic; 

class Hello
{
    static Dictionary <string, Dictionary<string, int>> database = new Dictionary<string,Dictionary<string, int>>();

    public static void StudentRegister()
    {
        Console.Write("please Enter Name: ");
        string Name = Console.ReadLine(); 

        Console.Write("Please Enter Number of Subject you have Taken: ");
        string inputSubjectTaken = Console.ReadLine();
        int SubjectTaken = Convert.ToInt32(inputSubjectTaken);
        int sumValue = 0;

        Dictionary<string, int> subjectValue = new Dictionary<string, int>();

        int i = 0;
        while (i < SubjectTaken) 
        {
            Console.Write("Subject :");
            string subject = Console.ReadLine();
            if(subject.Count() == 0){
                Console.WriteLine("You have to enter the subject");
                continue;
            }
            else if (subjectValue.ContainsKey(subject)) {
                Console.WriteLine("The subject is already in there !");
                continue;
            }
            

            Console.Write("Grade :"); 
            string inputGrade = Console.ReadLine(); 
            int Grade = Convert.ToInt32(inputGrade);
            if (Grade <0 || Grade > 100)
            {
                Console.WriteLine("please Enter the valid number (0-100)");
                continue;
            }
            sumValue += Grade;
            
            subjectValue[subject] = Grade;
            i++;

        }
        subjectValue["Average"] = sumValue/SubjectTaken;
        database[Name] = subjectValue;

        Menu();
    }

    public static void DisplayData()
    {
        foreach (KeyValuePair<string,Dictionary<string,int>> db in database)
        {
            Console.WriteLine($"User Name {db.Key}");
            foreach (KeyValuePair<string,int> subject in db.Value)
            {
                if (subject.Key == "Average")
                {
                    Console.WriteLine($" Average - {subject.Value}");
                }
                else 
                Console.WriteLine($"Subject - {subject.Key} , Grade - {subject.Value}"); 


            }
        }
        Menu();
    }
    public static void Menu()
    {
        Console.WriteLine("------------Welcome Back------------");
        Console.WriteLine();
        Console.WriteLine("To add a data press 1");
        Console.WriteLine("To see the result press 2");
        Console.WriteLine("To see this page again press 0");
        Console.WriteLine("To exit press any number except 0,1 or 2");
        Console.WriteLine("-------------------------------------");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                StudentRegister();
                break;
            case "2":
                DisplayData();
                break; 
            case "0":
                Menu();
                break;

                

        }
    }

    static void Main()
    {

        Menu();


    }
}
