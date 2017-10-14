using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowf : MonoBehaviour
{
    public GameObject t;

    void Start()
    {
        t = GameObject.Find("Player");
        this.transform.localScale = t.transform.localScale;
        if (t.transform.localScale.x == 1)
        {
            this.GetComponent<Rigidbody2D>().AddForce(transform.right * 500);
        }
        if (t.transform.localScale.x == -1)
        {
            this.GetComponent<Rigidbody2D>().AddForce(transform.right * -500);
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag == "enemy")
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D w)
    {
        if (w.tag == "wall")
        {
            Destroy(this.gameObject);

        }
    }
}
