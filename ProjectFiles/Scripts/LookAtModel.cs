using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtModel : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + new Vector3(0,2,-4);
        transform.LookAt(target);
        transform.rotation *= Quaternion.Euler(-5, 0, 0);
    }
}
