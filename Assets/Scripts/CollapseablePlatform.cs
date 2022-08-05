using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapseablePlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            Destroy(this.gameObject, 2f);
        }
    }
}
