using System.Threading.Tasks;

namespace Buggy.Data
{
    public class TicketStateContainer
    {
        public CreateTicketModel? LastModel { get; set; }
        public NewTicketResponse? LastResponse { get; set; }
    }
    public class TicketService
    {
        public virtual async Task<NewTicketResponse> CreateAsync(CreateTicketModel ticket)
        {
            await Task.Delay(1);
            return new NewTicketResponse { };
        }
    }
}
