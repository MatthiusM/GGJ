using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    Vector2 screenBounds;
    public bool cloud = true;
    private readonly float playerWidth = 2.0f;
    private readonly float fallSpeed = 25.0f;
    public float playerSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        transform.position += new Vector3(0, 102, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (cloud)
        {          
            FallingPlayer(new Vector3(0, fallSpeed, 0));
        }
        MovementInput();
    }
    static float CameraWidth()
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
            if (transform.position.x - this.GetComponent<SpriteRenderer>().bounds.size.x / 2 >  CameraWidth())
            {
                transform.position -= new Vector3(playerSpeed, 0, 0) * Time.deltaTime;
            }          
        }
        //right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {          
            if(transform.position.x + this.GetComponent<SpriteRenderer>().bounds.size.x / 2 < -1* CameraWidth())
            {
                transform.position += new Vector3(playerSpeed, 0, 0) * Time.deltaTime;
            }
                       
        }
        
    }

    void FallingPlayer(Vector3 v)
    {
        transform.position -= v * Time.deltaTime;
        Camera.main.transform.position -= v * Time.deltaTime;
    }
}
