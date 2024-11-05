using System;
using System.Text;
using Microsoft.VisualBasic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Drawing;
class Example
{
   public static void Main()
   // {
   //    // Get an array with the values of ConsoleColor enumeration members.
   //    ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
   //    // Save the current background and foreground colors.
   //    ConsoleColor currentBackground = Console.BackgroundColor;
   //    ConsoleColor currentForeground = Console.ForegroundColor;

   //    // Display all foreground colors except the one that matches the background.
   //    Console.WriteLine("All the foreground colors except {0}, the background color:",
   //                      currentBackground);
   //    foreach (var color in colors) {
   //       if (color == currentBackground) continue;

   //       Console.ForegroundColor = color;
   //       Console.WriteLine("   The foreground color is {0}.", color);
   //    }
   //    Console.WriteLine();
   //    // Restore the foreground color.
   //    Console.ForegroundColor = currentForeground;

   //    // Display each background color except the one that matches the current foreground color.
   //    Console.WriteLine("All the background colors except {0}, the foreground color:",
   //                      currentForeground);
   //    foreach (var color in colors) {
   //       if (color == currentForeground) continue;

   //       Console.BackgroundColor = color;
   //       Console.WriteLine("   The background color is {0}.", color);
   //    }

   //    // Restore the original console colors.
   //    Console.ResetColor();
   //    Console.WriteLine("\nOriginal colors restored...");
   // }
// {
//       DateTime programStartTime = DateTime.Now;

//       // Prevent example from ending if CTL+C is pressed.
//       // Console.TreatControlCAsInput = true;

//       String bigString = "";
      
//       readTextFromFile();

//       int lineCounter = 3;
//       int keyCounter = 0;
 
//       var strBuilder = new StringBuilder();

//       while (true)
//       {


//          Console.SetCursorPosition(0,0);

//             var timeElapsed = DateTime.Now - programStartTime;

//              Console.WriteLine($"{timeElapsed} and key pressed {keyCounter} and {readTextFromFile()[lineCounter-2]} and cl : {lineCounter}");

              

//             ConsoleKeyInfo x = Console.ReadKey(true);
         
//             keyCounter++;
            
           

//            if(readTextFromFile()[lineCounter-2] <= keyCounter){
//                lineCounter += 2;
//                keyCounter = 0;
//                Console.SetCursorPosition(0,lineCounter);
//             }
//             else{

//             }
          

//             char y = x.KeyChar;

//             strBuilder.Append(y);

//             bigString = strBuilder.ToString();
          
//             if (y == 8)                                        //when Backspace Pressed
//             {
//                bigString.Remove(bigString.Length - 1, 1);
//                Console.WriteLine(bigString);

//             }
            
            

//             Console.SetCursorPosition(0,3);
          
//             Console.WriteLine(bigString);
 

         

//       }
//    }

{
    
            Form mainForm = new Form();
            Label lblFirst = new Label();
            mainForm.Width = 300;
            mainForm.Height = 400; 
            lblFirst.Text = "Hello World";
            lblFirst.Location = new Point(150,200);
            mainForm.Controls.Add(lblFirst);
            Application.Run(mainForm);
    
}

}

   static int[] readTextFromFile()
   {
      String sampleTextfilePath = "C:\\Users\\user\\Desktop\\60days\\Day 2\\typingSpeedPractice_csharp\\sample.txt";
      var contentOfSampleFile = File.ReadAllLines(sampleTextfilePath);

      int cursorPos = 0;

      int numberOfLinesTextFile = 0;
      Console.Clear();
      foreach (String x in contentOfSampleFile)
      {
         int countCharInString = x.Length;
         cursorPos += 2;
         Console.SetCursorPosition(0, cursorPos);
         Console.WriteLine($"{x}   Ln : {countCharInString}");
         numberOfLinesTextFile++;
      }

      int[] textFileInfo = new int[numberOfLinesTextFile + 1];

      textFileInfo[0] = numberOfLinesTextFile; //first elt of array [0] is Number of lines from the txt

      numberOfLinesTextFile = 0;

      foreach (String x in contentOfSampleFile)
      {
         textFileInfo[numberOfLinesTextFile + 1] = x.Length;
         numberOfLinesTextFile++;

      }


      

      return textFileInfo;
   }


   static bool goToNextLine(String oneLine, int currentLine)
   {
      if (oneLine.Length < currentLine)
      {
         return true;
      }
      return false;
   }


   void checkIfWritingIsComplete()
   {

   }
}