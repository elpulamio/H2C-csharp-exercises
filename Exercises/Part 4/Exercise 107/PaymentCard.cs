using System;

namespace exercise_107
{
    class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance;
        }

        public override string ToString()
        {
            // write code here
            return "The card has a balance of " + this.balance + " euros";
        }

        public void EatLunch()
        {
            this.balance = this.balance - 10.60;
        }

        public void DrinkCoffee()
        {
            this.balance = this.balance - 2.0;
        }
    }
}