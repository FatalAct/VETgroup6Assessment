using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_platform : MonoBehaviour
{
    public float distance;
    public float speed;
    public Vector3 starting_position;
    public Vector3 movement_vector;

    // Start is called before the first frame update
    void Start()
    {
        starting_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = distance * Mathf.Sin(Time.time * speed);
        
        transform.position = starting_position + new Vector3(x, 0, 0);
    }
}
