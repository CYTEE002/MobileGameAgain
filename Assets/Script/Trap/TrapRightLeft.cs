using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapRightLeft : MonoBehaviour
{
    public int PlatformSpeed = 10;
    bool changePos = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 74 && changePos == false)
        {
            transform.position = transform.position + new Vector3(-PlatformSpeed * Time.deltaTime, 0, 0);
        }

        if (transform.position.x < 74 && changePos == false)
        {
            changePos = true;
        }

        if (transform.position.x < 79.12 && changePos == true)
        {
            transform.position = transform.position + new Vector3(PlatformSpeed * Time.deltaTime, 0, 0);
        }

        if (transform.position.x > 79.12 && changePos == true)
        {
            changePos = false;
        }
    }
}
