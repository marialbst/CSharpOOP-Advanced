namespace _05.Security_Door.Models
{
    using Interfaces;

    public class KeyCardCheck : SecurityCheck
    {
        private ISecurityUi securityUI;

        public KeyCardCheck(ISecurityUi securityUI)
        {
            this.securityUI = securityUI;
        }

        private bool IsValid(string code)
        {
            return true;
        }

        public override bool ValidateUser()
        {
            string code = this.securityUI.RequestKeyCard();
            if (this.IsValid(code))
            {
                return true;
            }

            return false;
        }
    }
}