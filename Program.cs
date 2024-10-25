// Ett sätt att slumpa ett tal mellan 1-100
// Ge användaren info om vad den ska göra
// Kunna läsa in användarens input 
// Säga åt användaren att den hade fel
// Säga till användare att den hade rätt
// En game loop så att spelet inte avslutas efter första gissningen - while 

while (true)
{
    Console.Write("Gissa ett tal mellan 1-100");
    int input = 0;

    if (int.TryParse(Console.ReadLine(), out input))
    {
        
    }
    break; 
}




// Max antal gissningar 
// Räkna ut om spelaren har förlorat 
// Ge spelaren tips om talet är högre eller lägre än gissningen
