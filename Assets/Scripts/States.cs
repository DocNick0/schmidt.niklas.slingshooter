using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
	//enums for the state of the slingshot, game and projectile
	public enum SlingshotState
	{
		Idle,
		UserPulling,
		ProjectileFlying
	}
	
	public enum GameState
	{
		Start,
		ProjectileMovingToSlingshot,
		Playing,
		Won,
		Lost
	}
	
	
	public enum ProjectileState
	{
		BeforeThrown,
		Thrown
	}
	
}