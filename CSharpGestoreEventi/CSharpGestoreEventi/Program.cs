// TEST TECNICOH

using CSharpGestoreEventi;

//Questa booleana viene usata per ciclare l'inserimento dati qualora l'utente inserisca qualcosa di incorretto.
bool isUserInputValid = false;

/*
//Questa parte del codice è riferita alla Milestone 2. È stata commentata al fine di velocizzare il testing del resto del programma.

while (!isUserInputValid)
{
    //Chiediamo all'utente le informazioni necessarie a creare un evento.

    Console.Write("Inserisci il titolo dell'evento: ");
    string inputTitle = Console.ReadLine();

    Console.Write("Inserisci la data dell'evento: ");
    string inputDate = Console.ReadLine();

    Console.Write("Inserisci il numero di posti totali: ");
    int inputCapacity = Int32.Parse(Console.ReadLine());

    Console.Write("Inserisci il numero di posti da prenotare: ");
    int inputPreorders = Int32.Parse(Console.ReadLine());

    //Crea l'evento con le informazioni immesse dall'utente. Se è tutto valido, inizia a chiedere all'utente se vuole disdire delle prenotazioni.
    //Il programma continua fino a quando l'utente non risponde qualcosa di diverso da "si".

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

        //Cambiamo l'argomento del while, in quanto l'evento è stato creato correttamente.
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

//Chiediamo il titolo del programma e il numero di eventi. Queste richieste vengono ripetute fino a quando l'utente non inserisce dei valori validi.

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

//Dichiariamo il programma con le informazioni appena ottenute.
EventSchedule userSchedule = new(inputScheduleTitle);

//Aggiungiamo eventi fino a quando non arriviamo al numero specificato dall'utente.
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

//Creiamo una conferenza. Una conferenza è un evento più specifico e riporta informazioni uniche a sé (il relatore e il prezzo).
EventConference conferenceTest = new("Conferenza sulle conferenze", "27/03/2023", 200, "Mario Rossi", 15.00);

//Aggiungiamo la conferenza al programma e stampiamo poi tutto.
userSchedule.AddEventToSchedule(conferenceTest);

userSchedule.PrintEventCount();
userSchedule.PrintScheduleDetails();

//Chiediamo all'utente di inserire una data, e restituisce una lista di eventi che si tengono a quella data.
//Continuamo a chiedere finché l'utente non inserisce una data valida.

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
