using System;
using System.Collections.Generic;

public class Practice 
{
    public Practice? Next;
    public Practice? Prev;
    public string Data {get; set;}

    public Practice(string data)
    {
        Data = data;
    }
    
}

public class AllNodes
{
    public Practice? _Head;
    public Practice? _Tail;

    public void InsertHead(string data)
    {
        var newNode = new Practice(data);
        if(newNode == null)
        {
            this._Head = newNode;
            this._Tail = newNode;
        }
        else
        {
            newNode.Next = this._Head;
            _Head.Prev = newNode;
            _Head = newNode;
        }
    }

    public void InsertTail(string data)
    {
        var newNode = new Practice(data);
        if(newNode == null)
        {
            this._Head = newNode;
            this._Tail = newNode;

        }
        else
        {
            this._Tail.Prev = _Tail;
            this._Tail.Next = newNode;
            this._Tail = newNode;
        }
    }

    public void InsertMiddle(string data)
    {
        var newNode = new Practice(data);
        if(this._Head == null)
        {
            this._Head = newNode;
            this._Tail = newNode;
        }
        else
        {
            Practice slow = this._Head;
            Practice fast = this._Head;
            while(fast != null && fast.Next != null)
            {
                // move the slow to the next node
                slow = slow.Next;
                // move the fast to the next two nodes
                fast = slow.Next.Next;
            }

            // insert the new node at the middle
            newNode.Next = slow.Next;
            // adjust the link in the linked list
            slow.Next = newNode;
        }
    }
}


// public void Remove(int value) 
// {
//     Node? current = _head;
//     while (current != null)
//     {
//         if (current.Data == value)
//         {
//             // If node to be deleted is head node
//             if (current == _head)
//             {
//                 _head = _head.Next;
//                 if (_head != null)
//                 {
//                     _head.Prev = null;
//                 }
//                 else
//                 {
//                     _tail = null; // If head is null, then tail should also be null
//                 }
//             }
//             else
//             {
//                 // Connect the previous node and the next node
//                 if (current.Prev != null)
//                 {
//                     current.Prev.Next = current.Next;
//                 }
//                 if (current.Next != null)
//                 {
//                     current.Next.Prev = current.Prev;
//                 }
//                 else
//                 { 
//                     _tail = current.Prev; 
//                     if (_tail != null)
//                     {
//                         _tail.Next = null; // If tail is not null, its next should be null
//                     }
//                 } // If node to be deleted is tail node
//             }
//             return;
//         }
//         current = current.Next;
//     }
// }

/*

 public void Remove(int value) 
{
    Node? current = _head;
    while (current != null)
    {
        if (current.Data == value)
        {
            // If node to be deleted is head node
            if (current == _head)
            {
                _head = _head.Next;
                if (_head != null)
                {
                    _head.Prev = null;
                }
            }
            else
            {
                // Connect the previous node and the next node
                if (current.Prev != null)
                {
                    current.Prev.Next = current.Next;
                }
                if (current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                else
                { 
                    _tail = current.Prev; 
                } // If node to be deleted is tail node
            }
            return;
        }
        current = current.Next;
    }
}



    /// <summary>
    /// Search for all instances of 'oldValue' and replace the value to 'newValue'.
    /// </summary>
    public void Replace(int oldValue, int newValue) {
    Node? curr = _head;
    while(curr is not null)
    {
        if(curr.Data == oldValue)
        {
            curr.Data = newValue; // replace all instances of the value
        }
      
        curr = curr.Next;
    }
}


    /// <summary>
    /// Yields all values in the linked list
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator() {
        // call the generic version of the method
        return this.GetEnumerator();
    }

    /// <summary>
    /// Iterate forward through the Linked List
    /// </summary>
    public IEnumerator<int> GetEnumerator() {
        var curr = _head; // Start at the beginning since this is a forward iteration.
        while (curr is not null) {
            yield return curr.Data; // Provide (yield) each item to the user
            curr = curr.Next; // Go forward in the linked list
        }
    }

*/
