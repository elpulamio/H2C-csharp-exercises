namespace exercise_128
{

  using System;
  public class Apartment
  {

    private int rooms;
    private int squares;
    private int pricePerSquare;

    public Apartment(int rooms, int squares, int pricePerSquare)
    {
      this.rooms = rooms;
      this.squares = squares;
      this.pricePerSquare = pricePerSquare;
    }

    public bool LargerThan(Apartment compared)
    {
        if (this.squares > compared.squares)
        {
            return true;
        }
        return false;
    }

    private int Price(int comparedSquares, int comparedPricePerSquare)
    {
        int thisPrice = this.squares * this.pricePerSquare;
        int comparedPrice = comparedSquares * comparedPricePerSquare;
        return thisPrice - comparedPrice;
    }

    public int PriceDifference(Apartment compared)
    {
        // Math.Abs returns the absolute value    
        int comparedSquares = compared.squares;
        int comparedPricePerSquare = compared.pricePerSquare;
        return Math.Abs(Price(comparedSquares, comparedPricePerSquare)); 
    }

    public bool MoreExpensiveThan(Apartment compared)
    {
        int thisPrice = this.squares * this.pricePerSquare;
        int comparedPrice = compared.squares * compared.pricePerSquare;
        if (thisPrice > comparedPrice)
        {
            return true;
        }
        return false;
    }
  }

}
