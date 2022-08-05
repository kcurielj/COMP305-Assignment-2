using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("test");
            this.gameObject.GetComponent<Transform>().eulerAngles = new Vector3 (0, 0, 180);
        }
    }
}
