namespace DesignPatterns.SOLID.S
{
    class GeneralPhoneValidator : IPhoneValidator
    {
        public bool IsValid(Phone phone) =>
            !string.IsNullOrEmpty(phone.Model) && phone.Price > 0;
    }
}
