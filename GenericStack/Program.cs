using System;

Console.WriteLine("=== int 큐 (용량 3) ===");
SimpleQueue<int> q1 = new(3);
Console.WriteLine("Enqueue: 10, 20, 30");
q1.Enqueue(10);
q1.Enqueue(20);
q1.Enqueue(30);
Console.WriteLine($"Count: {q1.Count}, IsFull: {q1.IsFull}");
q1.Enqueue(40);
Console.WriteLine($"Peek: {q1.Peek()}");
Console.WriteLine($"Dequeue: {q1.Dequeue()}");
Console.WriteLine($"Dequeue: {q1.Dequeue()}");
Console.WriteLine($"Count: {q1.Count}, IsFull: {q1.IsFull}");
Console.WriteLine();

Console.WriteLine("=== string 큐 (용량 2) ===");
SimpleQueue<string> q2 = new(2);
Console.WriteLine("Enqueue: Hello, World");
q2.Enqueue("Hello");
q2.Enqueue("World");
Console.WriteLine($"Dequeue: {q2.Dequeue()}");
Console.WriteLine($"Dequeue: {q2.Dequeue()}");
Console.WriteLine($"Dequeue: {q2.Dequeue()}");
Console.WriteLine($"IsEmpty: {q2.IsEmpty}");
Console.WriteLine();