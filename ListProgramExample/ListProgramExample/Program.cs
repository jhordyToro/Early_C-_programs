// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//add , remove, capacity, clear, contains.

List<string> listFood = new List<string>();

listFood.Add("rice");
listFood.Add("chicken");
listFood.Add("meat");
listFood.Add("avocado");

for (int i = 0; i < listFood.Count; i++) { 
    Console.WriteLine(listFood[i]);
}

listFood.Add("arroz");
listFood.Remove(listFood[1]);


for (int i = 0; i < listFood.Count; i++)
{
    Console.WriteLine(listFood[i]);
}
