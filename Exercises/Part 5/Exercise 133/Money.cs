namespace exercise_133
{
  public class Money
  {

    private int euros;
    private int cents;

    public Money(int euros, int cents)
    {
      if (cents > 99)
      {
        euros = euros + cents / 100;
        cents = cents % 100;
      }

      this.euros = euros;
      this.cents = cents;
    }

    public Money Plus(Money addition)
    {
            int newEuros = this.euros;
            int newCents = this.cents;

            Money newJam = (Money)addition;

            newEuros += newJam.euros;
            newCents += newJam.cents;
               
            if (newCents > 100)
            {
                newEuros++;
                newCents = newCents - 100;
            }

            Money newMoney = new Money(newEuros, newCents);
            // return the new Money object
            return newMoney;
    }

    public Money Minus(Money decreaser)
    {
            int newEuros = this.euros;
            int newCents = this.cents;

            Money newJam = (Money)decreaser;

            newCents -= newJam.cents;

            if (newCents < 0)
            {
                newEuros--;
                newCents = newCents + 100;
            }

            newEuros -= newJam.euros;

            if (newEuros < 0)
            {
                newEuros = 0;
                newCents = 0;
            }

            Money newMoney = new Money(newEuros, newCents);
            return newMoney;
        }

    public bool LessThan(Money compared)
    {
            Money comparedMoney = (Money)compared;
            if (this.euros < comparedMoney.euros)
            {
                return true;
            }
            else if (this.euros == comparedMoney.euros && this.cents < comparedMoney.cents)
            {
                return true;
            }
            return false;
    }

    public override string ToString()
    {
      string zero = "";
      if (cents < 10)
      {
        zero = "0";
      }

      return euros + "." + zero + cents + "e";
    }
  }
}
