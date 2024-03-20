using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRepeated : MonoBehaviour
{

    public GameObject CircleObject;

    // Start is called before the first frame update
    void Start()
    {
           InvokeRepeating("ChangeStateOfGameObject",1f,1f); //Object flashing repeatedly 

    }
     void ChangeStateOfGameObject()
    {
            CircleObject.SetActive(!CircleObject.activeInHierarchy); //activate Gameobject (obstacles)

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
