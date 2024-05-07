using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : ISceneController
{
    public void LoadHub()
    {
        SceneManager.LoadScene(1);
    }
}
