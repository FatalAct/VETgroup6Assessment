using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputLog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire"))
        {
            Debug.Log("Fire");
        }

        if (Input.GetButtonDown("Sprint"))
        {
            Debug.Log("Sprint");
        }
        if (Input.GetButtonDown("Aim"))
        {
            Debug.Log("Aim");
        }
       
        if (Input.GetButtonDown("Crouch"))
        {
            Debug.Log("Crouch");
        }
        if (Input.GetButtonDown("NextWeapon"))
        {
            Debug.Log("Weapon");
        }
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
        }

    }
}