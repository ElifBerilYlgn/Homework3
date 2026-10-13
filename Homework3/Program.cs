



int total = 0;
int gradeCounter = 0;

Console.Write("Enter grade (enter -1 to quit): ");
int grade = int.Parse(Console.ReadLine());

int highest = grade;
int lowest = grade;

while (grade != -1)
{
    total = total + grade;
    gradeCounter = gradeCounter + 1;

    if (grade > highest)
    {
        highest = grade;
    }

    if (grade < lowest)
    {
        lowest = grade;
    }

    Console.Write("Enter grade (enter -1 to quit): ");
    grade = int.Parse(Console.ReadLine());
}

if (gradeCounter != 0)
{
    double average = (double)total / gradeCounter;

    Console.WriteLine($"Count: {gradeCounter}");
    Console.WriteLine($"Sum: {total}");
    Console.WriteLine($"Average: {average:F2}");
    Console.WriteLine($"Highest: {highest}");
    Console.WriteLine($"Lowest: {lowest}");
}
else
{
    Console.WriteLine("No grades entered.");
}




Console.WriteLine();
Console.WriteLine();


Console.Write("Enter a number between 1 and 10: ");
int num = int.Parse(Console.ReadLine());

if (num < 1)
{
    Console.WriteLine("your number must be between 1 and 10.");
}
else if (num > 10)
{
    Console.WriteLine(" your number must be between 1 and 10.");
}
else
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{num} x {i} = {num * i}");
    }
}


