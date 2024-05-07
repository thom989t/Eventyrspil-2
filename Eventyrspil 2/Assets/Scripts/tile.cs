using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile : MonoBehaviour, ITile
{
    public GameObject Tower;
    public bool IsPlaced { get; set; }
}
