using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{

    public void  GameOverScene()
    {
        FadeManager.Instance.LoadLevel("GameOverScene", 1.0f);
    }
}
