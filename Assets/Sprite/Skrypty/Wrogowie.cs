using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wrogowie : MonoBehaviour {

    public float szybkosc;
    public void Update()
    {
        transform.Translate(Vector2.left * szybkosc * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag("gracz"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if(other.tag == gameObject.tag)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            
        }else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
