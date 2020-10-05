using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using interfaceController;

public class UserGUI : MonoBehaviour {

	private IUserAction action;//场景主控制器
	public int sign = 0;//游戏状态

	bool isShow = false;//是否显示规则
	void Start() {
		action = GameDirector.GetInstance().CurrentScenceController as IUserAction;
	}
	void OnGUI()
	{
		GUIStyle text_style;
		GUIStyle button_style;
		text_style = new GUIStyle()
		{
			fontSize = 30
		};
		button_style = new GUIStyle("button")
		{
			fontSize = 15
		};
		if (GUI.Button(new Rect(10, 10, 60, 30), "规则", button_style))
		{
			isShow = !isShow;
		}
		if(isShow)
		{
			GUI.Label(new Rect(Screen.width / 2 - 114, 10, 200, 50), "需要让三个牧师和三个魔鬼都过河");
			GUI.Label(new Rect(Screen.width / 2 - 120, 30, 250, 50), "每一边恶魔数量都不能多于牧师数量");
			GUI.Label(new Rect(Screen.width / 2 - 85, 50, 250, 50), "船同时最多只能载两个人");
			GUI.Label(new Rect(Screen.width / 2 - 85, 70, 250, 50), "点击牧师、魔鬼、船操作");
		}
		if (sign == 1)
		{
			GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height / 2-120, 100, 50), "你输了！", text_style);
			if (GUI.Button(new Rect(Screen.width / 2 - 70, Screen.height / 2, 100, 50), "重新开始", button_style))
			{
				action.Restart();
				sign = 0;
			}
		}
		else if (sign == 2)
		{
			GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height / 2 - 120, 100, 50), "你赢了！", text_style);
			if (GUI.Button(new Rect(Screen.width / 2 - 70, Screen.height / 2, 100, 50), "重新开始", button_style))
			{
				action.Restart();
				sign = 0;
			}
		}
	}
}
