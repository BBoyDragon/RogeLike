using System.Collections;
using System.Collections.Generic;
using Code.Controllers.ControllerUtility;
using UnityEngine;
using Zenject;

public class MainGameInstaller : MonoInstaller
{
    private const string ControllerRunnerPrefabPath = "ControllerExecutorPrefab";
    public override void InstallBindings()
    {
        Container.Bind<ControllerRunner>().FromComponentInNewPrefabResource(ControllerRunnerPrefabPath).AsSingle();
    }
}
