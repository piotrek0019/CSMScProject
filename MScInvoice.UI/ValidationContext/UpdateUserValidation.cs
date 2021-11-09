using FluentValidation;
using MScInvoice.Application.MyAccount;

namespace MScInvoice.UI.ValidationContext
{
    public class UpdateUserValidation
        : AbstractValidator<MyUserViewModel>
    {
        public UpdateUserValidation()
        {
            RuleFor(x => x.Address1).NotNull();
        }
    }
}
