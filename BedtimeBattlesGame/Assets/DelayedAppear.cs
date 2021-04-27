﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedAppear : MonoBehaviour
{

  // Awake is called upon the initialization of the corresponding gameObect when the Scene loads
  void Awake()
  {
    hideDoor();
  }
    // Start is called before the first frame update
    void Start()
    {
      // Coroutine functions allows pausing its execution and resuming from the same point after a condition is met.
      StartCoroutine(doorAppear());
    }

    // IEnumerator's are used in Unity to stop the execution until some time or certain condition is met.
    public IEnumerator doorAppear()
    {
      // yield return is the point at which execution will pause and be resumed following the conditional or delayed action.
      yield return new WaitForSeconds(5f);
      // disables the rendering of the gameObject (Sprite)
      gameObject.GetComponent<Renderer>().enabled = true;
    }

    public void hideDoor()
    {
      gameObject.GetComponent<Renderer>().enabled = false;
    }


}
