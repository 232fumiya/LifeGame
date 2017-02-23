using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(AllLifeMaker))]
public class AllLifeManager : MonoBehaviour {
	private AllLife 		_earth;
	private AllLifeMaker 	_maker;
	private void Start () {
		_earth = AllLife.Instance;
		_maker = AllLifeMaker.Instance;
		_maker.Create (_earth);
	}
	
	private void Update () {
			
	}
}
