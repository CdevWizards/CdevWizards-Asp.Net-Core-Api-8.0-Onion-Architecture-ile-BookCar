using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.SocialMediaResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery :IRequest<List<GetSocialMediaQueryResult>>
    {
        
    }
}