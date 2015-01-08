using UnityEngine;
using System.Collections;

public class Door01Open : MonoBehaviour 
{
	public Animator anim;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			anim.SetBool("Open", true);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") 
		{
			anim.SetBool("Open", false);
		}
	}
}