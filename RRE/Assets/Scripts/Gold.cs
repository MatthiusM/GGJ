using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    private float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player2Movement.onScreen)
        {
            transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
        }
    }
}
