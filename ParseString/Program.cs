using System;

class OrganizationParser
{
    public static void Main(string[] args)
    {
        // Define the input string
        string input = "Organization";

        // Parse the value from the input string
        string parsedValue = ParseOrganizationValue(input);

        // Output the parsed value
        Console.WriteLine("Parsed value: " + parsedValue);
    }

    public static string ParseOrganizationValue(string input)
    {
        // Define the prefix to look for
        string prefix = "Organ";

        // Check if the input string starts with the prefix
        if (input.Contains(prefix))
        {
            // Remove the prefix from the input string to get the parsed value
            string parsedValue = input.Substring(prefix.Length);

            // Return the parsed value
            return parsedValue;
        }
        else
        {
            // Throw an exception if the input string doesn't start with the prefix
            throw new ArgumentException("The input string must start with the prefix 'Organization'.");
        }
    }
}
