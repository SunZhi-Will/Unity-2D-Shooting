using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//49824155
//讀取1號場景
public class StartGame : MonoBehaviour
{

    public void StartButtonClicked()
    {
        SceneManager.LoadScene(1);
    }
    public void HomeButtonClicked()
    {
        SceneManager.LoadScene(0);
    }
}
