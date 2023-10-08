namespace Cezar
{
    internal class Cezar
    {
        private string alphabet = "abcdefghijklmnopqrstuvwxyz";

        public void SetCustomAlphabet(string alphabet)
        {
            this.alphabet = alphabet;
        }

        public string Encrypt(string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                int index = alphabet.IndexOf(Char.ToLower(input[i]));
                char currentChar = input[i];

                if (index != -1){
                    currentChar = alphabet[(index + 3) % alphabet.Length];

                    if (char.IsUpper(input[i])) currentChar = char.ToUpper(currentChar);
                }
                
                output += currentChar;
            }

            return output;
        }

        public string Decrypt(string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                int index = alphabet.IndexOf(Char.ToLower(input[i]));
                char currentChar = input[i];

                if (index != -1)
                {
                    currentChar = alphabet[(index - 3 + alphabet.Length) % alphabet.Length];

                    if (char.IsUpper(input[i])) currentChar = char.ToUpper(currentChar);
                }

                output += currentChar;
            }

            return output;
        }
    }
}
