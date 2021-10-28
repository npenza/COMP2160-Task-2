using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform Target;
    private Vector3 NewPosition;
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
        float dx = Input.GetAxis(InputAxes.Horizontal);
        CarMove Car = GameObject.Find("Car").GetComponent<CarMove>();
        float Velocity = 3;
        NewPosition = transform.localPosition;
        NewPosition.z = CameraStartPosition.z - Velocity/5;
        
        
        if(dx > 0 && NewPosition.x < 45 && Velocity > 0)
        {
            NewPosition.x = NewPosition.x + 1;
        }
        if(dx < 0 && NewPosition.x > -45 && Velocity > 0)
        {
            NewPosition.x = NewPosition.x - 1;
        }
        if(dx == 0 && NewPosition.x > 0)
        {
            NewPosition.x -= 1;
        }
        if (dx == 0 && NewPosition.x < 0)
        {
            NewPosition.x += 1;
        }
        transform.localPosition = NewPosition;
        if (dx < 0 && NewPosition.x > -45 && Velocity < 0)
        {
            NewPosition.x = NewPosition.x - 1;
        }
        if (dx > 0 && NewPosition.x < 45 && Velocity < 0)
        {
            NewPosition.x = NewPosition.x + 1;
        }
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    }
}
