using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_color : MonoBehaviour
{
    public Material HitMaterial;
    //public GameObject coldStream;
    

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

        if (other.tag == "Sword")
        {
            GetComponent<Renderer>().material = HitMaterial;
            //coldStream.SetActive(true);
        }
        

    }
}
