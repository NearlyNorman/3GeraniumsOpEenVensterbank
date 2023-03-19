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

	public float time = 45f;

	public void moveToCenter()
    {
		MoveToCenter = true;
		desiredPosition = target.position + offset;
	}

	public void StopMoveToCenter()
    {
		MoveToCenter = false;
    }

	public void FixedUpdate()
	{

		if (MoveToCenter)
		{
			desiredPosition = target.position + offset;
			Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;

			StartCoroutine(waiter());
		}


	}

	IEnumerator waiter()
    {
		yield return new WaitForSeconds(time);
		MoveToCenter = false;
    }

}

