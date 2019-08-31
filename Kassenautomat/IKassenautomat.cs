namespace Kassenautomat
{
    internal interface IKassenautomat
    {
        void InsertCoin(int rappen);
        int GetValueInput();
        void AcceptValueInput();
        void NotAcceptValueInput();
        void GetValueTotal();
        int GetPercentCoin(int coin);
        CoinsQuantity GetQuantityCoins();
        CoinsQuantity GetChange(int change);
        int AlertCoinMinimum();
        int AlertCoinMaximum();
        int AlertValueTotalMaximum();
    }
}