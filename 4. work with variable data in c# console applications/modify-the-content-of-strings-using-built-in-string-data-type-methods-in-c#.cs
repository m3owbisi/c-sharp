// C:\Users\someuser\Desktop>
string message = "Find what is (inside the parentheses)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');
Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);
string message = "Find what is (inside the parentheses)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');
// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
string message = "Find what is (inside the parentheses)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');
openingPosition += 1;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
string message = "What is the value <span>between the tags</span>?";
int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");
openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
string message = "What is the value <span>between the tags</span>?";
const string openSpan = "<span>";
const string closeSpan = "</span>";
int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);
openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');
openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;
    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}
message = message.Substring(closingPosition + 1);
int openingPosition = message.IndexOf('(');
if (openingPosition == -1) break;
string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");
openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:
char[] openSymbols = { '[', '{', '(' };
// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:
int closingPosition = 0;
while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
    if (openingPosition == -1) break;
    string currentSymbol = message.Substring(openingPosition, 1);
    // Now  find the matching closing symbol
    char matchingSymbol = ' ';
    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }
    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 
    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);
    // Finally, use the techniques you've already learned to display the sub-string:
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
closingPosition = message.IndexOf(matchingSymbol, openingPosition);
int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
string quantity = "";
string output = "";
// Your work here
Console.WriteLine(quantity);
Console.WriteLine(output);
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
string quantity = "";
string output = "";
// Your work here
// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";
int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";
// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);
// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);
// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);
Console.WriteLine(quantity);
Console.WriteLine(output);