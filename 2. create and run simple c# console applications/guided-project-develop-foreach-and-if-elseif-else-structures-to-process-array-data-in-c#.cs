// initialize variables - graded assignments 
int currentAssignments = 5;
int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;
int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;
int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;
int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;
int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;
decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;
sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;
sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
/*
Determining projects to restore...
All projects are up-to-date for restore.
Starter -> C:\Users\someuser\Desktop\GuidedProject\Starter\bin\Debug\net7.0\Starter.dll
Build succeeded.
    0 Warning(s)
    0 Error(s)
*/
int[] sophiaScores = new int[5];
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;
int[] andrewScores = new int[] {92, 89, 81, 96, 90};
// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
int sophiaSum = 0;
int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;
decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;
sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;
sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;
// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
int sophiaSum = 0;
decimal sophiaScore;
sophiaScore = (decimal)sophiaSum / currentAssignments;
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
foreach (int score in sophiaScores)
{
}
foreach (int score in sophiaScores)
{
    // add the exam score to the sum
    sophiaSum += score;    
}
sophiaSum = sophiaSum + score;
// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
int sophiaSum = 0;
decimal sophiaScore;
foreach (int score in sophiaScores)
{
    // add the exam score to the sum
    sophiaSum += score;
}
sophiaScore = (decimal)sophiaSum / currentAssignments;
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
// C:\Users\someuser\Desktop\GuidedProject\Starter>
/*
Determining projects to restore...
All projects are up-to-date for restore.
Starter -> C:\Users\someuser\Desktop\GuidedProject\Starter\bin\Debug\net6.0\Starter.dll
Build succeeded.
    0 Warning(s)
    0 Error(s)
*/
// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
foreach (string name in studentNames)
{
}
foreach (string name in studentNames)
{
    Console.WriteLine($"{name}");
}
// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
foreach (string name in studentNames)
{
    Console.WriteLine($"{name}");
}
int sophiaSum = 0;
decimal sophiaScore;
foreach (int score in sophiaScores)
{
    // add the exam score to the sum
    sophiaSum += score;
}
sophiaScore = (decimal)sophiaSum / currentAssignments;
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
foreach (string name in studentNames)
{
    Console.WriteLine($"{name}");
    int sophiaSum = 0;
    decimal sophiaScore;
    foreach (int score in sophiaScores)
    {
        // add the exam score to the sum
        sophiaSum += score;
    }
    sophiaScore = (decimal)sophiaSum / currentAssignments;
    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
Console.WriteLine($"{name}");
if (name == "Sophia")
{
}
// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
// Student names
string[] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};
foreach (string name in studentNames)
{
    if (name == "Sophia")
    {
        int sophiaSum = 0;
        decimal sophiaScore;
        foreach (int score in sophiaScores)
        {
            // add the exam score to the sum
            sophiaSum += score;
        }
        sophiaScore = (decimal)(sophiaSum) / currentAssignments;
        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
    }
}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
int[] studentScores = new int[10];
string currentStudent = name;
if (currentStudent == "Sophia")
{
    string currentStudent = name;
    if (currentStudent == "Sophia")
    {
    }
    int sophiaSum = 0;
    decimal sophiaScore;
    foreach (int score in sophiaScores)
    {
        // add the exam score to the sum
        sophiaSum += score;
    }
    sophiaScore = (decimal)sophiaSum / currentAssignments;
    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
}
if (currentStudent == "Sophia")
    studentScores = sophiaScores;
else if (currentStudent == "Andrew")
    studentScores = andrewScores;
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
    int sophiaSum = 0;
    decimal sophiaScore;
    foreach (int score in sophiaScores)
    {
        // add the exam score to the sum
        sophiaSum += score;
    }
    sophiaScore = (decimal)sophiaSum / currentAssignments;
    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
}
foreach (int score in studentScores)
int sumAssignmentScores = 0;
decimal currentStudentGrade = 0;
int sophiaSum = 0;
decimal sophiaScore;
foreach (int score in studentScores)
{
    // add the exam score to the sum
    sumAssignmentScores += score;
}
currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;
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
    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;
    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;
    foreach (int score in studentScores)
    {
        // add the exam score to the sum
        sumAssignmentScores += score;
    }
    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;
    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
}
Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentScores = new int[10];
// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");
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
    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;
    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;
    foreach (int score in studentScores)
    {
        // add the exam score to the sum
        sumAssignmentScores += score;
    }
    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
}
string currentStudentLetterGrade = "";
if (currentStudentGrade >= 97)
    currentStudentLetterGrade = "A+";
else if (currentStudentGrade >= 93)
    currentStudentLetterGrade = "A";
if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";
// initialize variables - graded assignments
int currentAssignments = 5;
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentScores = new int[10];
string currentStudentLetterGrade = "";
// Display the Report Header
Console.WriteLine("Student\t\tGrade\n");
foreach (string name in studentNames)
{
    string currentStudent = name;
    if (currentStudent == "Sophia")
        // assign Sophia's scores to the studentScores array 
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        // assign Andrew's scores to the studentScores array 
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        // assign Emma's scores to the studentScores array 
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        // assign Logan's scores to the studentScores array 
        studentScores = loganScores;
    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;
    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;
    foreach (int score in studentScores)
    {
        // add the exam score to the sum
        sumAssignmentScores += score;
    }
    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";
    Console.WriteLine($"{name}\t\t{currentStudentGrade}\t?");
}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
foreach (int score in studentScores)
{
    // add the exam score to the sum
    sumAssignmentScores += score;
}
// initialize/reset a counter for the number of assignments
int gradedAssignments = 0;
// increment the assignment counter
gradedAssignments += 1;
if (gradedAssignments <= examAssignments)
// add the extra credit points to the sum - bonus points equal to 10% of an exam score
sumAssignmentScores += score / 10;
// initialize variables - graded assignments
int examAssignments = 5;
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentScores = new int[10];
string currentStudentLetterGrade = "";
// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");
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
    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;
    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;
    // initialize/reset a counter for the number of assignment 
    int gradedAssignments = 0;
    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
            // add the exam score to the sum
            sumAssignmentScores += score;
        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10;
    }
    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";
    //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}
// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    
// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
if (currentStudent == "Sophia")
    studentScores = sophiaScores;
else if (currentStudent == "Andrew")
    studentScores = andrewScores;
else if (currentStudent == "Emma")
    studentScores = emmaScores;
else if (currentStudent == "Logan")
    studentScores = loganScores;
else if (currentStudent == "Becky")
    studentScores = beckyScores;
else if (currentStudent == "Chris")
    studentScores = chrisScores;
else if (currentStudent == "Eric")
    studentScores = ericScores;
else if (currentStudent == "Gregor")
    studentScores = gregorScores;
else
    continue;