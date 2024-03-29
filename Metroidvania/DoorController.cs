using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    public Animator anim;

    public float distanceToOpen;

    private PlayerController thePlayer;

    private bool playerExiting;
    public Transform exitPoint;
    public float movePlayerSpeed;

    public string levelToLoad;

    void Start()
    {
        thePlayer = PlayerHealthController.instance.GetComponent<PlayerController>();
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, thePlayer.transform.position) < distanceToOpen)
        {
            anim.SetBool("doorOpen", true);
        }
        else
        {
            anim.SetBool("doorOpen", false);
        }

        if(playerExiting)
        {
            thePlayer.transform.position = Vector3.MoveTowards(thePlayer.transform.position,
                exitPoint.position, movePlayerSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    { 
        if(!playerExiting)
        {
            thePlayer.canMove = false;

            StartCoroutine(UseDoorCo());
        }
    }
    
    IEnumerator UseDoorCo()
    {
        playerExiting = true;

        thePlayer.anim.enabled = false;

        UIController.instance.StartFadeToBlack();

        yield return new WaitForSeconds(1.5f);

        RespawnController.instance.SetSpawn(exitPoint.position);
        thePlayer.canMove = true;
        thePlayer.anim.enabled = true;

        UIController.instance.StartFadeFromBlack();

        SceneManager.LoadScene(levelToLoad);
    }
}
