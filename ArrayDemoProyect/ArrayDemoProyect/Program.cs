

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[] typeCoffe;
float[] coffeValues;

typeCoffe = new string[] {"Expresso","Largo","Filtrado","Latte"};
coffeValues = new float[] {1.2f, 1.5f, 5.0f, 5.5f};

typeCoffe[1] = "long";

for (int i = 0; i < typeCoffe.Length; i++)
    Console.WriteLine($"the coffe {typeCoffe[i]} $: {coffeValues[i]}");