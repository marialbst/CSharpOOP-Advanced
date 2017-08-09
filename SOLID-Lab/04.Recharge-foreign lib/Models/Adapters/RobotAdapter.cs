namespace _04.Recharge_foreign_lib.Models.Adapters
{
    using Interfaces;

    public class RobotAdapter : IRechargeable
    {
        private Robot robot;

        public RobotAdapter(string id, int capacity)
        {
            this.robot = new Robot(id, capacity);
        }

        public void Recharge()
        {
            this.robot.Recharge();
        }
    }
}
