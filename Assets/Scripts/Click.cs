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
	public void SetRole(RoleModel role)
	{
		this.role = role;
	}
	public void SetBoat(BoatModel boat)
	{
		this.boat = boat;
	}
	void Start()
	{
		action = GameDirector.GetInstance().CurrentScenceController as IUserAction;
	}
	void OnMouseDown()
	{
		if (boat == null && role == null) return;
		if (boat != null)
			action.MoveBoat();
		else if(role != null)
			action.MoveRole(role);
	}
}