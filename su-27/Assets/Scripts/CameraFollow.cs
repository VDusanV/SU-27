using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
  
    [SerializeField]
    GameObject targetToFollow;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(targetToFollow.transform.position.x, targetToFollow.transform.position.y - 1f, transform.position.z);
    }
}
