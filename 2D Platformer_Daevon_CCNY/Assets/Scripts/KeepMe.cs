using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepMe : MonoBehaviour
{
    // Start is called before the first frame update
    //Global variables
    public static GameObject instance;
    void Start()
    {
        
    }
    private void Awake()
    {
        //when the new scene/instance of this loads
        if (instance == null)
        { 
            Debug.Log("Audio Manager not destroyed");
            instance = gameObject;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Debug.Log("Extra Audio Manager Destroyed.");
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
