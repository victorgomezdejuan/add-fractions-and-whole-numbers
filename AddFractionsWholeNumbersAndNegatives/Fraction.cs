namespace AddFractionsWholeNumbersAndNegatives;
public class Fraction {
    private readonly int enumerator;
    private readonly int denominator;

    public Fraction(int value) : this(value, 1) { }

    public Fraction(int enumerator, int denominator) {
        this.enumerator = enumerator;
        this.denominator = denominator;
    }

    public Fraction Add(Fraction addend)
        => Reduce(new(enumerator * addend.denominator + addend.enumerator * denominator, denominator * addend.denominator));

    private static Fraction Reduce(Fraction fraction) => ReduceSign(ReduceGreatestCommonDivisor(fraction));

    private static Fraction ReduceSign(Fraction fraction) {
        if ((fraction.enumerator < 0 && fraction.denominator < 0) ||
            (fraction.enumerator > 0 && fraction.denominator < 0))
            return new Fraction(fraction.enumerator * (-1), fraction.denominator * (-1));

        return fraction.Clone();
    }

    private static Fraction ReduceGreatestCommonDivisor(Fraction fraction) {
        int minValue = Math.Min(fraction.enumerator, fraction.denominator);

        for (int i = minValue; i > 1; i--) {
            if (fraction.enumerator % i == 0 && fraction.denominator % i == 0) {
                return new(fraction.enumerator / i, fraction.denominator / i);
            }
        }

        return fraction.Clone();
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

    public override int GetHashCode() => enumerator ^ denominator;

    public override string ToString() => $"{enumerator}/{denominator}";

    public Fraction Clone() {
        return new Fraction(enumerator, denominator);
    }
}
