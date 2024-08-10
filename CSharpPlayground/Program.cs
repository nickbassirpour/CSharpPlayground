using CSharpMethods;
using System.Linq;

List<string> dataTypes = new List<string> { 
"string",
"number"
};

string dataTypesString = String.Empty;

foreach (string dataType in dataTypes)
{
    dataTypesString = dataTypesString + dataType;
}

bool goodDataType = false;

do
{
    Console.WriteLine($"Which data type do you want to see ({ String.Join(", ", dataTypes)}): ");
    string dataType = Console.ReadLine();
    switch (dataType)
    {
        case "string":
            StringPrompt.StringPrompts();
            goodDataType = true;
            break;
        case "number":
            Console.WriteLine("Cannot use that one yet.");
            break;
        default:
            Console.WriteLine("That was not a correct data type.");
            break;
    }
} while (goodDataType == false);
