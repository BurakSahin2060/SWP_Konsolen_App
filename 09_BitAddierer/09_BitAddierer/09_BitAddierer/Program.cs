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
        int carry = 0;
        int result = 0;

        for (int i = 0; i < 4; i++)
        {
            int bit1 = bin1[3 - i] - '0';
            int bit2 = bin2[3 - i] - '0';

            Volladdierer(bit1, bit2, carry, out int sum, out int newCarry);
            result |= (sum << i);
            carry = newCarry;
        }

        if (carry == 1)
        {
            result |= (carry << 4);
        }

        return Convert.ToString(result, 2).PadLeft(5, '0');
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
        
    }
}
