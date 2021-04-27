using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RestartButton : MonoBehaviour
{


    public void restartScene()
    {
        SceneManager.LoadScene("Level One");
    }

}
