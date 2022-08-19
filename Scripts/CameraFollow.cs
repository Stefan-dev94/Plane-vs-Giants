using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	[SerializeField] private GameObject _player;
    [SerializeField] private Vector3 _offset;


	void FixedUpdate()
	{
		if (_player != null)
		{
			Vector3 camPos = transform.position;
			Vector3 desiredPos = _player.transform.position;

			Vector3 smoothedPos = Vector3.Lerp(camPos, desiredPos, 0.125f);

			transform.position = new Vector3(smoothedPos.x, transform.position.y, transform.position.z);
		}
	}
}

