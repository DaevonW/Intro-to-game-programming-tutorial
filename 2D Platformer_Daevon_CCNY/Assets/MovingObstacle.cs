using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
   public float speed;
   Vector3 targetPos;
   public GameObject ways;
   public Transform [] wayPoints;
   int pointIndex;
   int pointCount;
   int direction = 1;
   //Obstacle Pauses on time
   public float waitDuration; 
   int speedMultiplier = 1;
   private void Awake ()
   {
		  wayPoints = new Transform[ways.transform.childCount];
		  for(int i = 0; i < ways.gameObject.transform.childCount; i++)
		  {
				wayPoints[i] = ways.transform.GetChild(i).gameObject.transform;

		  }
   }
            private void Start()
          {
		    pointCount = wayPoints.Length;
		     pointIndex = 1;
			 targetPos = wayPoints[pointIndex].transform.position;
              
		}
		private void Update()
		{
			var step = speedMultiplier*speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position,targetPos, step); //To move object
              
			if(transform.position == targetPos)
	     	{
		       	NextPoint();
		     }

		}

	void NextPoint()
	{
		if (pointIndex == pointCount - 1)//Arrived at last point
		{
			direction = -1; //if the object moves to one point it will bounce back to the next
		}

		if (pointIndex == 0)// First point
		{
			direction = 1;
		}
		pointIndex += direction;
		targetPos = wayPoints[pointIndex].transform.position;
		
	}
	IEnumerator WaitNextPoint()
	{
		speedMultiplier = 0; //object won't move until the wait duration is up
		yield return new WaitForSeconds(waitDuration); //starts when object reaches its point.(point 1 or 2)
		speedMultiplier = 1; //object will keep moving
	}

}
