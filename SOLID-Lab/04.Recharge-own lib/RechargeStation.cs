namespace _04.Recharge_own_lib
{
    using Interfaces;

    public class RechargeStation
    {
        public void Recharge(IRechargeable rechargeable)
        {
            rechargeable.Recharge();
        }
    }
}