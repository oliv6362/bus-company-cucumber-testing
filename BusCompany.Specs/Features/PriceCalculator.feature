Feature: PriceCalculator

Price Calculator that calculates bus prices based on distance and fees
    
@pricing
Scenario Outline: Calculate bus price from a valid distance
    Given the distance is <distance>
    When the price has been calculated
    Then the price should be <price>
    
    Examples: 
    | distance | price |
    | 0        | 2500  |
    | 1        | 2510  |
    | 100      | 3498  |
    | 501      | 6704  |
    

Scenario: Reject negative distance
    Given the distance is -1
    When the price has been calculated
    Then the distance should be rejected