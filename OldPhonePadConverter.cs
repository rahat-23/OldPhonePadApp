using System.Text;

public class OldPhonePadConverter
{
    // This method converts old phone pad input into corresponding text.
    public static string OldPhonePad(string input)
    {
        StringBuilder result = new StringBuilder(); // StringBuilder to store the resulting text.
        
        // Array mapping each digit to its corresponding characters on an old phone pad.
        string[] keyMap = new string[]
        {
            " ",    // 0 - space character
            "",     // 1 - no characters
            "ABC",  // 2
            "DEF",  // 3
            "GHI",  // 4
            "JKL",  // 5
            "MNO",  // 6
            "PQRS", // 7
            "TUV",  // 8
            "WXYZ"  // 9
        };

        int i = 0; // Index to iterate through the input string.

        // Loop through the input string until the end is reached.
        while (i < input.Length)
        {
            char currentChar = input[i]; // Get the current character.

            // If the current character is '#', it indicates the end of the input.
            if (currentChar == '#')
            {
                break; // Exit the loop.
            }
            // If the current character is '*', it indicates a backspace.
            else if (currentChar == '*')
            {
                if (result.Length > 0)
                {
                    result.Remove(result.Length - 1, 1); // Remove the last character from the result.
                }
            }
            // If the current character is a digit, process it.
            else if (char.IsDigit(currentChar))
            {
                int digit = currentChar - '0'; // Convert the character to its corresponding digit.
                int count = 1; // Initialize the count of consecutive same digits.

                // Count consecutive same digits.
                while (i + 1 < input.Length && input[i + 1] == currentChar)
                {
                    count++; // Increment the count.
                    i++; // Move to the next character.
                }

                // Ensure the digit is within the range that maps to characters (0-9).
                if (digit >= 0 && digit <= 9)
                {
                    string characters = keyMap[digit]; // Get the characters corresponding to the digit.
                    int index = (count - 1) % characters.Length; // Determine the character index based on the count.
                    result.Append(characters[index]); // Append the character to the result.
                }
            }
            // If the current character is a space, it indicates a pause.
            else if (currentChar == ' ')
            {
                // Move to the next character.
                i++;
                continue; // Skip the rest of the loop and continue with the next iteration.
            }

            i++; // Move to the next character.
        }

        return result.ToString(); // Return the resulting text.
    }
}
