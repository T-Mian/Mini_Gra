using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanowanieEnemi : MonoBehaviour
{
    public float czasSpanu;
    private float odstepSpanu;
    public GameObject[] wrogowie;

    private void Update()
    {
        if (odstepSpanu <= 0)
        {
            int rand = Random.Range(0, wrogowie.Length);
            Instantiate(wrogowie[rand],transform.position , Quaternion.identity);
            odstepSpanu = czasSpanu;
        }else
        {
            odstepSpanu -= Time.deltaTime;
        }
    }


}
