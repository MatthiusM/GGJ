using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public bool cloud = true;
    private bool directionRight = true;
    private readonly float playerHalfWidth = 0.5f;
    private readonly float fallSpeed = 25.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position += new Vector3(0, 102, 0);
    }
   

    // Update is called once per frame
    void Update()
    {
        if (cloud)
        {
            if (directionRight)
            {
                transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
            }
            else
            {
                transform.position -= new Vector3(1, 0, 0) * Time.deltaTime;
            }

            if(directionRight && transform.position.x + playerHalfWidth > CameraWidth())
            {
                directionRight = !directionRight;
            }
            else if (!directionRight && transform.position.x - playerHalfWidth < -1* CameraWidth())
            {
                
                directionRight = !directionRight;
            }

            FallingPlayer(new Vector3(0, fallSpeed, 0));

        }
    }

    void FallingPlayer(Vector3 v)
    {
        transform.position -= v * Time.deltaTime;
        Camera.main.transform.position -= v * Time.deltaTime;
    }

    static float CameraWidth()
    {
        float aspect = (float)Screen.width / Screen.height;

        float worldHeight = Camera.main.orthographicSize * 2;

        float worldWidth = worldHeight * aspect / 2;
        
        return worldWidth;
    }
}
