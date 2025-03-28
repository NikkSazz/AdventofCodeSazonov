 private static int Three(string[] input, bool partOne)
 {
     int len;
     int alpha = 0; //Right 1, Down 1
     int alphaX = 0;
     int beta = 0; //Right 3, Down 1
     int betaX = 0;
     int gamma = 0;  //Right 5, Down 1
     int gammaX = 0;
     int delta = 0; //Right 7, Down 1
     int deltaX = 0;
     int epsilon = 0; //Right 1, Down 2
     int epsilonX = 0;
     bool epsilonY = true;

     foreach (string s in input)
     {
         len = s.Length;

         betaX %= len;
         if (s[betaX] == '#') { beta++; }
         betaX += 3;

         if (!partOne)
         {
             alphaX %= len;
             if (s[alphaX] == '#') { alpha++; }
             alphaX++;

             gammaX %= len;
             if (s[gammaX] == '#') { gamma++; }
             gammaX += 5;

             deltaX %= len;
             if (s[deltaX] == '#') { delta++; }
             deltaX += 7;

             if (epsilonY)
             {
                 epsilonY = false;
                 epsilonX %= len;
                 if (s[epsilonX] == '#') { epsilon++; }
                 epsilonX++;

             }
             else { epsilonY = true; }
         }
     }
     if (partOne) { return beta; }
     Console.WriteLine(alpha + " " + beta + " " + gamma + " " + delta + " " + epsilon);
     int ans = alpha * beta * gamma * delta * epsilon;
     Console.WriteLine(ans);
     return ans;

 }
