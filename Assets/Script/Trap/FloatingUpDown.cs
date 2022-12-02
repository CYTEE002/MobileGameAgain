using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingUpDown : MonoBehaviour
{
    public float PlatformSpeed = 0.5f;
    bool changePos = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }                                                        

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > -80 && changePos == false)
        {
            transform.position = transform.position + new Vector3(0, -PlatformSpeed * Time.deltaTime, 0);
        }

        if (transform.position.y < -80 && changePos == false)
        {
            changePos = true;
        }

        if (transform.position.y < -47 && changePos ==true)
        {
            transform.position = transform.position + new Vector3(0, PlatformSpeed * Time.deltaTime, 0);
        }

        if (transform.position.y > -47 && changePos == true)
        {
            changePos = false;
        }
    }
}
