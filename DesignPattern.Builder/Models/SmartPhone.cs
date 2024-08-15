namespace DesignPattern.Builder.Models;

public class Smartphone
{
    public string BrandName { get; set; }
    public string Screen { get; set; }
    public string Battery { get; set; }
    public string Camera { get; set; }
    public string OS { get; set; }
    public string WaterProof { get; set; }

    public override string ToString()
    {
        return $"Smartphone Details:\n" +
               $"- Brand Name: {BrandName}\n" +
               $"- Screen: {Screen}\n" +
               $"- Battery: {Battery}\n" +
               $"- Camera: {Camera}\n" +
               $"- Operating System: {OS}\n" +
               $"- Water Proof: {WaterProof}";
    }
}