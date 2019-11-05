using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yapaZeka2 : MonoBehaviour
{
	public Rigidbody2D bot;
	private float Xdif;
	private float Ydif;
    // Start is called before the first frame update

    
	void OnColliderStay2D (Collider2D coll)
		{

			if (coll.gameObject.tag == "Player" )
			{
                   bot.AddForce(Vector2.right * 6);

			}
		}


    // Update is called once per frame
    void Update()
    {
        
    }
}
