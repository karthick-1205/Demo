using System;
using System.Text;

public class Program {
   public static void Main (string[] args) {
      /*
      string[] camelCase = new string[] { "Fold3D", "ClearType", "FoldCAM", "Fold3dCAM", "Ab1ABCabc123", "ABCabc123", "CAM3d" };
      foreach(string c in camelCase) {
         string snakeCase = ConvertCamelToSnake (c);
         Console.WriteLine (snakeCase); // Output: my_camel_case_string
      }

     */
      
      Thread t = new Thread (ThreadFunction);
      t.Start ();
      for (int i=0; i < 100; i++) {
         Console.Write ("*"); 
         //Thread.Sleep (Random.Shared.Next (5));
         Thread.Sleep (5);
      }
      t.Join();
      Console.WriteLine (Thread.CurrentThread.Name);
      Console.WriteLine ("Thread finished");
   }
   /*
   public static string ConvertCamelToSnake (string input) {
      StringBuilder snakeCase = new StringBuilder ();

      for (int i = 0; i < input.Length; i++) {
         if (i > 0 && i != input.Length - 1 && i != input.Length - 2 && char.IsUpper (input[i]) || char.IsDigit (input[i])) {
            snakeCase.Append ('_');
         }
         snakeCase.Append (char.ToLower (input[i]));
      }
      return snakeCase.ToString ();
   }
   */
   static void ThreadFunction () { 
      for(int i=0; i<100; i++) { 
         Console.Write (".");
         //Thread.Sleep(Random.Shared.Next(5));
         Thread.Sleep (5);
      }
   } 
}


