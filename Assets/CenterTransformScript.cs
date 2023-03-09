using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterTransformScript : MonoBehaviour
{

	public Transform target;

	public float smoothSpeed = 0.125f;
	public Vector3 offset;
	bool MoveToCenter = false;
	Vector3 desiredPosition;

	public void moveToCenter()
    {
		MoveToCenter = true;
		desiredPosition = target.position + offset;
	}


	public void FixedUpdate()
	{

		if (MoveToCenter)
		{
			Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}


	}

}

