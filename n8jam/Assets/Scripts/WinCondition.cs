using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
   
    
  
    void Update()
    {
        if (transform.childCount == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
