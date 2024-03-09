public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: This test involves adding three items to the queue, 
        //each with a different priority. The priorities are assigned in 
        //the order they are added but vary in magnitude to test the priority queue's ability
        // to correctly identify and remove the item with the highest priority.

        // Expected Result:  When dequeuing, the item with the highest priority (Item2 with a priority of 3) 
        //should be removed first, regardless of its position in the queue: [Item1 (Pri:1), Item3 (Pri:2)]

        
        // Test 1:
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 3);
        priorityQueue.Enqueue("Item3", 2);
        Console.WriteLine($"After Enqueue: {priorityQueue}");
        Console.WriteLine($"Dequeue: {priorityQueue.Dequeue()}"); // Expected: Item2
        Console.WriteLine($"After Dequeue: {priorityQueue}");
        Console.WriteLine("---------");

        // Defect(s) Found: Item 3 is not removed from the queue after the first dequeue operation.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: This test checks the queue's behavior when attempting 
        //to remove an item from an empty queue. The queue is reset to be empty before the dequeue operation is attempted.

        // Expected Result: The operation should recognize the queue is empty and output an error message
        // indicating no items are available to be dequeued. This tests the queue's error handling and validation mechanisms.


        // Test 2:
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue(); // Reset queue
        Console.WriteLine($"Dequeue on Empty Queue: {priorityQueue.Dequeue()}"); 
        Console.WriteLine("---------");

        // Defect(s) Found: None

        Console.WriteLine("---------");

      
    }
}