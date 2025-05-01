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
         static void Convo(SpeechSynthesizer synth)
 {

     {


     }
     while (true)
     {
         Console.ForegroundColor = ConsoleColor.Red;
         string question = Console.ReadLine().Trim().ToLower();
         Console.ResetColor();

         string response;
         switch (question)
         {
             case "hi":
             case "hello":
                 response = "Hello! How can I help you with cybersecurity today?";
                 break;

             case "how are you?":
                 response = "I'm just a bot, but I'm functioning well! Ready to discuss cybersecurity.";
                 break;

             case "what's your name?":
                 response = "I'm your Cybersecurity Awareness Assistant!";
                 break;

             case "what do you do?":
                 response = "I help educate people about online safety and cybersecurity best practices.";
                 break;

             case "what is phishing?":
                 response = "Phishing is when criminals try to trick you into giving personal information through fake emails or websites. Never click suspicious links!";
                 break;

             case "how to make a strong password?":
                 response = "Use at least 12 characters with mix of letters, numbers and symbols. Avoid personal info. Example: 'B1ue$ky@2023'";
                 break;

             case "what is malware?":
                 response = "Malware is malicious software that can harm your device. Always keep antivirus updated!";
                 break;

             case "how to browse safely?":
                 response = "1) Check for HTTPS in URLs\n2) Avoid public WiFi for sensitive tasks\n3) Keep browser updated\n4) Don't download from untrusted sites";
                 break;

             case "what is two-factor authentication?":
                 response = "2FA adds extra security by requiring a second step (like SMS code) beyond just a password. Always enable it when available!";
                 break;

             case "exit":
                 response = "Goodbye! Stay safe online.";
                 synth.Speak(response);
                 Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine(response);
                 Console.ResetColor();
                 return;

             default:
                 response = "I didn't understand that. Try asking about:\n- passwords\n- phishing\n- malware\n- safe browsing\nType 'exit' to quit.";
                 break;
         }

         synth.Speak(response);
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine(response);
         Console.ResetColor();
     }
 }
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 100;

            logo();
            header();
            Welcome(synth);
            Convo(synth);
            
        }
    }
}
