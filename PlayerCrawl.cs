using UnityEngine;
using System.Collections;

public class PlayerCraw : MonoBehaviour {

	public static bool canCrouch = false, isCrouched = false, isIdle = true;
	// Do Not Change

	public static Animation[] animation_list;
	public static GameObject player;
	// Define these in your editor
}

private sealed class CheckForCrouch : MonoBehavior
{
	protected GameObject player = CrouchVars.player;
	private void Update()
	{
		if(isCrouched)
		{
			// If you're crouching, default to this animation
			if(!isIdle)
			{
				// If you're not idle, that means you're walking
				if(player.animation.clip !== CrouchVars.animation_list['Crouch_Walk'])
					player.animation.clip = CrouchVars.animation_list['Crouch_Walk'];
			}else{
				// If you're idle, set it to idle instead
				if(player.animation.clip !== CrouchVars.animation_list['Crouch_Idle'])
					player.animation.clip = CrouchVars.animation_list['Crouch_Walk'];
			}
			/*
              More logic for normal walk and idle
             */
		}

		if(!player.animation.clip.isPlaying)
			player.animation.clip.Play();
		// Loop animations as you move
	}

	private void OnTriggerEnter(Collision e)
	{
		// If you just entered the area
		if(e == CrouchVars.player)
			CrouchVars.canCrouch = true;
		// You can crouch
	}

	private void OnTriggerExit(Collision e)
	{
		// If you just left the area
		if(e == CrouchVars.player)
			CrouchVars.canCrouch = false;
		// You cant crouch
	}
}