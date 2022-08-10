namespace RandomPasscode.Models;

public class RandSTR {

    public string? RandomString { get; set;}
    public int? Number { get; set; }

    public RandSTR() {
        Generate();
        Number = 1;
    }

    public void Generate() {

        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random rand = new Random();
        string newString = "";

        for (int i = 0; i < 15; i++) {
            int index = rand.Next(1, chars.Length);

            newString += chars[index];
        }
        Number += 1;
        RandomString = newString;
    }
}