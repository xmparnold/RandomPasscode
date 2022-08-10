namespace RandomPasscode.Models;

public class RandSTR {

    public string? RandomString { get; set;}
    public int Count { get; set; } = 0;

    public RandSTR() {
        Generate();
        
    }

    public void Generate() {

        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random rand = new Random();
        string newString = "";

        for (int i = 0; i < 15; i++) {
            int index = rand.Next(1, chars.Length);

            newString += chars[index];
        }
        RandomString = newString;
        Count = Count + 1;
    }
}