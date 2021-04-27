using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    public int levelToLoad;

    void onTriggerEnter2D(Collider2D collision)
    {
      GameObject collisionGameObject = collision.gameObject;

      if(collisionGameObject.name == "Player")
      {
        SceneManager.LoadScene(levelToLoad);
      }
    }
}
