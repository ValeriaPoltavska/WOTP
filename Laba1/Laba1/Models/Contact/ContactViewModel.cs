using FluentValidation;

namespace Laba1.Models.Contact
{
    public class ContactViewModel
    {
        public string EmailAdress { get; set; }
        public string Username { get; set; }
    }

    public class ContactViewModelValidator : AbstractValidator<ContactViewModel>
    {
        public ContactViewModelValidator()
        {
            RuleFor(x=>x.EmailAdress).NotNull().EmailAddress();
            RuleFor(x=>x.Username).MinimumLength(4);
        }
    }
}
