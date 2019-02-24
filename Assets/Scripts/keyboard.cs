using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
public static void ForDebug(Vector3 pos, Vector3 direction, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20.0f)
    {
		//Gizmos.color = Color.green;
        Debug.DrawRay(pos, direction);
        
        Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler(0,180+arrowHeadAngle,0) * new Vector3(0,0,1);
        Vector3 left = Quaternion.LookRotation(direction) * Quaternion.Euler(0,180-arrowHeadAngle,0) * new Vector3(0,0,1);
        Debug.DrawRay(pos + direction, right * arrowHeadLength);
        Debug.DrawRay(pos + direction, left * arrowHeadLength);
    }
    // Update is called once per frame
     void Update()
	 { 
	 ForDebug(transform.position+new Vector3(1,0,0),transform.forward);
	 ForDebug(transform.position+new Vector3(-1,0,0),transform.rotation *new Vector3(0,0,1));
	 ForDebug(transform.position,transform.rotation * Quaternion.Euler(90,0,0)* new Vector3(0,50 * Time.deltaTime,0));
	 if(Input.GetKey(KeyCode.LeftShift)){
		  if(Input.GetKey(KeyCode.RightArrow))
		  {
			  transform.rotation = transform.rotation * Quaternion.Euler(0,0,-1);
		  }
		  if(Input.GetKey(KeyCode.LeftArrow))
		  {
			  transform.rotation = transform.rotation * Quaternion.Euler(0,0,1);
		  }
		  if(Input.GetKey(KeyCode.DownArrow))
		  {
			  transform.Translate( new Vector3(0,-10 * Time.deltaTime,0));
		  }
		  if(Input.GetKey(KeyCode.UpArrow))
		 {
			 transform.Translate( new Vector3(0,10 * Time.deltaTime,0));
		 }
		 
	 }else if(Input.GetKey(KeyCode.LeftControl)){
		  if(Input.GetKey(KeyCode.RightArrow))
		  {
			  transform.rotation = transform.rotation * Quaternion.Euler(0,1,0);
		  }
		  if(Input.GetKey(KeyCode.LeftArrow))
		  {
			  transform.rotation = transform.rotation * Quaternion.Euler(0,-1,0);
		  }
		  if(Input.GetKey(KeyCode.DownArrow))
		  {
			  transform.rotation = transform.rotation * Quaternion.Euler(1,0,0);
		  }
		  if(Input.GetKey(KeyCode.UpArrow))
		 {
			 transform.rotation = transform.rotation * Quaternion.Euler(-1,0,0);
		 }
		 
	 }else{	 
	      if(Input.GetKey(KeyCode.RightArrow))
		  {
			  transform.Translate( Quaternion.Euler(90,0,0)* new Vector3(10 * Time.deltaTime,0,0));
		  }
		  if(Input.GetKey(KeyCode.LeftArrow))
		  {
			  transform.Translate( Quaternion.Euler(90,0,0)* new Vector3(-10 * Time.deltaTime,0,0));
		  }
		  if(Input.GetKey(KeyCode.DownArrow))
		  {
			  transform.Translate( Quaternion.Euler(90,0,0)* new Vector3(0,-10 * Time.deltaTime,0));
		  }
		  if(Input.GetKey(KeyCode.UpArrow))
		 {
			 transform.Translate(  Quaternion.Euler(90,0,0)* new Vector3(0,10 * Time.deltaTime,0));
		 }
		 /* if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = transform.forward * m_Speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = -transform.forward * m_Speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Rotate the sprite about the Y axis in the positive direction
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * m_Speed, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Rotate the sprite about the Y axis in the negative direction
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * m_Speed, Space.World);
        }*/
	 }
 }
}
