using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class levelcontrol : MonoBehaviour
{
    public string LevelName;
    
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            SceneManager.LoadScene(LevelName);
        }
    }
}
