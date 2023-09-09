using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            Invoke("CrashDetection", 1f); //Delay 1s
        }
    }
    void CrashDetection()
    {
        SceneManager.LoadScene(0);
    }
}
