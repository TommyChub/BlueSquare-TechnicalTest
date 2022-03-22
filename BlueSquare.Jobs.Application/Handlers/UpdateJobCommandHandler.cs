using System.Threading;
using System.Threading.Tasks;
using BlueSquare.Domain.Dtos;
using BlueSquare.Jobs.Application.Commands;
using MediatR;

namespace BlueSquare.Jobs.Application.Handlers
{
    public class UpdateJobCommandHandler : IRequestHandler<UpdateJobCommand, JobDto>
    {
        public Task<JobDto> Handle(UpdateJobCommand request, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
