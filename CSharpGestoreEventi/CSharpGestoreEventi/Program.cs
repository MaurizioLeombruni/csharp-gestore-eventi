// TEST TECNICOH

using CSharpGestoreEventi;

Event eventoTest = new("Come accarezzare le aquile reali", "27/12/2022", 300);

bool isUserInputValid = false;
/*
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
    

    
}*/

string inputScheduleTitle = "";
int inputEventCount = 0;

int counter = 0;

while (inputScheduleTitle.Length == 0 || inputScheduleTitle == null)
{
    try
    {
        Console.Write("Inserisci il titolo del tuo programma eventi: ");
        inputScheduleTitle = Console.ReadLine();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

while (inputEventCount <= 0)
{
    try
    {
        Console.Write("Inserisci il numero di eventi da inserire: ");
        inputEventCount = Int32.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

}

EventSchedule userSchedule = new(inputScheduleTitle);

while(counter < inputEventCount)
{
    try
    {
        Console.Write("Inserisci il titolo dell'evento: ");
        string inputTitle = Console.ReadLine();

        Console.Write("Inserisci la data dell'evento: ");
        string inputDate = Console.ReadLine();

        Console.Write("Inserisci il numero di posti totali: ");
        int inputCapacity = Int32.Parse(Console.ReadLine());

        Console.Write("Inserisci il numero di posti da prenotare: ");
        int inputPreorders = Int32.Parse(Console.ReadLine());

        Event eventToAdd = new(inputTitle, inputDate, inputCapacity);

        userSchedule.AddEventToSchedule(eventToAdd);

        Console.WriteLine("Evento aggiunto al programma.");

        counter++;
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

userSchedule.PrintEventCount();
userSchedule.PrintScheduleDetails();

while (!isUserInputValid)
{
    try
    {
        Console.Write("Cerca eventi in base alla data: ");
        string dateToCheck = Console.ReadLine();

        List<Event> eventsToCheck = userSchedule.GetEventsByDate(dateToCheck);

        if(eventsToCheck.Count > 0)
        {
            Console.WriteLine("Alla data specificata si terranno i seguenti eventi:");

            foreach (Event element in eventsToCheck)
            {
                Console.WriteLine(element.ToString());
            }
        }

        isUserInputValid = true;
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

userSchedule.ClearSchedule();
