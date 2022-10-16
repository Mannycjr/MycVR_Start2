using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_sword : MonoBehaviour
{
    public GameObject swordPrefab;
    
    public void CreateSword ()
    {
        GameObject newSword = Instantiate(swordPrefab);
        newSword.transform.parent = this.transform;
    }

}
