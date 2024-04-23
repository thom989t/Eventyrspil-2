using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
    
public class Towers : MonoBehaviour
{
    [SerializeField] float dist;
    [SerializeField] float maxTime;
    [SerializeField] LayerMask enemyLayer;
    [SerializeField] GameObject bullet;
    bool canShoot = true;
    float time;

    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot && Physics2D.Raycast(transform.position, new Vector2(1, 0), dist, enemyLayer))
        {
            canShoot = false;
            StartCoroutine(Shoot());
            //Debug.Log("niglet");
        }
    }

    IEnumerator Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
        //while(time > 0)
        //{
        //    time -= 1;
        //    yield return new WaitForSeconds(1);
        //}

        yield return new WaitForSeconds(time);

        canShoot = true;
        time = maxTime;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x + dist, transform.position.y));
    }

}
