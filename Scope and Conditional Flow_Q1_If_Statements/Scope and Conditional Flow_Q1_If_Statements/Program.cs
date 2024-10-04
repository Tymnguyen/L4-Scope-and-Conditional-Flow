using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Part 1 - Part 6
        // Get two inputs and compare them
        Console.WriteLine("Enter two numbers:");
        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());

        // Part 1: Check if the inputs are equal
        if (input1 == input2)
        {
            Console.WriteLine("The inputs are equal.");
        }

        // Part 2: Check if the first input is greater than the second
        if (input1 > input2)
        {
            Console.WriteLine("The first input is greater than the second.");
        }

        // Part 3: Check if the first input is less than the second
        if (input1 < input2)
        {
            Console.WriteLine("The first input is less than the second.");
        }

        // Part 4: Check if the inputs are not equal
        if (input1 != input2)
        {
            Console.WriteLine("The inputs are not equal.");
        }

        // Part 5: Check if the first input is greater than or equal to the second
        if (input1 >= input2)
        {
            Console.WriteLine("The first input is greater than or equal to the second.");
        }

        // Part 6: Check if the first input is less than or equal to the second
        if (input1 <= input2)
        {
            Console.WriteLine("The first input is less than or equal to the second.");
        }

        // Part 7: Math quiz
        Console.WriteLine("What is 5 + 3?");
        int answer = int.Parse(Console.ReadLine());
        if (answer == 8)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect.");
        }

        // Part 8: Voting age check
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        if (age >= 18)
        {
            Console.WriteLine("You are old enough to vote.");
        }
        else
        {
            Console.WriteLine("You are not old enough to vote.");
        }

        // Part 9: Enemy state based on health points
        Console.WriteLine("Enter enemy's health points:");
        int enemyHP = int.Parse(Console.ReadLine());
        if (enemyHP == 100)
        {
            Console.WriteLine("Enemy is in full health.");
        }
        else if (enemyHP == 50)
        {
            Console.WriteLine("Enemy is injured.");
        }
        else if (enemyHP == 25)
        {
            Console.WriteLine("Enemy is critically injured.");
        }
        else if (enemyHP == 0)
        {
            Console.WriteLine("Enemy is defeated.");
        }

        // Part 10: Discount eligibility check based on age
        Console.WriteLine("Enter your age for discount check:");
        int discountAge = int.Parse(Console.ReadLine());
        if (discountAge >= 18)
        {
            Console.WriteLine("You are eligible for a discount.");
        }
        else
        {
            Console.WriteLine("You are not eligible for a discount.");
        }

        // Break and Continue Statements

        // Part 1: Skip counting the number 5
        for (int i = 1; i <= 20; i++)
        {
            if (i == 5)
            {
                continue;
            }
            Console.WriteLine(i);
        }

        // Part 2: Break the loop if number 7 is encountered
        for (int i = 1; i <= 10; i++)
        {
            if (i == 7)
            {
                break;
            }
            Console.WriteLine(i);
        }

        // Part 3: Print all even numbers from 1 to 20, skip 10
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0 && i != 10)
            {
                Console.WriteLine(i);
            }
        }

        // Part 4: Search for "apple" in a list of fruits
        List<string> fruits = new List<string> { "banana", "orange", "apple", "grape" };
        foreach (var fruit in fruits)
        {
            if (fruit == "apple")
            {
                Console.WriteLine("Apple found!");
                break;
            }
        }

        // Extra Challenges

        // Part 11: Commission based on sales
        Console.WriteLine("Enter the monthly sales:");
        double sales = double.Parse(Console.ReadLine());
        double commission = sales >= 10000 ? sales * 0.10 : sales * 0.05;
        Console.WriteLine($"Commission earned: ${commission}");

        // Part 12: Generate two random integers for a sum quiz
        Random random = new Random();
        int num1 = random.Next(0, 101);
        int num2 = random.Next(0, 101);
        Console.WriteLine($"What is the sum of {num1} and {num2}?");
        int sumAnswer = int.Parse(Console.ReadLine());
        if (sumAnswer == num1 + num2)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine($"Incorrect. The correct answer is {num1 + num2}.");
        }

        // Part 13: Grade based on marks
        Console.WriteLine("Enter student's marks:");
        int marks = int.Parse(Console.ReadLine());
        string grade;
        string comment = "";
        if (marks >= 85) { grade = "A+"; comment = "Excellent!"; }
        else if (marks >= 80) { grade = "A"; comment = "Well done."; }
        else if (marks >= 75) { grade = "B+"; }
        else if (marks >= 70) { grade = "B"; }
        else if (marks >= 65) { grade = "C+"; }
        else if (marks >= 60) { grade = "C"; }
        else if (marks >= 55) { grade = "D+"; }
        else if (marks >= 50) { grade = "D"; }
        else { grade = "F"; comment = "See me."; }
        Console.WriteLine($"Grade: {grade}");
        if (comment != "") Console.WriteLine($"Comment: {comment}");

        // Part 14: Guard behavior based on player's distance
        Console.WriteLine("Enter if the guard sees the player (true/false):");
        bool seesPlayer = bool.Parse(Console.ReadLine());
        if (!seesPlayer)
        {
            Console.WriteLine("The guard will wait.");
        }
        else
        {
            Console.WriteLine("Enter the distance from the player:");
            int distFromPlayer = int.Parse(Console.ReadLine());
            if (distFromPlayer <= 1)
            {
                Console.WriteLine("The guard will attack.");
            }
            else if (distFromPlayer >= 2 && distFromPlayer <= 4)
            {
                Console.WriteLine("The guard will advance.");
            }
            else
            {
                Console.WriteLine("The guard will wait.");
            }
        }
    }
}
