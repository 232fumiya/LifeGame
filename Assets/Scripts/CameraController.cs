using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	private Transform	_target;
	private float 		_param 	   = 0.2f;
	private float		_fov_param = 10f;
	private Camera 		_cam;
	void Start(){
		_cam	= this.GetComponent<Camera>();
		_target = this.transform;
	}

	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			_target.position += new Vector3 (0,_param,0);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			_target.position += new Vector3 (0,-_param,0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			_target.position += new Vector3 (-_param,0,0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			_target.position += new Vector3 (_param,0,0);
		}
		if (Input.GetKeyDown (KeyCode.A) && _cam.fieldOfView <= 80 ) {
			_cam.fieldOfView += _fov_param;
		}
		if (Input.GetKeyDown (KeyCode.D) && 20 <=_cam.fieldOfView ) {
			_cam.fieldOfView += -_fov_param;
		}
	
	}
}
