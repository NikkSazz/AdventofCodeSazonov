 private static int Two(string[] input, bool partOne)
 {
     int valid = 0;

     string password;
     int appearances, min, max;
     char letter;
     int colon, dash;
     foreach (string s in input)
     {
         colon = s.IndexOf(':');
         appearances = 0;
         letter = s[colon - 1];
         password = s.Substring(colon + 2);
         dash = s.IndexOf('-');
         min = Int32.Parse(s.Substring(0, dash));
         max = Int32.Parse(s.Substring(dash + 1, s.IndexOf(" ") - dash - 1));
         //Console.WriteLine($"letter = {letter}, password = {password}, dash = {s[dash]}, min = {s.Substring(0, dash)}, max = {s.Substring(dash + 1, s.IndexOf(" ") - dash - 1)}, colon = {s.Substring(colon, 1)}");

         if (partOne)
         {
             foreach (char c in password)
             {
                 if (c == letter)
                 {
                     appearances++;
                 }
                 if (appearances > max)
                 {
                     break;
                 }
             }
             if (appearances >= min && appearances <= max)
             {
                 valid++;
             } 
         }
         else
         { //part two
             if (password[min -1] == letter ^ password[max-1] == letter)
             {
                 valid++;
             }
         }
     }

     return valid;
 }
