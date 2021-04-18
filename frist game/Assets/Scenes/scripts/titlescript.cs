using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlescript : MonoBehaviour
{
    public scriptmannage manager;
  
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            manager.LoadGameScene();
            Destroy(this);
        }
    }
}
