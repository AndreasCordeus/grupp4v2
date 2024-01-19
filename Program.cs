
﻿class Program { 

    static void Main(string[] args) 
    { 
       
        bool mainLoop = true;
        while (mainLoop) { 


            string? personNummer = UserInputs.SocialSecurityNumberInput();


            bool correct = LastNumberCalculation.ValidateSocialSecurityNumber(personNummer);


            if (correct) {
                Console.WriteLine("\n\t\tRätt!");
            } else {
                Console.WriteLine("\n\t\tFel!");
            }

        }

    }
}
