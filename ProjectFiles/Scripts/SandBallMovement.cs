using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandBallMovement : MonoBehaviour
{

    public Transform targetL;
    public Transform targetR;

    private void LateUpdate()
    {
        if (targetL.position.y < targetR.position.y)
        {
             this.transform.position = new Vector3(targetL.position.x, targetL.position.y -0.05f, targetL.position.z+0.1f);
        }
        else
        {
            this.transform.position = new Vector3(targetR.position.x, targetR.position.y -0.05f, targetR.position.z+0.1f);
        }

    }
}

