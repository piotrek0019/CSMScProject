using FluentValidation;
using MScInvoice.Application.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.UI.ValidationContext
{
    public class UpdateItemValidations
        : AbstractValidator<UpdateItem.Request>
    {
        public UpdateItemValidations()
        {
            RuleFor(x => x.Price).NotNull();
            RuleFor(x => x.Price).NotNull();
        }
    }
}
