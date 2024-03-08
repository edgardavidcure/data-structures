public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
        // Expected Result: 
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Edgar", 10);
        priorityQueue.Enqueue("David", 20);
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 2
        // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
        // Expected Result: Edgar, 10
        Console.WriteLine("Test 2");
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 
        //The for loop was not checking for lower or equal than the index
        Console.WriteLine("---------");

        // Test 3
        // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
        // Expected Result: Edgar, John, Smith
        Console.WriteLine("Test 3");
        priorityQueue.Enqueue("John", 10);
        priorityQueue.Enqueue("Smith", 20);
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 
        //None
        Console.WriteLine("---------");

        // Test 4
        // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
        // Expected Result: Edgar, John, Smith
        Console.WriteLine("Test 4");
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();


        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 
        //None
        Console.WriteLine("---------");
    }
}