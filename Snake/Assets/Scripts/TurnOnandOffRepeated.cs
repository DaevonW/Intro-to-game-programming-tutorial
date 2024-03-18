using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MW CCNY Midterms 

public class TurnOnandOffRepeated : MonoBehaviour
{
    
    public GameObject TriangleObject;
   

// Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangeStateOfGameObject",1f,1f); //Object flashing repeatedly 
    }

    void ChangeStateOfGameObject()
    {
        TriangleObject.SetActive(!TriangleObject.activeInHierarchy); //activate Gameobject (obstacles)
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
