void Update();
int[] GetEnemyCoordinates(string enemyId);
int[] GetDistanceFromHero(string enemyId);
int[] GetHeroCoordinates();
bool EnemyCanHitHero(string enemyId);
int GetEnemyDamageOutput(string enemyId);
void UpdateHeroHP(int damage);
void PrintMessage(string message)
// C:\Users\someuser\Desktop>
double total = 0;
double minimumSpend = 30.00;
double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};
Console.WriteLine($"Total: ${total}");
void GetDiscountedPrice(int itemIndex)
{
    // Calculate the discounted price of the item
}
void TotalMeetsMinimum()
{
    // Check if the total meets the minimum
}
void FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
}
double GetDiscountedPrice(int itemIndex)
{
    // Calculate the discounted price of the item
}
double GetDiscountedPrice(int itemIndex)
{
    double result = items[itemIndex] * (1 - discounts[itemIndex]);
    return result;
}
double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}
bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}
string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}
for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}
Console.WriteLine($"Total: ${total}");
if (TotalMeetsMinimum())
{
    total -= 5.00;
}
Console.WriteLine($"Total: ${FormatDecimal(total)}");
double total = 0;
double minimumSpend = 30.00;
double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};
for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}
total -= TotalMeetsMinimum() ? 5.00 : 0.00;
Console.WriteLine($"Total: ${FormatDecimal(total)}");
double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}
bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}
string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}
double usd = 23.73;
int vnd = UsdToVnd(usd);
Console.WriteLine($"${usd} USD = ${vnd} VND");
int UsdToVnd(double usd) 
{
}
/*
int UsdToVnd(double usd) 
{
    int rate = 23500;
    return (int) (rate * usd);
}
*/
double VndToUsd(int vnd) 
{
}
double VndToUsd(int vnd) 
{
    double rate = 23500;
    return vnd / rate;
}
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");
double usd = 23.73;
int vnd = UsdToVnd(usd);
Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");
int UsdToVnd(double usd) 
{
    int rate = 23500;
    return (int) (rate * usd);
}
double VndToUsd(int vnd) 
{
    double rate = 23500;
    return vnd / rate;
}
string ReverseWord(string word) 
{
    string result = "";
    return result;
}
string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}
string input = "snake";
Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));
string ReverseSentence(string input) 
{
    string result = "";
    return result;
}
string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");
    return result;
}
string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");
    foreach(string word in words) 
    {
        result += ReverseWord(word) + " ";
    }
    return result;
}
string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");

    foreach(string word in words) 
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}
string input = "there are snakes at the zoo";
Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));
string input = "there are snakes at the zoo";
Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));
string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");
    foreach(string word in words) 
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}
string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}
string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};
Console.WriteLine("Is it a palindrome?");
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}
bool IsPalindrome(string word) 
{
    return true;
}
bool IsPalindrome(string word) 
{
    int start = 0;
    int end = word.Length - 1;
    while (start < end) 
    {
        if (word[start] != word[end]) 
        {
            return false;
        }
        start++;
        end--;
    }
    return true;
}
int[] TwoCoins(int[] coins, int target) 
{
    return  new int[0];
}
int[] TwoCoins(int[] coins, int target) 
{
    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {
        }
    }
    return  new int[0];
}
for (int curr = 0; curr < coins.Length; curr++) 
{
    for (int next = curr + 1; next < coins.Length; next++) 
    {
        if (coins[curr] + coins[next] == target) 
        {
            return new int[]{curr, next};
        }
    }
}
int target = 60;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[] result = TwoCoins(coins, target);
if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}
int[,] TwoCoins(int[] coins, int target)
int[,] TwoCoins(int[] coins, int target)
{
    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
    int count = 0;
}
int[,] TwoCoins(int[] coins, int target)
{
    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
    int count = 0;
    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
        }
    }
}
for (int next = curr + 1; next < coins.Length; next++) 
{
    if (coins[curr] + coins[next] == target) 
    {
        result[count, 0] = curr;
        result[count, 1] = next;
        count++;
    }
    if (count == result.GetLength(0)) 
    {
        return result;
    }
}
if (count == 0) 
{
    return new int[0,0];
}
return result;
return (count == 0) ? new int[0,0] : result;
int[,] TwoCoins(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;
    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}
int target = 30;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoins(coins, target);
if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        if (result[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}
int target = 30;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        if (result[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}
int[,] TwoCoins(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;
    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {    
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}
int target = 80;
Random random = new Random();
Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}
void PlayGame() 
{
    var play = true;
    while (play) 
    {
        var target;
        var roll;
        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose());
        Console.WriteLine("\nPlay again? (Y/N)");
        play = ShouldPlay();
    }
}
Random random = new Random();
Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}
bool ShouldPlay() 
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}
void PlayGame() 
{
    var play = true;
    while (play) {
        var target = GetTarget();
        var roll = RollDice();
        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");
        play = ShouldPlay();
    }
}
int GetTarget() 
{
    return random.Next(1, 6);
}
int RollDice() 
{
    return random.Next(1, 7);
}
string WinOrLose(int roll, int target) 
{
    if (roll > target) 
    {
        return "You win!";
    }
    return "You lose!";
}