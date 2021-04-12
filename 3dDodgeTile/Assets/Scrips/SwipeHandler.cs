using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwipeHandler : MonoBehaviour
{

    public Swipe swipeControls;
    public Transform player;
    public int speed;


    // Update is called once per frame
   
    void Update()
    {
        float speed1 = Vector3.Magnitude(player.GetComponent<Rigidbody>().velocity); 
        if (speed1 > 10)
        {

           
        }
        if (speed1 < 10)
        {
            if (swipeControls.SwipeLeft)
            {
                player.GetComponent<Rigidbody>().AddForce(-speed / 2 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (swipeControls.SwipeRight)
            {
                player.GetComponent<Rigidbody>().AddForce(speed / 2 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (swipeControls.SwipeUp)
            {
                player.GetComponent<Rigidbody>().AddForce(0, speed * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
            if (swipeControls.SwipeDown)
            {
                player.GetComponent<Rigidbody>().AddForce(0, -speed * Time.deltaTime, 0, ForceMode.VelocityChange);
            }

        }
        
    }
}
