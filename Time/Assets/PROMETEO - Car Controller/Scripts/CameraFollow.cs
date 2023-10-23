using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour 
{

	public Transform carTransform;
	public Vector3 offset;


    private void Update()
    {
        transform.position = carTransform.position + offset;
    }

}
