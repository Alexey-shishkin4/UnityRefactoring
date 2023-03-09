using System;

namespace coins.Model
{
    public class Coins
    {
        public int amount;


        public Coins(int amount1)
        {
            if (amount1 > 0)
                amount = amount1;
        }

        public void PickupCoin()
        {
            amount++;
        }

        public bool TryDiscard(int price)
        {
            if (amount < price)
                return false;

            amount -= price;
            return true;
        }
    }
}
