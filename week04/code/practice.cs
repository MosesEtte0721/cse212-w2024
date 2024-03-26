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