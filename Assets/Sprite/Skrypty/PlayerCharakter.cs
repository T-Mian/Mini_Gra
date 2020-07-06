using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharakter : MonoBehaviour
{
    public GameObject[] pociski;


   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(pociski[0], transform.position, Quaternion.identity);

        }else if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(pociski[1], transform.position, Quaternion.identity);
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(pociski[2], transform.position, Quaternion.identity);
        }
    }
}
