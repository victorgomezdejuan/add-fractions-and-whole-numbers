using AddFractionsWholeNumbersAndNegatives;

namespace AddFractionsTests;

public class AddFractionTests {
    [Fact]
    public void OneSummandIsZero() {
        Assert.Equal(new Fraction(1), new Fraction(1).Add(new Fraction(0)));
        Assert.Equal(new Fraction(5), new Fraction(0).Add(new Fraction(5)));
    }

    [Fact]
    public void SumWholeNumbers() {
        Assert.Equal(new Fraction(2), new Fraction(1).Add(new Fraction(1)));
    }
}