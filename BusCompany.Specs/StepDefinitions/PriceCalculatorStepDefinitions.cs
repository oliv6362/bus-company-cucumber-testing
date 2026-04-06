
namespace BusCompany.Specs.StepDefinitions;

[Binding]
public sealed class PriceCalculatorStepDefinitions
{
    private readonly PriceCalculator _priceCalculator = new PriceCalculator();
    private int _distance;
    private decimal _calculatedPrice;
    private Exception? _exception;
    
    [Given("the distance is {int}")]
    public void GivenTheDistanceIs(int distance)
    { 
        _distance = distance;
    }

    [When("the price has been calculated")]
    public void WhenThePriceHasBeenCalculated()
    {
        try
        {
            _calculatedPrice = _priceCalculator.CalculatePrice(_distance);
        }
        catch (Exception ex)
        {
            _exception = ex;
        }
    }

    [Then("the price should be {int}")]
    public void ThenThePriceShouldBe(int price)
    {
        Assert.Null(_exception);
        Assert.Equal(price, _calculatedPrice);
    }

    [Then("the distance should be rejected")]
    public void ThenTheDistanceShouldBeRejected()
    {
        Assert.NotNull(_exception);
        Assert.IsType<ArgumentException>(_exception);
    }
}
