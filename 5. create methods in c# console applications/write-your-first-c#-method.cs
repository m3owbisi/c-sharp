void SayHello();
void SayHello() 
{
    Console.WriteLine("Hello World!");
}
Console.Write("Input!");
SayHello();
void SayHello() 
{
    Console.WriteLine("Hello World!");
}
int[] a = {1,2,3,4,5};
Console.WriteLine("Contents of Array:");
PrintArray();
void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Before calling a method");
SayHello();
Console.WriteLine("After calling a method");
void SayHello() 
{
    Console.WriteLine("Hello World!");
}
void ShowData(string a, int b, int c);
void DisplayDate(string month, int day, int year);
// C:\Users\someuser\Desktop>
void DisplayRandomNumbers();
void DisplayRandomNumbers() 
{
    Random random = new Random();
}
void DisplayRandomNumbers() 
{
    Random random = new Random();
    for (int i = 0; i < 5; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }
}
void DisplayRandomNumbers() 
{
    Random random = new Random();
    for (int i = 0; i < 5; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();
Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();
void DisplayRandomNumbers() 
{
    Random random = new Random();
    for (int i = 0; i < 5; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }
    Console.WriteLine();
}
using System;
int[] times = {800, 1200, 1600, 2000};
int diff = 0;
Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Current Medicine Schedule:");
/* Format and display medicine times */
foreach (int val in times)
{
    string time = val.ToString();
    int len = time.Length;
    if (len >= 3)
    {
        time = time.Insert(len - 2, ":");
    }
    else if (len == 2)
    {
        time = time.Insert(0, "0:");
    }
    else
    {
        time = time.Insert(0, "0:0");
    }
    Console.Write($"{time} ");
}
Console.WriteLine();
Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
Console.WriteLine("New Medicine Schedule:");
/* Format and display medicine times */
foreach (int val in times)
{
    string time = val.ToString();
    int len = time.Length;
    if (len >= 3)
    {
        time = time.Insert(len - 2, ":");
    }
    else if (len == 2)
    {
        time = time.Insert(0, "0:");
    }
    else
    {
        time = time.Insert(0, "0:0");
    }
    Console.Write($"{time} ");
}
Console.WriteLine();
void DisplayTimes() 
{
}
void DisplayTimes() 
{
    /* Format and display medicine times */
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;
        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }
        Console.Write($"{time} ");
    }
    Console.WriteLine();
}
void AdjustTimes() 
{
}
void AdjustTimes() 
{
    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
Console.WriteLine("Current Medicine Schedule:");
/* Format and display medicine times */
foreach (int val in times)
{
    ...
}
Console.WriteLine();
Console.WriteLine("Enter new GMT");
Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();
Console.WriteLine("Enter new GMT");
Console.WriteLine("New Medicine Schedule:");
/* Format and display medicine times */
foreach (int val in times)
{
    ...
}
Console.WriteLine();
Console.WriteLine("New Medicine Schedule:");
DisplayTimes();
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimes();
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimes();
}
int[] times = {800, 1200, 1600, 2000};
int diff = 0;
Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();
Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimes();
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimes();
}
Console.WriteLine("New Medicine Schedule:");
DisplayTimes();
void DisplayTimes()
{
    /* Format and display medicine times */
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;
        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }
        Console.Write($"{time} ");
    }
    Console.WriteLine();
}
void AdjustTimes() 
{
    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255
then ipAddress is valid
else ipAddress is invalid
*/
if (ValidateLength() && ValidateZeroes() && ValidateRange()) 
{
    Console.WriteLine($"ip is a valid IPv4 address");
} 
else 
{
    Console.WriteLine($"ip is an invalid IPv4 address");
}
void ValidateLength() {}
void ValidateZeroes() {}
void ValidateRange() {}
string ipv4Input = "107.31.1.5";
bool validLength = false;
bool validZeroes = false;
bool validRange = false;
ValidateLength(); 
ValidateZeroes(); 
ValidateRange();
if (validLength && validZeroes && validRange) 
{
    Console.WriteLine($"ip is a valid IPv4 address");
} 
else
{
    Console.WriteLine($"ip is an invalid IPv4 address");
}
void ValidateLength() 
{
    string[] address = ipv4Input.Split(".");
    validLength = address.Length == 4;
};
void ValidateZeroes() 
{
    string[] address = ipv4Input.Split(".");
    foreach (string number in address) 
    {
        if (number.Length > 1 && number.StartsWith("0")) 
        {
            validZeroes = false;
        }
    }
    validZeroes = true;
}
foreach (string number in address) 
{
    if (number.Length > 1 && number.StartsWith("0")) 
    {
        validZeroes = false;
        return;
    }
}
void ValidateRange() 
{
    string[] address = ipv4Input.Split(".");
    foreach (string number in address) 
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255) 
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}
string[] address = ipv4Input.Split(".", StringSplitOptions.RemoveEmptyEntries);
string ipv4Input = "107.31.1.5";
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
foreach (string ip in ipv4Input) 
{
    ValidateLength(); 
    ValidateZeroes(); 
    ValidateRange();
    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    } 
    else 
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;
foreach (string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
}
void ValidateLength() 
{
    validLength = address.Length == 4;
};
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;
foreach (string ip in ipv4Input) 
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
    ValidateLength(); 
    ValidateZeroes(); 
    ValidateRange();
    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    } 
    else 
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}
void ValidateLength() 
{
    validLength = address.Length == 4;
};
void ValidateZeroes() 
{
    foreach (string number in address) 
    {
        if (number.Length > 1 && number.StartsWith("0")) 
        {
            validZeroes = false;
            return;
        }
    }
    validZeroes = true;
}
void ValidateRange() 
{
    foreach (string number in address) 
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255) 
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}
Random random = new Random();
int luck = random.Next(100);
string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};
Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
for (int i = 0; i < 4; i++) 
{
    Console.Write($"{text[i]} {fortune[i]} ");
}
Random random = new Random();
int luck = random.Next(100);
string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};
TellFortune();
luck = random.Next(100);
TellFortune();
void TellFortune() 
{
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}