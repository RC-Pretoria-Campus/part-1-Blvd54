using System;
using System.Speech.Synthesis;

namespace cyberbot
{
    class Program
    {
        static void logo()
        {
            Console.WriteLine(@"

  ____       _               _           _   
 / ___|  ___| |__   ___  ___| | __ _ ___| |_ 
| |     / _ \ '_ \ / _ \/ __| |/ _` / __| __|
| |___ |  __/ | | |  __/ (__| | (_| \__ \ |_ 
 \____| \___|_| |_|\___|\___|_|\__,_|___/\__|
   _____
  /     \
 /  O O  \
|    ∆    |
|  \___/  |
|_________|   
  |     |
  |     |
 /       \
/         \
");
        }
       
        static void header()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=========================================");
            Console.WriteLine("          Welcome to Cyberbot            ");
            Console.WriteLine("=========================================");
            Console.ResetColor();
        }
        
        static void Welcome(SpeechSynthesizer synth)
        {
            synth.Speak("Welcome to Cyberbot, please enter your name");
            string userName = Console.ReadLine();
            synth.Speak($"Hello {userName}, how can I assist you today?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hello {userName}, how can I assist you today?");
            Console.ResetColor();
        }
