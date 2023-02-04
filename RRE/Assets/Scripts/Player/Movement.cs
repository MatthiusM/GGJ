using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private bool cloud = true;
    private bool directionRight = true;
    public readonly float playerHalfWidth = 0.5f;

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
            
        }
    }

    static float CameraWidth()
    {
        float aspect = (float)Screen.width / Screen.height;

        float worldHeight = Camera.main.orthographicSize * 2;

        float worldWidth = worldHeight * aspect / 2;
        
        return worldWidth;
    }
}
