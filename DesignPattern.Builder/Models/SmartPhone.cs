namespace DesignPattern.Builder.Models;

public class Smartphone
{
    public string BrandName { get; set; }
    public bool HasScreenOLED { get; set; }
    public string Battery { get; set; }
    public int NumberOfCamera { get; set; }
    public bool IsIOS { get; set; }
    public bool IsWaterProof { get; set; }

    public override string ToString()
    {
        return
            (StartsWithVowel(BrandName) ? "An " : "a ") +
            $"{BrandName} phone with " +
            (HasScreenOLED ? "an OLED screen" : "a normal screen") +
            $", capacity of {Battery} battery with" +
            (NumberOfCamera.Equals(1) ? $" {NumberOfCamera} camera " : $" {NumberOfCamera} cameras") +
            (IsWaterProof ? ",not water resistant" : ", water resistant") +
            " and the OS is " + (IsIOS ? "iOS" : "Android");
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