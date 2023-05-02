namespace AddFractionsWholeNumbersAndNegatives;
public class Fraction {
    private readonly int enumerator;
    private readonly int denominator;

    public Fraction(int value) {
        enumerator = value;
        denominator = 1;
    }

    public Fraction(int enumerator, int denominator) {
        this.enumerator = enumerator;
        this.denominator = denominator;
    }

    public Fraction Add(Fraction fraction) {
        return new(enumerator + fraction.enumerator);
    }

    public override bool Equals(object? obj) {
        if (obj is null) {
            return false;
        }

        if (obj is not Fraction) {
            return false;
        }
        return enumerator == ((Fraction)obj).enumerator;
    }

    public override int GetHashCode() => enumerator.GetHashCode();

    public override string ToString() => enumerator.ToString();
}
