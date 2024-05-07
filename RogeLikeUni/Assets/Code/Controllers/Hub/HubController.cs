
using Code.Views.Hub;
using Zenject;

namespace Code.Controllers.Hub
{
    public class HubController: IHubController
    {
        [Inject] private HubView _hubView;
    }
}