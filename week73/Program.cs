
string[] FruitBasket = { "apples", "bananas", "oranges" };
string[] Pets = { "cats", "dogs", "fish", "hemsters" };
string[] Caracters = { "Harry", "Ron" };

PrintArrayElements(FruitBasket);
PrintArrayElements(Pets);
PrintArrayElements(Caracters);
static void PrintArrayElements(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {array[i]}");
    }
}
