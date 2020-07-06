using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pociski : MonoBehaviour
{
    public float szybkosc;
    void Update()
    {
        transform.Translate(Vector2.right * szybkosc * Time.deltaTime);

    }
}
