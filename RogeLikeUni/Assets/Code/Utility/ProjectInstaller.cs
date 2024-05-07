using Code.Controllers.ControllerUtility;
using Zenject;

namespace Code.Utility
{
    public class ProjectInstaller: MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ISceneController>().To<SceneController>().AsSingle();
        }
    }
}