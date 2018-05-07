using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Rigidbody2D Arrow;
    Rigidbody2D rb;
    Transform ArrowOrigin;
    int speed = 10;

    void Start ()
    {
        ArrowOrigin = GameObject.Find("ArrowOrigin").transform;
}

    void Update ()
    {
        if (Input.GetButtonDown("FirePower"))
        {
            Rigidbody2D ArrowClone = (Rigidbody2D)Instantiate(Arrow, ArrowOrigin.position, Quaternion.Euler(0, 0, 27));
            ArrowClone.AddForce(new Vector2(50, 50));
        }
    }

    void FireArrow()
    {
       
        //Rigidbody2D rb = ArrowClone.GetComponent<Rigidbody2D>();
        //rb.AddForce(new Vector2(500, 0) * 10);
    }

}
