using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using modelController;
using interfaceController;

public class Click : MonoBehaviour
{
	IUserAction action;
	RoleModel role = null;
	BoatModel boat = null;
	public void SetRole(RoleModel role) {//设置当前选中的角色
		this.role = role;
	}
	public void SetBoat(BoatModel boat) {//设置当前选中的船
		this.boat = boat;
	}
	void Start() {
		action = GameDirector.GetInstance().CurrentScenceController as IUserAction;//通过导演获取当前场景的主控制器
	}
	void OnMouseDown() {//鼠标按下
		if (boat == null && role == null) return;//没有选中船或角色
		if (boat != null)//选中了船
			action.MoveBoat();//移动船
		else if(role != null)//选中了角色
			action.MoveRole(role);//移动角色
	}
}