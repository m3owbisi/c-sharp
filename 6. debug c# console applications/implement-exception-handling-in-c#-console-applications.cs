try
{   
   // try code block - code that may generate an exception
}
catch
{   
   // catch code block - code to handle an exception
}
finally
{   
   // finally code block - code to clean up resources
}
try
{
    // Step 1: code execution begins
    try
    {
        // Step 2: an exception occurs here
    }
    finally
    {
        // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
    }
}
catch // Step 3: the system finds a catch clause that can handle the exception
{   
   // Step 5: the system transfers control to the first line of the catch code block
}
string[] names = { "Dog", "Cat", "Fish" };
Object[] objs = (Object[])names;
Object obj = (Object)13;
objs[2] = obj; // ArrayTypeMismatchException occurs
int number1 = 3000;
int number2 = 0;
Console.WriteLine(number1 / number2); // DivideByZeroException occurs
int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue); // FormatException occurs
int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];
values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs
object obj = "This is a string";
int num = (int)obj;
int[] values = null;
for (int i = 0; i <= 9; i++)
    values[i] = i * 2;
string? lowCaseString = null;
Console.WriteLine(lowCaseString.ToUpper());
decimal x = 400;
byte i;
i = (byte)x; // OverflowException occurs
Console.WriteLine(i);
// dotnet new console
double float1 = 3000.0;
double float2 = 0.0;
int number1 = 3000;
int number2 = 0;
Console.WriteLine(float1 / float2);
Console.WriteLine(number1 / number2);
Console.WriteLine("Exit program");
double float1 = 3000.0;
double float2 = 0.0;
int number1 = 3000;
int number2 = 0;
try
{
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
Console.WriteLine("Exit program");
try
{
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
catch
{
    Console.WriteLine("An exception has been caught");
}
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}
Console.WriteLine("Exit program");
static void Process1()
{
    WriteMessage();
}
static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}
Console.WriteLine("Exit program");
static void Process1()
{
    WriteMessage();
}
static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}
Console.WriteLine("Exit program");
static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch
    {
        Console.WriteLine("Exception caught in Process1");
    }
}
static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}
Console.WriteLine("Exit program");
static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch
    {
        Console.WriteLine("Exception caught in Process1");
    }
}
static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}
Console.WriteLine($"Exception caught in Process1: {ex.Message}");
static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}
static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;
    Console.WriteLine(float1 / float2);
    // Console.WriteLine(number1 / number2);
    checked
    {
        smallNumber = (byte)number1;
    }
}
static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
    checked
    {
        smallNumber = (byte)number1;
    }
}
Console.WriteLine(float1 / float2);
static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;
    try
    {
        Console.WriteLine(float1 / float2);
        Console.WriteLine(number1 / number2);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
    }
    checked
    {
        smallNumber = (byte)number1;
    }
}
checked
{
    try
    {
        smallNumber = (byte)number1;
    }
    catch (OverflowException ex)
    {
        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
    }  
}
// inputValues is used to store numeric values entered by a user
string[] inputValues = new string[]{"three", "9999999999", "0", "2" };
foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
int numValue = 0;
try
{
    int num1 = int.MaxValue;
    int num2 = int.MaxValue;
    int result = num1 + num2;
    Console.WriteLine("Result: " + result);
    string str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (OverflowException ex)
{
    Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null." + ex.Message);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range." + ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
}
Console.WriteLine("Exiting program.");
checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
    }
}
try
{
    string? str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null. " + ex.Message);
}
try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range. " + ex.Message);
}
try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}
Console.WriteLine("Exiting program.");