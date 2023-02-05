using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject gold;

    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        timer = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Player2Movement.onScreen && timer < Time.time)
        {
            timer += Time.deltaTime + 2.0f;
            Instantiate(gold, new Vector3(RandomX(), -1, -2), Quaternion.identity);
        }
    }

    float RandomX()
    {
        float x = Movement.CameraWidth();
        x = Random.Range((float)x*-1, (float)x);
        return x;
    }
}
