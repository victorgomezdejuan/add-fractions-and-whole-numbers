using AddFractionsWholeNumbersAndNegatives;

namespace AddFractionsTests;

public class AddFractionTests {
    [Fact(Skip = "Until we implement equals")]
    public void OneSummandIsZero() {
        Assert.Equal(new Fraction(1), new Fraction(1).Add(new Fraction(0)));
    }
}