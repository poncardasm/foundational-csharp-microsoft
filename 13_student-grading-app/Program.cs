// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 90, 86, 87, 98, 100 };
int[] emmaScores = new int[] { 90, 86, 87, 98, 100 };
int[] loganScores = new int[] { 90, 86, 87, 98, 100 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

foreach (string name in studentNames)
{
  string currentStudent = name;

  if (currentStudent == "Sophia")
    studentScores = sophiaScores;

  else if (currentStudent == "Andrew")
    studentScores = andrewScores;

  else if (currentStudent == "Emma")
    studentScores = emmaScores;

  else if (currentStudent == "Logan")
    studentScores = loganScores;

  int sumAssignmentScores = 0;
  decimal currentStudentGrade;

  foreach (int score in studentScores)
  {
    // Add the exam score to the sum
    sumAssignmentScores += score;
  }

  currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;

  Console.WriteLine("Student\t\tGrade\n");
  Console.WriteLine("Sophia:\t\t" + sophiaScoreAvg + "\tA-");
}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();
