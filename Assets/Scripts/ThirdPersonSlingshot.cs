using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ThirdPersonSlingshot : MonoBehaviour {
	//public variables
	public Transform launchPoint;
	public GameObject projectile;
	public float force = 1f;
	public float stepSize = 0.01f;
	public int numberOfSteps = 90;
	public float lineRenderWidth = 0.09f;
	private int layerMask =1;
	public LineRenderer lineRender;


	void Update(){
		if (Input.GetButton ("Fire2")) {
			predictPath ();
		}
		if (Input.GetButtonUp ("Fire2")) {
			lineRender.SetVertexCount(0);
		}
		if (Input.GetButtonDown ("Fire1")) {
			FireProjectile();
		}
	}

	void FireProjectile(){
		GameObject tmpProjectile = Instantiate (projectile, launchPoint.position, Quaternion.Euler (launchPoint.transform.right)) as GameObject;
		tmpProjectile.GetComponent<Rigidbody> ().velocity += launchPoint.right * force;
	}

	void predictPath(){
		List<Vector3> points = new List<Vector3>();
		Vector3 predictedPosition = launchPoint.position;
		Vector3 predictedVelocity = launchPoint.right*force;

		points.Add(predictedPosition);

		bool isObjectHit = false;
		for (int i=0;i<numberOfSteps && !isObjectHit; i++){
			predictedVelocity += Physics.gravity*stepSize;
			predictedPosition += predictedVelocity*stepSize;
			points.Add (predictedPosition);
			isObjectHit = Physics.CheckSphere(points[points.Count-1], 0.2f, layerMask);
		}

		lineRender.SetVertexCount(0);
		lineRender.SetWidth (lineRenderWidth,lineRenderWidth);
		lineRender.SetColors(Color.white, Color.white);
		lineRender.SetVertexCount(points.Count);

		for (int i=0; i<points.Count; i++){
			lineRender.SetPosition(i, points[i]);
		}
	}

}
