using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCamara : MonoBehaviour
{
	public List<Transform> objetivos;
	public float smoothTime = .5f;
	public Vector3 offset;
	public float minZoom = 40f;
	public float maxZoom = 10f;
	public float limiteZoom = 50f;
	private Vector3 velocidad;
	private Camera cam;

	void Start()
	{
		cam = GetComponent<Camera>();
	}
	void LateUpdate()
	{
		Move();
		Zoom();
	}

	void Zoom()
	{
		float newZoom = Mathf.Lerp(maxZoom, minZoom, MayorDistancia() / limiteZoom);
		cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);
	}

	void Move()
	{
		Vector3 centerPoint = GetCenterPoint();

		Vector3 nuevaPos = centerPoint + offset;

		transform.position = Vector3.SmoothDamp(transform.position, nuevaPos, ref velocidad, smoothTime);

	}

	float MayorDistancia()
	{
		var bounds = new Bounds(objetivos[0].position, Vector3.zero);
		for(int i = 0; i < objetivos.Count; i++)
		{
			bounds.Encapsulate(objetivos[i].position);
		}
		return bounds.size.x;
	}

	Vector3 GetCenterPoint()
	{
		if(objetivos.Count == 1)
		{
			return objetivos[0].position;
		}
		var bounds = new Bounds(objetivos[0].position, Vector3.zero);
		for(int i = 0; i< objetivos.Count; i++)
		{
			bounds.Encapsulate(objetivos[i].position);
		}
		return bounds.center;
	}
}
