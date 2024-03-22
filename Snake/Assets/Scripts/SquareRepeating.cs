using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareRepeating : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject SquareObject;

    void Start()
    {
           InvokeRepeating("ChangeStateOfGameObject",4f,4f); //Object flashing repeatedly 

    }
      void ChangeStateOfGameObject()
    {
        SquareObject.SetActive(!SquareObject.activeInHierarchy); //activate Gameobject (obstacles)
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
