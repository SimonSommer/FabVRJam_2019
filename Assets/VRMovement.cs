using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VRMovement : MonoBehaviour
{
    public float Speed;

    public Transform ReferenceTransform1;
    public Transform ReferenceTransform2;

    public Rigidbody ObjectToMove;

    public Vector3 moveVector;

    public SteamVR_Input_Sources input_Source;
    public SteamVR_Action_Boolean steam_action1;
    public SteamVR_Action_Boolean steam_action2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector = Vector3.zero;
        Vector3 directon = (ReferenceTransform1.forward  + ReferenceTransform2.forward )*  0.5f;

        if (steam_action1.GetState(input_Source))
        {

            moveVector += ReferenceTransform1.forward ;
        }

        if (steam_action2.GetState(input_Source))
        {

            moveVector += ReferenceTransform2.forward ;
        }

        moveVector.Normalize();
        moveVector *= Speed; 
        ObjectToMove.velocity = moveVector;

   //     if(SteamVR_Input._)
    }
}
