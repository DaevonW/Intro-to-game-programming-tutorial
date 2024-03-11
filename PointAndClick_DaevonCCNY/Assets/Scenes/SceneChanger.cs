using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //use Scene Management Library

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    //Global Variables
    public int sceneNumber;
    //0 = StartScene
    //1 = MainScene
    //2 = EndScene
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneNumber == 0) //we are in the StartScene
        {
            StartSceneControls();
     
            else if (sceneNumber == 1);
            {
                MainSceneControls()
                  else if (sceneNumber == 2);
           
            }
           
        }
    }
    public void StartSceneControls()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("MainScene");
        }
    }
   
    public void MainSceneControls()
    {
        Debug.Log("main scene controls");
    }
    public void EndSceneControls()
    {
        Debug.Log("end scene controls");
    }
}
