public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
       var PQueue = new PriorityQueue();
       var queue = new PriorityQueue();
            
        // new PriorityItem("system", 12);
        // new PriorityItem("system", 14);
        // new PriorityItem("system", 11);
        // new PriorityItem("system", 9);
        //  new PriorityItem("system", 23);
      

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result:  The test should pass because Uduak should be out of the queue
        Console.WriteLine("Test 1");
        Console.WriteLine("This is problem 2 test 1");

        // priorityQueue
        PQueue.Enqueue("Daniel", 8);
        PQueue.Enqueue("Mary", 4);
        PQueue.Enqueue("Udobot", 9);
        PQueue.Enqueue("Udofot", 2);
        PQueue.Enqueue("Edisana", 29);
        PQueue.Enqueue("Uduak", 29);
        
        var priority = PQueue.Dequeue();

        Console.WriteLine(priority == "Uduak"? " Uduak Priority test PASS ": "Priority Check FAILED");   
        PQueue.ToString();
        Console.WriteLine();
        Console.WriteLine("Additional test .............");
        Console.WriteLine();
  

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: this test should fail because Sunday should be out of the queue instead of Edikan
        Console.WriteLine("Test 2");

        // Defect(s) Found: 
        queue.Enqueue("Daniel", 8);
        queue.Enqueue("Mary", 4);
        queue.Enqueue("Udobot", 9);
        queue.Enqueue("Udofot", 2);
        queue.Enqueue("Edisana", 29);
        queue.Enqueue("Uduak", 29);
        queue.Enqueue("Edikan", 69);
        queue.Enqueue("Sunday", 69);
        var priorityEdikan = queue.Dequeue();
        Console.WriteLine(priorityEdikan == "Edikan"? "Edikan Priority test PASS ": "Priority test FAILED");
        queue.ToString();


        Console.WriteLine("---------");
      
        // Add more Test Cases As Needed Below
    }
}