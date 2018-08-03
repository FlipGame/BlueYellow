using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Waypoint[] wayPoints;
    public float speed = 3f;
    public bool isCircular;
    // Always true at the beginning because the moving object will always move towards the first waypoint
    public bool inReverse = false;

    private Waypoint currentWaypoint;
    private int currentIndex   = 0;
    public bool isWaiting     = false;
    private float speedStorage = 0;


    void Start () {
        if(wayPoints.Length > 0) {
            currentWaypoint = wayPoints[0];
        }
    }

void OnTriggerEnter(Collider col)
	{
		 if (col.gameObject.tag == "End")
		 {
			 print("End");
			 //SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+1);
		 }
	}

    void Update()
    {
		// foreach(Touch t in Input.touches)
        // {
        //     Debug.Log ("We have touches!");
        //     Ray ray = Camera.main.ScreenPointToRay(t.position);
        //     RaycastHit hit;


        //     Debug.Log (Physics.Raycast(ray, out hit));
        //     if(Physics.Raycast(ray, out hit))
        //     {
                
        //         switch(t.phase)
        //         {
        //         case TouchPhase.Began:
		// 			if(hit.collider.gameObject.tag == "Player")
		// 			{
        //                     isWaiting = false;
        //             }

        //             break;
        //         case TouchPhase.Moved:
        //         case TouchPhase.Stationary:
					
        //         default:
                  
        //             break;
        //         }
        //     }
        // }


	// if (Input.GetMouseButton(0))
	// {
	// 	isWaiting = false;
	// }


        if(currentWaypoint != null && !isWaiting) {
            MoveTowardsWaypoint();
        }
    }

	

	void OnMouseEnter()
	{
		isWaiting = false;
	}

    void Pause()
    {
        isWaiting = !isWaiting;
    }

    private void MoveTowardsWaypoint()
    {
        // Get the moving objects current position
        Vector3 currentPosition = this.transform.position;

        // Get the target waypoints position
        Vector3 targetPosition = currentWaypoint.transform.position;

        // If the moving object isn't that close to the waypoint
        if(Vector3.Distance(currentPosition, targetPosition) > 1f) {

            // Get the direction and normalize
            Vector3 directionOfTravel = targetPosition - currentPosition;
            directionOfTravel.Normalize();

            //scale the movement on each axis by the directionOfTravel vector components
            this.transform.Translate(
                directionOfTravel.x * speed * Time.deltaTime,
                directionOfTravel.y * speed * Time.deltaTime,
                directionOfTravel.z * speed * Time.deltaTime,
                Space.World
            );
        } else {

            // If the waypoint has a pause amount then wait a bit
            if(currentWaypoint.waitSeconds > 0) {
                Pause();
                Invoke("Pause", currentWaypoint.waitSeconds);
            }

            // If the current waypoint has a speed change then change to it
            if(currentWaypoint.speedOut > 0) {
                speedStorage = speed;
                speed = currentWaypoint.speedOut;
            } else if(speedStorage != 0) {
                speed = speedStorage;
                speedStorage = 0;
            }

            NextWaypoint();
        }
    }


    private void NextWaypoint()
    {
        
		if(currentIndex < wayPoints.Length-1)
		{
			currentIndex += 1;
			currentWaypoint = wayPoints[currentIndex];
		}
			
        
    }
}
