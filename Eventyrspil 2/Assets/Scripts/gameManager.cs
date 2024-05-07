using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    [SerializeField] private GameObject tower;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider == null) return;

            if (hit.collider.CompareTag("Grid"))
            {
                Transform tileT = hit.collider.transform;
                if (tileT.GetComponent<tile>().IsPlaced)
                {
                    GameObject tempvar = tileT.GetComponent<tile>().Tower;
                    tileT.GetComponent<tile>().Tower = null;
                    Destroy(tempvar);
                    tileT.GetComponent<tile>().IsPlaced = false;
                }
                else
                {
                    tileT.GetComponent<tile>().Tower = Instantiate(tower, tileT.position, Quaternion.identity);
                    tileT.GetComponent<tile>().IsPlaced = true;
                }

                
            }
        }
    }
}
