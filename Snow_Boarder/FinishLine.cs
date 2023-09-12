using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            finishEffect.Play();
            Invoke("ReloadScene", 1f); //Delay 1s
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
