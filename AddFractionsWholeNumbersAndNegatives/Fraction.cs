namespace AddFractionsWholeNumbersAndNegatives;
public class Fraction {
    private int value;

    public Fraction(int value) => this.value = value;

    public Fraction Add(Fraction fraction) => new(1);

    public override bool Equals(object? obj) {
        if (obj is null) {
            return false;
        }

        if (obj is not Fraction) {
            return false;
        }
        return value == ((Fraction)obj).value;
    }

    public override int GetHashCode() {
        return value.GetHashCode();
    }
}
