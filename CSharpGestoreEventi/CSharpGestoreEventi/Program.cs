// TEST TECNICOH

using CSharpGestoreEventi;

Event eventoTest = new("Come accarezzare le aquile reali", "27/12/2022", 300);

eventoTest.AddPreorders(25);
eventoTest.CancelPreorders(5);
eventoTest.ToString();

Console.WriteLine("Hello, World!");
