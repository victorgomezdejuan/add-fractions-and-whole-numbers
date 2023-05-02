using AddFractionsWholeNumbersAndNegatives;

namespace AddFractionsTests;
public class FractionEqualsTests {
    [Fact]
    public void SameValues() {
        Assert.True(new Fraction(1).Equals(new Fraction(1)));
        Assert.True(new Fraction(0).Equals(new Fraction(0)));
    }

    [Fact]
    public void DifferentValues() {
        Assert.False(new Fraction(1).Equals(new Fraction(2)));
        Assert.False(new Fraction(0).Equals(new Fraction(1)));
        Assert.False(new Fraction(1).Equals(new Fraction(0)));
    }
}
