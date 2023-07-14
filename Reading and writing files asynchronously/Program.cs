Console.WriteLine("inserisci alcuni nomi di persone:");

List<string> listOfPerson = new ();

for(int i= 0; i < 5; i++)
{
    string namePerson = Console.ReadLine();
    File.AppendAllText("C:\\Users\\rober\\Desktop\\esercizi c#\\Reading and writing files asynchronously\\Reading and writing files asynchronously\\file.txt", namePerson + "\n");
    listOfPerson.Add(namePerson);
}

Console.WriteLine("--------------------------");

Console.WriteLine("sto stampando i nomi della lista:");
var result = Task.Run(async () =>
{
    await Task.Delay(1000);
    return await File.ReadAllTextAsync("C:\\Users\\rober\\Desktop\\esercizi c#\\Reading and writing files asynchronously\\Reading and writing files asynchronously\\file.txt");
}).GetAwaiter().GetResult();

Console.WriteLine(result);




