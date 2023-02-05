using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public float playerSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        MovementInput();
    }

    float CameraWidth()
    {
        float aspect = (float)Screen.width / Screen.height;

        float worldHeight = Camera.main.orthographicSize * 2;

        float worldWidth = worldHeight * aspect / 2;

        return Camera.main.transform.position.x - worldWidth;
    }


    void MovementInput()
    {
        //left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x - this.GetComponent<SpriteRenderer>().bounds.size.x / 2 > CameraWidth())
            {
                transform.position -= new Vector3(playerSpeed, 0, 0) * Time.deltaTime;
            }
        }
        //right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x + this.GetComponent<SpriteRenderer>().bounds.size.x / 2 < -1 * CameraWidth())
            {
                transform.position += new Vector3(playerSpeed, 0, 0) * Time.deltaTime;
            }

        }

    }
}
