using System;
using System.Collections.Generic;

public class ObjectPool<T> where T : class, IPoolable, new()
{
    private List<T> _available = new();
    private List<T> _active = new();
    private int _maxSize;

    public int ActiveCount => _active.Count;
    public int AvailableCount => _available.Count;

    public ObjectPool(int maxSize)
    {
        _maxSize = maxSize;
    }

    public T Get()
    {
        if (ActiveCount + AvailableCount >= _maxSize && AvailableCount == 0) return null;

        T target;
        if (AvailableCount > 0)
        {
            target = _available[AvailableCount - 1];
            _available.RemoveAt(AvailableCount - 1);
        }
        else
        {
            target = new T();
        }

        _active.Add(target);

        return target;
    }

    public void Return(T item)
    {
        item.Reset();
        _available.Add(item);
        _active.Remove(item);

        Console.WriteLine("총알 반납됨");
    }
}