using AddFractionsWholeNumbersAndNegatives;

namespace AddFractionsTests;

public class AddFractionTests {
    [Fact]
    public void SumPositiveWholeNumberAndZero() {
        Assert.Equal(new Fraction(1), new Fraction(1).Add(new Fraction(0)));
        Assert.Equal(new Fraction(5), new Fraction(0).Add(new Fraction(5)));
    }

    [Fact]
    public void SumPositiveWholeNumbers() {
        Assert.Equal(new Fraction(2), new Fraction(1).Add(new Fraction(1)));
    }

    [Fact]
    public void SumNegativeWholeNumbers() {
        Assert.Equal(new Fraction(0), new Fraction(1).Add(new Fraction(-1)));
        Assert.Equal(new Fraction(1), new Fraction(2).Add(new Fraction(-1)));
        Assert.Equal(new Fraction(-3), new Fraction(-1).Add(new Fraction(-2)));
    }
}