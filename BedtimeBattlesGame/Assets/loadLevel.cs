﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    public int iLevelToLoad;
    public string sLevelToLoad;
    public bool useIntegerToLoadLevel = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //onTriggerEnter2D()
    }

    private void onTriggerEnter2D(Collider2D collision)
    {
      GameObject collisionGameObject = collision.gameObject;

      if(collisionGameObject.tag == "Player")
      {
        LoadScene();
      }
    }

    public void LoadScene()
    {
      if(useIntegerToLoadLevel)
      {
        SceneManager.LoadScene(iLevelToLoad);
      }
      else
      {
        SceneManager.LoadScene(sLevelToLoad);
      }
    }
}
