namespace Assignment_01;

public class FixedSizeList<T>
{
    private readonly T[] items;
    private int count;

    public int Capacity => items.Length;
    public int Count => count;

    public FixedSizeList(int capacity)
    {
        if (capacity < 0)
            throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity cannot be negative.");

        items = new T[capacity];
    }

    public void Add(T item)
    {
        if (count >= items.Length)
            throw new InvalidOperationException("The list has reached its fixed capacity.");

        items[count] = item;
        count++;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= count)
            throw new IndexOutOfRangeException("The requested index is outside the valid range.");

        return items[index];
    }
}
