using AddFractionsWholeNumbersAndNegatives;

namespace AddFractionsTests;
public class FractionEqualsTests {
    [Fact]
    public void SameValues() {
        Assert.True(new Fraction(1).Equals(new Fraction(1)));
    }
}
