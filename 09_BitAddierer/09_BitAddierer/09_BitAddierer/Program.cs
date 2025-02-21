using System;

public class Addierer
{
    public int Negation(int x) => (x == 0) ? 1 : 0;
    public int And(int x, int y) => (x == 1 && y == 1) ? 1 : 0;
    public int Or(int x, int y) => (x == 1 || y == 1) ? 1 : 0;
    public void Halbaddierer(int x, int y, out int s, out int c)
    {
        int z1 = And(Negation(x), y);
        int z2 = And(x, Negation(y));
        c = And(x, y);
        s = Or(z1, z2);
    }

    public void Volladdierer(int a, int b, int carryIn, out int sum, out int carryOut)
    {
        Halbaddierer(a, b, out int s1, out int c1);
        Halbaddierer(s1, carryIn, out sum, out int c2);
        carryOut = Or(c1, c2);
    }

    public string VierBitAddierer(string bin1, string bin2)
    {
        // Test, ob der string 4 Zeichenkette ist

        int carry = 0;
        int result = 0;

        for (int i = 0; i < 4; i++)
        {
            int bit1 = bin1[3 - i] - '0';   // -'0' konvertiert Zeichen in Zahl ('1' → 1, '0' → 0).
            int bit2 = bin2[3 - i] - '0';

            Volladdierer(bit1, bit2, carry, out int sum, out int newCarry);
            result |= (sum << i);
            carry = newCarry;
        }

        if (carry == 1)
        {
            result |= (carry << 4);
        }

        int maxLength = Math.Max(bin1.Length, bin2.Length);

        return Convert.ToString(result, 2).PadLeft(maxLength, '0');
    }

    public int BinaerZuDezimal(string binaerzahl)
    {
        return Convert.ToInt32(binaerzahl, 2);
    }

    public bool IstGueltigeBinaerzahl(string input)
    {
        if (input.Length != 4) return false;

        foreach (char c in input)
        {
            if (c != '0' && c != '1') return false;
        }

        return true;
    }
}

public class Program
{
    public static void Main()
    {
        Addierer addierer = new Addierer();

        Console.WriteLine("Geben Sie die erste 4-Bit-Binärzahl ein:");
        string bin1 = Console.ReadLine();
        while (!addierer.IstGueltigeBinaerzahl(bin1))
        {
            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine 4-Bit-Binärzahl ein:");
            bin1 = Console.ReadLine();
        }

        Console.WriteLine("Geben Sie die zweite 4-Bit-Binärzahl ein:");
        string bin2 = Console.ReadLine();
        while (!addierer.IstGueltigeBinaerzahl(bin2))
        {
            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine 4-Bit-Binärzahl ein:");
            bin2 = Console.ReadLine();
        }

        string summe = addierer.VierBitAddierer(bin1, bin2);

        Console.WriteLine($"Summe (Binär): {summe}");
        Console.WriteLine($"Summe (Dezimal): {addierer.BinaerZuDezimal(summe)}");
    }
}
