
class Queue
{
    private Node _head;
    private Node _tail;
    private int _length = 0;

    public void Clear()
    {
        //empty the queue

        while (_head != null)       //while head is not null
        {
            _head.Data = null;      //head data is null
            _head = _head.Next;     //set new head as old head's next
            _length -= 1;           //subtract one from length
        }

        Console.WriteLine("The queue has been cleared.");
    }

    public void EnQueue(object data)
    {
        //Add node to back of Queue and return its data

        //CREATE NEW NODE
        Node newTail = new Node();

        //STORE newData IN newTail NODE
        newTail.Data = data;

        if (_head == null && _tail == null)
        {
            _head = newTail;
            _tail = newTail;
        }
        else
        {
            _tail.Next = newTail;
            _tail = newTail;
        }

        Console.WriteLine("Inserted into the Queue: {0}", _tail.Data);
        //plus one length
        _length++;
    }

    public object DeQueue()
    {
        if( _head == null)
        {
            throw new InvalidOperationException("The Queue is empty.");            
        }

        //remove node from front of the Queue and return its data
        object data = _head.Data;

        _head.Data = null;

        _head = _head.Next;
        
        if( _head == null)
        {
            _tail = null;
        }

        Console.WriteLine("Removed from the Queue: {0}", data);

        _length--;
        
        return data;

        
        
    }

    public object Peek()
    {
        //returns nodes data at front of the queue
        if (_head == null)
        {
            throw new InvalidOperationException("The Queue is empty.");
        }
        else
        {
            return _head.Data;
        }
        
    }

    public int Length()
    {
        //return size of the queue

        return _length;

    }

    public bool IsEmpty()
    {
        //returns if queue is empty or not

        if(_head == null && _tail == null)
        {
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        Node temp = new Node();
        temp = this._head;
        string info = "";

        for (int i = 0; i < _length; i++)
        {
            if (temp != null)
            {
                info = temp.Data.ToString() + (", ") + (info);
                temp = temp.Next;
            }
        }
        return info;
    }
}

