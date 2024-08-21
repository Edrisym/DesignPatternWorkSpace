namespace DesignPattern.Builder.Pizza;

public class Pizza
{
    public bool HasExtraCheese { get; set; }
    public int MeatSlices { get; set; }
    public string[] Vegetables { get; set; } = [];
    public bool HasPineapple { get; set; }
    public bool HasExtraSauce { get; set; }
    public bool IsSpicy { get; set; }

    public override string ToString()
    {
        return 
            $"This pizza has {(HasExtraCheese ? "extra cheese" : "no extra cheese")}, " +
            $"{MeatSlices} slices od meet, and includes " +
            $"{(Vegetables.Length > 0 ? string.Join(", ", Vegetables) : "no vegetables")} " +
            $"{(HasPineapple ? "with pineapple" : "without pineapple")}, " +
            $"{(HasExtraSauce ? "extra sauce" : "no extra sauce")} " +
            $"{(IsSpicy ? "and is spicy" : "and is not spicy")}.";

    }

    private static bool StartsWithVowel(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        char firstChar = char.ToLower(input[0]);

        return "aeiou".Contains(firstChar);
    }
}