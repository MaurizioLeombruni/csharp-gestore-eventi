// TEST TECNICOH

using CSharpGestoreEventi;

Event eventoTest = new("Come accarezzare le aquile reali", "27/12/2022", 300);

bool isUserInputValid = false;



while (!isUserInputValid)
{
    Console.Write("Inserisci il titolo dell'evento: ");
    string inputTitle = Console.ReadLine();

    Console.Write("Inserisci la data dell'evento: ");
    string inputDate = Console.ReadLine();

    Console.Write("Inserisci il numero di posti totali: ");
    int inputCapacity = Int32.Parse(Console.ReadLine());

    Console.Write("Inserisci il numero di posti da prenotare: ");
    int inputPreorders = Int32.Parse(Console.ReadLine());

    try
    {
        Event userEvent = new(inputTitle, inputDate, inputCapacity);

        userEvent.AddPreorders(inputPreorders);

        while(true)
        {
            Console.Write("Vuoi disdire dei posti? (si/no) // ");
            string userAnswer = Console.ReadLine();
            userAnswer = userAnswer.ToLower();

            if(userAnswer == "si")
            {
                Console.Write("Quanti posti vuoi disdire? // ");
                int userCancels = Int32.Parse(Console.ReadLine());
                userEvent.CancelPreorders(userCancels);
                userEvent.PrintPreorders();
            }
            else
            {
                Console.WriteLine(userEvent.ToString());
                userEvent.PrintPreorders();
                break;
            }
        }
        isUserInputValid = true;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

}
