using Code.Controllers.Character;
using Code.Controllers.ControllerUtility;
using Code.Controllers.Hub;
using Code.Views.Character;
using Code.Views.Hub;
using UnityEngine;
using Zenject;

namespace Code.Utility
{
    public class HubInstaller: MonoInstaller
    {
        private const string ControllerRunnerPrefabPath = "ControllerExecutorPrefab";
        // ReSharper disable Unity.PerformanceAnalysis
        public override void InstallBindings()
        {
            Container.Bind<HubView>()
                .FromComponentInNewPrefabResource("HubPrefabs/HubView")
                .AsSingle();
            Container.BindInterfacesTo<HubController>().AsSingle().NonLazy();
            
            Container.Bind<GameObject>().WithId("PlayerSpawnPoint").FromResolveGetter<HubView>(hubView => hubView.PlayerSpawnPoint);
            
            Container.Bind<CharacterView>().FromComponentInNewPrefabResource("CharacterView").AsSingle();
            Container.BindInterfacesTo<CharacterPositionController>().AsSingle().NonLazy();
            Container.Bind<ControllerRunner>().FromComponentInNewPrefabResource(ControllerRunnerPrefabPath).AsSingle();
            Container.InstantiatePrefabResource(ControllerRunnerPrefabPath);
        }
    }
}