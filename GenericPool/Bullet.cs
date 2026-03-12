using System;

public class Bullet : IPoolable
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public bool IsActive;

    public void Fire(int x, int y)
    {
        X = x;
        Y = y;
        IsActive = true;

        Console.WriteLine($"총알 발사! 위치: ({X}, {Y})");
    }
    public void Reset()
    {
        X = 0;
        Y = 0;
        IsActive = false;
    }
}