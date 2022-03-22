using BlueSquare.Domain.Dtos;
using MediatR;

namespace BlueSquare.Jobs.Application.Queries
{
    public class GetJobByIdQuery : IRequest<JobDto>
    {
        public int JobId { get; set; }
    }
}
