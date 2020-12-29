using System;

namespace JuliusCaesar
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "experience is the teacher of all things";

            int key = 3;

            string encrypted = Encrypt(message, key);
            Console.WriteLine(encrypted);

            Console.ReadKey();

            
        }

        public static string Encrypt(string message, int key)
        {
            message = message.ToUpper();

            string encryptedMessage = "";

            for(int index = 0; index < message.Length; index++)
            {
                char encryptedLetter = Encrypt(message[index], key);
                encryptedMessage += encryptedLetter;
            }
            return encryptedMessage;
        }

        private static char Encrypt(char letter, int key)
        {
            if(letter < 'A' || letter > 'Z') { return letter; }

            int letterAsNumber = (int)letter - 'A';

            int encryptedLetter = (letterAsNumber + key) % 26;

            return (char)(encryptedLetter + 'A');
        }
    }
}
