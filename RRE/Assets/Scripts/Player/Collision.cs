using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject Player2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.GetComponent<Movement>().cloud = false;
        transform.position -= new Vector3(0, 1, 0);
        //turn into tree
        Instantiate(Player2, this.transform.position, Quaternion.identity);
        Destroy(this);
    }
}
