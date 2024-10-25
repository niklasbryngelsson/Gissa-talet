// Ett sätt att slumpa ett tal mellan 1-100
// Ge användaren info om vad den ska göra
// Kunna läsa in användarens input 
// Säga åt användaren att den hade fel
// Säga till användare att den hade rätt
// En game loop så att spelet inte avslutas efter första gissningen - while 

Random random = new Random();
int randomValue = random.Next(1, 101);

AudioPlayer player = new();
player.PlayAudio();

int life = 7;

while (true)
{
    life--;
    Console.WriteLine($"Antal liv: {life}");
    if (life == 0)
    {

        TextWriter.FailText("Du förlorade");
        break;
    }
    Console.Write("Gissa ett tal mellan 1-100: ");
    int input = 0;

    if (!int.TryParse(Console.ReadLine(), out input))
    {
        Console.WriteLine("Vänligen skriv ett tal");
        continue;
    }

    if (input > 100)
    {
        TextWriter.WarningText("Talet är över 100. Skriv in ett nytt tal");
        continue;
    }

    if (input > randomValue)
    {
        TextWriter.WarningText("Talet är lägre.");
        continue;
    }

    if (input < randomValue)
    {
        TextWriter.WarningText("Talet är högre.");
        continue;
    }

    if (input == randomValue)
    {
        TextWriter.SuccessText("Du gissade rätt!!");
        break;
    }
}



// Max antal gissningar 
// Räkna ut om spelaren har förlorat 
// Ge spelaren tips om talet är högre eller lägre än gissningen
// Lägg till kommentar om talet inte är inom  begränsingarna
