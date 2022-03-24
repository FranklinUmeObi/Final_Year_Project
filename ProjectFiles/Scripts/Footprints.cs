using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footprints : MonoBehaviour
{
    public float footprintOffset = 0.05f;
    public GameObject leftFootprint;
    public GameObject rightFootprint;

    public Transform leftFootLocation;
    public Transform rightFootLocation;

    void LeftFootstep()
    {

        if (leftFootLocation.position.z > 18 && leftFootLocation.position.z < 28)
        {
            RaycastHit hit;

            if (Physics.Raycast(leftFootLocation.position, leftFootLocation.forward, out hit))
            {
                Instantiate(leftFootprint, hit.point + hit.normal * footprintOffset, Quaternion.LookRotation(hit.normal, leftFootLocation.up));
            }
        }
        //Raycast out and create footprint

    }

    void RightFootstep()
    {
        if (rightFootLocation.position.z > 18 && rightFootLocation.position.z < 28)
        {
            RaycastHit hit;

            if (Physics.Raycast(rightFootLocation.position, rightFootLocation.forward, out hit))
            {
                Instantiate(rightFootprint, hit.point + hit.normal * footprintOffset, Quaternion.LookRotation(hit.normal, rightFootLocation.up));
            }
        }
        //Raycast out and create footprint

    }
}
