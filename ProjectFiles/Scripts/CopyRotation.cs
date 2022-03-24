using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRotation : MonoBehaviour
{
    public Transform targetLimb;
    public bool mirror;
    Quaternion startRot;
    ConfigurableJoint joint;
    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();
        startRot = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        joint.targetRotation = Quaternion.identity * (startRot * Quaternion.Inverse(targetLimb.localRotation));
        // if(!mirror)  joint.targetRotation = Quaternion.Inverse(targetLimb.localRotation);
        // else joint.targetRotation = targetLimb.localRotation * startRot;
    }

}

