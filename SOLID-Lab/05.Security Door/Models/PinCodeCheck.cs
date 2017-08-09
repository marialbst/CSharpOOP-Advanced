namespace _05.Security_Door.Models
{
    using Interfaces;

    public class PinCodeCheck : SecurityCheck
    {
        private ISecurityUi securityUI;

        public PinCodeCheck(ISecurityUi securityUI)
        {
            this.securityUI = securityUI;
        }

        private bool IsValid(int pin)
        {
            return true;
        }

        public override bool ValidateUser()
        {
            int pin = this.securityUI.RequestPinCode();
            if (this.IsValid(pin))
            {
                return true;
            }

            return false;
        }
    }
}