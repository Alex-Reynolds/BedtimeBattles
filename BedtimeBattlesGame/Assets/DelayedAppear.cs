using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedAppear : MonoBehaviour
{

  void Awake()
  {
    hideDoor();
  }
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(doorAppear());
    }

    public IEnumerator doorAppear()
    {
      yield return new WaitForSeconds(5f);
      gameObject.GetComponent<Renderer>().enabled = true;
    }

    public void hideDoor()
    {
      gameObject.GetComponent<Renderer>().enabled = false;
    }


}
