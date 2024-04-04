using System;
using System.Text;

public class PriorityQueue
{
    private List<PriorityItem> _queue = new();

    // public PriorityQueue(string name, int turn): base(name,turn){

    // }

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue irregardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    // public void Enqueue(string value, int priority) 
    // {
    //     var newNode = new PriorityItem(value, priority);
    //     _queue.Enqueue(newNode);
    // }
public void Enqueue(string value, int priority) 
    {
    var newNode = new PriorityItem(value, priority);
    // [3, 12], [5,9], [8,11],[1,3]
 
    // Find the correct position to insert the new item based on its priority
    int i = _queue.Count - 1;
    while (i >= 0 && _queue[i].Priority < priority)
    {
        i--;
    }

    // Insert the new item at the correct position
    _queue.Insert(i + 1, newNode);
}




    public String Dequeue() {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            Console.WriteLine("The queue is empty.");
            return null;
        }

        // Find the index of the item with the highest priority to remove
        var highPriorityIndex = 0;
        for (int index = 1; index < _queue.Count - 1; index++) 
        {
            if (_queue[index].Priority >= _queue[highPriorityIndex].Priority)
                highPriorityIndex = index;
                
        }

        // Remove and return the item with the highest priority
        var value = _queue[highPriorityIndex].Value;
        this._queue.RemoveAt(highPriorityIndex);

        return value;
    }

    public void ToString() 
    {
        // StringBuilder sb = new StringBuilder();
        foreach (var item in this._queue)
        {
            Console.WriteLine($"{item.ValuePriority()}");
        }
        
      
    }
}

internal class PriorityItem 
{
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority) {
        Value = value;
        Priority = priority;
    }


    
    public  string ValuePriority() {
        return $"{Value} (Pri:{Priority})";
    }
}