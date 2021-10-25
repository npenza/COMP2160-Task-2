using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform Target;
    public GameObject Car;
    private Vector3 CameraStartPosition;
    private Quaternion CameraStartRotation;
    // Start is called before the first frame update
    void Start()
    {
        CameraStartPosition = transform.localPosition;
        CameraStartRotation = transform.localRotation;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        
    }
}
