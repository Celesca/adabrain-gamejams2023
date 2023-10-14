using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMinigame1 : MonoBehaviour
{
    public void LoadMinigame()
    {
        Debug.Log("Scene Load");
        SceneManager.LoadSceneAsync(3);
    }
}
