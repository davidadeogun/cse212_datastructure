public class TakingTurnsQueue
{
    private readonly Queue<Person> _people = new();

    public int Length => _people.Count;

    public void AddPerson(string name, int turns)
    {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    public void GetNextPerson()
    {
        if (_people.Count == 0)
        {
            Console.WriteLine("No one in the queue.");
        }
        else
        {
            Person person = _people.Dequeue();
            Console.WriteLine(person.Name);
            if (person.Turns > 1)
            {
                person.Turns--;
                _people.Enqueue(person);
            }
        }
    }
}