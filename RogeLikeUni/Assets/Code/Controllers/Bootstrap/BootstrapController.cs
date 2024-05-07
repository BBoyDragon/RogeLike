using Code.Utility.ControllerMethods;
using Zenject;

namespace Code.Controllers.Bootstrap
{
    public class BootstrapController: IBootstrapController 
    {
        [Inject] private ISceneController _sceneController;
        public void Start()
        {
            _sceneController.LoadHub();
        }
    }
} 