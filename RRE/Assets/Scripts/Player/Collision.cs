using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.GetComponent<Movement>().cloud = false;
        transform.position -= new Vector3(0, 1, 0);
        //turn into tree
    }
}
