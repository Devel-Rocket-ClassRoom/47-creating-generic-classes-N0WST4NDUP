using System;

ObjectPool<Bullet> pool = new(3);
var b1 = pool.Get();
var b2 = pool.Get();
var b3 = pool.Get();

Console.WriteLine($"=== 총알 발사 ===");
b1.Fire(10, 20);
b2.Fire(30, 40);
b3.Fire(50, 60);
Console.WriteLine($"활성: {pool.ActiveCount}, 비활성: {pool.AvailableCount}");
Console.WriteLine();

Console.WriteLine("=== 풀 초과 시도 ===");
Console.WriteLine($"{(pool.Get() is null ? "풀이 가득 찼습니다!" : null)}");
Console.WriteLine();

Console.WriteLine("=== 반납 후 재사용 ===");
pool.Return(b1);
Console.WriteLine($"활성: {pool.ActiveCount}, 비활성: {pool.AvailableCount}");
var b4 = pool.Get();
b4.Fire(100, 200);
Console.WriteLine($"활성: {pool.ActiveCount}, 비활성: {pool.AvailableCount}");