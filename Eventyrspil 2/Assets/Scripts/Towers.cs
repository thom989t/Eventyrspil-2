using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collider2D[] collidereindeforCirclen = Physics2D.OverlapCircleAll(transform.position,2);

        foreach (var item in collidereindeforCirclen)
        {
            if (item.tag == "Enemy")
            {
                Debug.Log(item.name);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
