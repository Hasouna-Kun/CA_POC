using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mediator.Query
{
    public  class GetUserInfoQuery
    {
        public int Id { get; set; }
    }

    public class GetUserInfoQueryValidator : AbstractValidator<GetUserInfoQuery>
    {
        public GetUserInfoQueryValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("id can't be less than or equal to zero");
        }
    }
}
