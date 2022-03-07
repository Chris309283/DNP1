using System.Text;
using System.Text.Json;
using S3_Ex2_Json_file_storage;

public class PersonPersistence
{
    public void StorePersons(List<Person> persons)
    {
        using StreamWriter writer = new StreamWriter("MyLines.txt");
        writer.WriteLine(JsonSerializer.Serialize(persons));
    }

    public string ReadFile()
    {
        StringBuilder stringBuilder = new StringBuilder();
        using StreamReader streamReader = new StreamReader("MyLines.txt");
        string? line;
        while ((line = streamReader.ReadLine())!=null)
        {
            stringBuilder.AppendLine(line);
        }

        return stringBuilder.ToString();
    }

    public List<Person>? GetPersonsList()
    {
        return JsonSerializer.Deserialize<List<Person>>(ReadFile());
    }
}