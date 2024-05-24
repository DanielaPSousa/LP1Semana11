using System;
using System.Collections.Generic;
using System.Collections;

public class ShortQueue<T> : ICollection<T>
{
    private Queue<T> _queue;
    private int _capacity;

    public ShortQueue() : this(5) { }

    public ShortQueue(int capacity)
    {
        _queue = new Queue<T>(capacity);
        _capacity = capacity;
    }

    public int Count => _queue.Count;

    public bool IsReadOnly => false;

    public void Add(T item)
    {
        if (_queue.Count >= _capacity)
        {
            _queue.Dequeue();
        }
        _queue.Enqueue(item);
    }

    public void Clear()
    {
        _queue.Clear();
    }

    public bool Contains(T item)
    {
        return _queue.Contains(item);
    }

    public void CopyTo(T[] array, int index)
    {
        _queue.CopyTo(array, index);
    }

    public bool Remove(T item)
    {
        if (_queue.Contains(item))
        {
            _queue.Dequeue();
            return true;
        }
        return false;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _queue.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}