using UnityEngine;
using System.Collections;

public class AllLifeMaker : MonoBehaviour {
	private static AllLifeMaker _instance;
	public static AllLifeMaker Instance{
		get{
			return _instance;
		}
	}
	private const string	PARENT_OBJ_NAME = "earth";
	private const string  	BUTTON_OBJ_PATH = "life";
	private Vector3 	  	BUTTON_INIT_POS = new Vector3 (-7,6,0);
	private Vector3 		_obj_pos;
	private GameObject		_copy			= null;

	void Awake(){
		if (_instance == null)
			_instance = this;
		else
			Destroy (this.gameObject);
	}

	/// <summary>
	/// 盤面作るよー
	/// </summary>
	public void Create( AllLife _earth ){
		float _param = 0.3f;
		Transform  _parent 	= this.gameObject.transform;
		GameObject _copy 	= Resources.Load(BUTTON_OBJ_PATH) as GameObject;
		_obj_pos			= BUTTON_INIT_POS;
		for( int i = 0; i < _earth.Life.Size; i++ ){
			_obj_pos = new Vector3( BUTTON_INIT_POS.x ,_obj_pos.y , 0);
			for( int j = 0; j < _earth.Life.Size; j++ ){
				_earth.Life.isLive[i,j] = false;
				GameObject _origin = Object.Instantiate (_copy,Vector3.zero,Quaternion.identity) as GameObject;
				_origin.transform.SetParent(_parent);
				_origin.transform.localPosition = _obj_pos;
				_origin.name =i +"x"+ j;
				_obj_pos += new Vector3(_param,0,0);
			}
			_obj_pos += new Vector3 (0,-_param,0);
		}
	}
}
