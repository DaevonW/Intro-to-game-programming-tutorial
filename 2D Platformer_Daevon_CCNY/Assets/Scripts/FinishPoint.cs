using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
      if(collision.CompareTag("Player"))
      {
            //Go to end scene
            SceneController.instance.EndScene();
      }

   }
   
}
