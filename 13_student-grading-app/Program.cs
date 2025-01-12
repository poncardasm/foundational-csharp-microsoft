// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };




foreach (string name in studentNames)
{
  if (name == "Sophia")
  {
    int sophiaSum = 0;

    decimal sophiaScoreAvg;

    foreach (int score in sophiaScores)
    {
      // Add the exam score to the sum
      sophiaSum += score;
    }

    sophiaScoreAvg = (decimal)sophiaSum / currentAssignments;

    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine("Sophia:\t\t" + sophiaScoreAvg + "\tA-");
  }
}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();
