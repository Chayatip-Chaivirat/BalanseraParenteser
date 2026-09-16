using System;
using System.Collections.Generic;

class Balance
{
    public static void Main()
    {
        string s = Console.ReadLine();          // Sätt s till strängen med parenteser.
                                                // Första tecknet är s[0], s[s.Lenngth-1] det sista.

        Stack<char> stack = new Stack<char>();  // Skapa en stack.

        // Det är inte säkert att man vill ha just en stack
        // av char, det beror på hur algorimen
        // implementeras, men en stack behövs.
        // Gör push med stack.Push(…), pop med stack.Pop()
        // Kolla om stacken är tom med ”stack.Count == 0”.
        // Fyll i själva algoritmen för att kolla s här.
        // Använd Console.WriteLine(…) för att skriva ut antingen 0 eller 1 som slutresultat.

        bool balanced = true; // Variabel för att hålla reda på om strängen är balanserad

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i]; // Hämta tecknet vid index i
            if (c == '(' || c == '[') // Kontrollera om tecknet är en öppnande parentes
            {
                stack.Push(c); // Lägg till öppnande parentes på stacken
            }
            else
            {
                if (stack.Count == 0) // Om stacken är tom, strängen är inte balanserad
                {
                    balanced = false;
                    break;
                }

                char opening = stack.Pop(); // Ta bort det senaste öppnande tecknet från stacken

                if (c == ')' && opening != '(') // Kontrollera om ( )  matchar
                {
                    balanced = false; // Om det inte matchar, strängen är inte balanserad
                    break;
                }
                if (c == ']' && opening != '[') // Kontrollera om [ ] matchar
                {
                    balanced = false; // Om det inte matchar, strängen är inte balanserad
                    break;
                }
            }
        }
        if (stack.Count != 0) // Om stacken inte är tom efter att ha gått igenom hela strängen, strängen är inte balanserad
        {
            balanced = false;
        }
        if (balanced)
        {
            Console.WriteLine("1"); // Strängen är balanserad
        }
        else
        {
            Console.WriteLine("0"); // Strängen är inte balanserad
        }
    }
}