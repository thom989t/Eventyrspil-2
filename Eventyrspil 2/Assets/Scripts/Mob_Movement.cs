using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob_Movement : MonoBehaviour
{
    public Transform minTransform;
    public float speed;
    bool stand = false;
    Rigidbody2D rb;
    Vector2 pos=new Vector2 (-5,0);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stand)
        {
                    
        }

        else
        {
            //rb.Move(Vector2.zero, Quaternion.identity);
        }
        rb.MovePosition((Vector2)rb.position + pos * speed * Time.deltaTime);
        //rb.velocity = pos * speed * Time.deltaTime;
        //rb.AddForce(pos * speed, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        stand = true;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        stand = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        stand = false;
    }

}
