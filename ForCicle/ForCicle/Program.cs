// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for (int i = 0 /*condicion inicial*/; i <= 50/*limite de repeticiones*/; i = i + 10 /*incremento*/)
    Console.WriteLine($"#{i}");

for (int i = 0, j = 0; i < 10 && j > -10; i++, j--)
    Console.WriteLine($"i : {i} \nj : {j}");