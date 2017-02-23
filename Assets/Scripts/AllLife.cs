using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 盤面
/// </summary>
public class AllLife {
	private static AllLife _instance;
	private AllLifeObj _islive_obj = new AllLifeObj(100);
	public static AllLife Instance{
		get{
			if (_instance == null) 
				_instance = new AllLife ();
			return _instance;
		}
	}
	public AllLifeObj Life{
		get{
			return _islive_obj;
		}
	}
}
/// <summary>
/// 盤面オブジェクト
/// </summary>
public class AllLifeObj{
	private int				_size;
	private bool[,] 		_islive;

	public AllLifeObj(int size){
		_size	= size;
		_islive = new bool[size,size];
	}

	public int Size{
		get{
			return _size;
		}
	}
	public bool[,] isLive{
		get{
			return _islive;
		}
	}
}
