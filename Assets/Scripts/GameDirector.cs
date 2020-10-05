using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using interfaceController;

public class GameDirector : System.Object {//导演类
	private static GameDirector _instance;
	public ISceneController CurrentScenceController { get; set; }
	public static GameDirector GetInstance() {//单体设计模式
		if (_instance == null) {//创建单体
			_instance = new GameDirector();
		}
		return _instance;
	}
}
