using System;

namespace Kassenautomat
{
    internal class Kassenautomat : IKassenautomat
    {
        public CoinsQuantity InsertedCustomerCoinValue { get; set; }
        public CoinsQuantity ValueInAutomat { get; set; }

        public void InsertCoin(int rappen)
        {
            InsertedCustomerCoinValue.Add(rappen);
        }
        
        public int GetValueInput()
        {
            return InsertedCustomerCoinValue.GetValue();
        }

        public void AcceptValueInput()
        {
            this.ValueInAutomat += this.InsertedCustomerCoinValue;
            this.InsertedCustomerCoinValue.Reset();
        }

        public void NotAcceptValueInput()
        {
            this.InsertedCustomerCoinValue.Reset();
        }

        public void GetValueTotal()
        {
            this.InsertedCustomerCoinValue.GetValue();
        }

        public int GetPercentCoin(int coin)
        {
            throw new NotImplementedException();
        }

        public CoinsQuantity GetQuantityCoins()
        {
            return this.ValueInAutomat;
        }

        public CoinsQuantity GetChange(int change)
        {
            if (change >= 500)
            {
                // todo: implement calculation of correct change...
            }

            return null;
        }
    

        public int AlertCoinMinimum()
        {
            throw new NotImplementedException();
        }

        public int AlertCoinMaximum()
        {
            throw new NotImplementedException();
        }

        public int AlertValueTotalMaximum()
        {
            throw new NotImplementedException();
        }
    }
}