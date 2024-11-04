using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStart : MonoBehaviour
{
    public int MiniGame { get; private set; }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(MiniGame);
    }

}