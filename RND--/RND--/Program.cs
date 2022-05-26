// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

float[] pricesArray;

pricesArray = new float[10];
pricesArray[0] = 1.5f;
pricesArray[1] = 2.5f;
pricesArray[2] = 3f;
pricesArray[3] = 5f;

Random rnd = new Random();
Console.WriteLine("hello world, of random numbers");
Console.WriteLine($"{rnd.Next(1,10)}");

