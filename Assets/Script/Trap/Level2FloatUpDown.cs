using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2FloatUpDown : MonoBehaviour
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
        if (transform.position.y > -97 && changePos == false)
        {
            transform.position = transform.position + new Vector3(0, -PlatformSpeed * Time.deltaTime, 0);
        }

        if (transform.position.y < -97 && changePos == false)
        {
            changePos = true;
        }

        if (transform.position.y < -7 && changePos == true)
        {
            transform.position = transform.position + new Vector3(0, PlatformSpeed * Time.deltaTime, 0);
        }

        if (transform.position.y > -7 && changePos == true)
        {
            changePos = false;
        }
    }
}
