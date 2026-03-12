using System;

public class SimpleQueue<T>
{
    private T[] _queue;
    private int _count;
    public int Count => _count;
    public bool IsFull => _count > _queue.Length - 1;
    public bool IsEmpty => _count == 0;

    public SimpleQueue(int cap)
    {
        _queue = new T[cap];
    }

    public void Enqueue(T item)
    {
        if (IsFull)
        {
            Console.WriteLine("큐가 가득 찼습니다.");
            return;
        }

        _queue[_count++] = item;
    }

    public T Dequeue()
    {
        if (IsEmpty)
        {
            Console.WriteLine("큐가 비어있습니다.");
            return default(T);
        }

        var result = _queue[0];
        for (int i = 0; i < _count - 1; i++)
        {
            _queue[i] = _queue[i + 1];
        }
        _count--;

        return result;
    }

    public T Peek()
    {
        if (IsEmpty)
        {
            Console.WriteLine("큐가 비어있습니다.");
            return default(T);
        }

        return _queue[0];
    }
}