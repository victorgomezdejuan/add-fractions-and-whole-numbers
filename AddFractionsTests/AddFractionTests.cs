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

    [Fact]
    public void SumFractions_SameDenominator() {
        Assert.Equal(new Fraction(3, 5), new Fraction(1, 5).Add(new Fraction(2, 5)));
    }

    [Fact]
    public void SumFractions_DifferentDenominator() {
        Assert.Equal(new Fraction(7, 6), new Fraction(2, 3).Add(new Fraction(1, 2)));
    }

    [Fact]
    public void SumFractions_SameDenominator_Reduce() {
        Assert.Equal(new Fraction(3, 5), new Fraction(5, 25).Add(new Fraction(10, 25)));
    }

    [Fact]
    public void SumFractions_DifferentDenominator_Reduce() {
        Assert.Equal(new Fraction(5, 4), new Fraction(1, 2).Add(new Fraction(6, 8)));
    }

    [Fact]
    public void SumFractions_WithNegative() {
        Assert.Equal(new Fraction(3, 8), new Fraction(2, 4).Add(new Fraction(-1, 8)));
        Assert.Equal(new Fraction(5, 12), new Fraction(3, 4).Add(new Fraction(1, -3)));
        Assert.Equal(new Fraction(5, 12), new Fraction(1, -3).Add(new Fraction(3, 4)));
        Assert.Equal(new Fraction(-1, 12), new Fraction(1, 4).Add(new Fraction(-1, 3)));
        Assert.Equal(new Fraction(-7, 6), new Fraction(-1, 2).Add(new Fraction(-2, 3)));
        Assert.Equal(new Fraction(-7, 6), new Fraction(-1, 2).Add(new Fraction(2, -3)));
    }

    [Fact]
    public void Sum_Fractions_RedudeToZero() {
        Assert.Equal(new Fraction(0), new Fraction(1, 2).Add(new Fraction(-1, 2)));
    }
}