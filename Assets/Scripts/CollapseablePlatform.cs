using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapseablePlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(onDisappear()); 
        }
    }

    IEnumerator onDisappear()
    {
        yield return new WaitForSeconds(3f);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;

        yield return new WaitForSeconds(3f);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider2D>().enabled = true;


    }
}
