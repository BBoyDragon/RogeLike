using Code.Controllers.Bootstrap;
using Code.Controllers.ControllerUtility;
using UnityEngine;
using Zenject;

namespace Code.Utility
{
    public class BootstrapInstaller: MonoInstaller
    {
        private const string ControllerRunnerPrefabPath = "ControllerExecutorPrefab";
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<BootstrapController>().AsSingle();
            Container.Bind<ControllerRunner>().FromComponentInNewPrefabResource(ControllerRunnerPrefabPath).AsSingle();
            Container.InstantiatePrefabResource(ControllerRunnerPrefabPath);
        }
    }
}