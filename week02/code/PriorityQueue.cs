public class PriorityQueue {
    private List<PriorityItem> _queue = new List<PriorityItem>();

    public void Enqueue(string value, int priority) {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
    }

    public String Dequeue() {
        if (_queue.Count == 0) {
            Console.WriteLine("The queue is empty.");
            return null;
        }

        var highPriorityIndex = 0;
        for (int index = 1; index < _queue.Count; index++) {
            if (_queue[index].Priority > _queue[highPriorityIndex].Priority) {
                highPriorityIndex = index;
            }
        }

        var value = _queue[highPriorityIndex].Value;
        _queue.RemoveAt(highPriorityIndex); // Remove the item from the queue
        return value;
    }

    public override string ToString() {
        return $"[{string.Join(", ", _queue.Select(item => $"{item.Value} (Pri:{item.Priority})"))}]";
    }
}

internal class PriorityItem {
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority) {
        Value = value;
        Priority = priority;
    }
}
