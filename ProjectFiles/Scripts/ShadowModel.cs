using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowModel : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = new Vector3(target.position.x + 1, this.transform.position.y, target.position.z) ;
        
    }
}
