using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    private Vector3 CameraPosition;
    [Header("Camera Settings")]
    public float CameraSpeed;
    private float x;
    private float y;
    public float sensitivity=-1f;
    private Vector3 rotate;
    // Start is called before the first frame update
    void Start()
    {
        CameraPosition= this.transform.position;
        Cursor.lockState=CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        y=Input.GetAxis("Mouse X");
        x=Input.GetAxis("Mouse Y");
        rotate=new Vector3(x,y*sensitivity,0);
        transform.eulerAngles=transform.eulerAngles-rotate;
        if(Input.GetKey(KeyCode.W))
        {
            CameraPosition.z -= CameraSpeed/50;
        }
        if(Input.GetKey(KeyCode.S))
        {
            CameraPosition.z += CameraSpeed/50;
        }
        if(Input.GetKey(KeyCode.A))
        {
            CameraPosition.x += CameraSpeed/50;
        }
        if(Input.GetKey(KeyCode.D))
        {
            CameraPosition.x -= CameraSpeed/50;
        }
        this.transform.position=CameraPosition;
    }
}
