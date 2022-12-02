using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    private PlayerControl2 thePlayer;

    public SpriteRenderer theSR;
    public Sprite doorOpenSprite; 

    public bool doorOpen, waitingToOpen;


    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerControl2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitingToOpen)
        {
            if(Vector3.Distance(thePlayer.followingkey.transform.position, transform.position) < 0.1f)
            {
                waitingToOpen = false;

                doorOpen = true;

                theSR.sprite = doorOpenSprite;

                thePlayer.followingkey.gameObject.SetActive(false);
                thePlayer.followingkey = null;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
            if (other.gameObject.tag == "Player")
            {
                if (thePlayer.followingkey != null)
                {
                    thePlayer.followingkey.followTarget = transform;
                    waitingToOpen = true;
                Destroy(gameObject, 2f);
                }
            }
    }
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if(other.tag == "Player");
    //    {
    //        if(thePlayer.followingkey != null)
    //        {
    //            thePlayer.followingkey.followTarget = transform;
    //            waitingToOpen = true;
    //        }
    //    }
    //}

}
