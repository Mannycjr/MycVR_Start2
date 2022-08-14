using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_color : MonoBehaviour
{
    public Material HitMaterial;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit: "+ other.transform.name + " tag: " + other.tag);

        var renderer = this.GetComponent<Renderer>();
        renderer.material.SetColor("_Color", Color.blue);

    }
}
