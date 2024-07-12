using System.Text;

public class OldPhonePadConverter
{
    public static string OldPhonePad(string input)
    {
        StringBuilder result = new StringBuilder();
        string[] keyMap = new string[]
        {
            "",     // 0
            "",     // 1
            "ABC",  // 2
            "DEF",  // 3
            "GHI",  // 4
            "JKL",  // 5
            "MNO",  // 6
            "PQRS", // 7
            "TUV",  // 8
            "WXYZ"  // 9
        };

        int i = 0;
        while (i < input.Length)
        {
            char currentChar = input[i];

            if (currentChar == '#')
            {
                break; // End of input
            }
            else if (currentChar == '*')
            {
                if (result.Length > 0)
                {
                    result.Remove(result.Length - 1, 1); // Backspace
                }
            }
            else if (char.IsDigit(currentChar))
            {
                int digit = currentChar - '0';
                int count = 1;

                // Count consecutive same digits
                while (i + 1 < input.Length && input[i + 1] == currentChar)
                {
                    count++;
                    i++;
                }

                if (digit >= 2 && digit <= 9)
                {
                    string characters = keyMap[digit];
                    int index = (count - 1) % characters.Length;
                    result.Append(characters[index]);
                }
            }
            else if (currentChar == ' ')
            {
                // If a space is found, it means a pause between characters.
                // Move to the next character.
                i++;
                continue;
            }

            i++;
        }

        return result.ToString();
    }
}
