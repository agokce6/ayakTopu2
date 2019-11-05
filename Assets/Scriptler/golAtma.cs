using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class golAtma : MonoBehaviour
{
	public string kale;
	public GameObject karakter;
	public GameObject bot;
	public GameObject top;
	public Transform topSpawner;
	Vector3 karakterPosition;
	public Transform karakterTransform;
	public Transform botSpawner;
	public Rigidbody2D a;

    public Text Playerskor;
    public Text Botskor;

    private int playerSkor=0;
    private int botSkor=0;

    // Use this for initialization

    void Start()
	{
		karakterPosition.Set(karakterTransform.position.x, karakterTransform.position.y,0);
        
	}

    void OnTriggerEnter2D (Collider2D top) {
		if (top.tag == "top" && kale == "1") 
		{
			karakter.transform.position = karakterPosition;
			Destroy(GameObject.FindGameObjectWithTag("top"));
			Destroy(GameObject.FindGameObjectWithTag("bot"));
			Spawner();
            botSkor++;
            Botskor.text = botSkor.ToString();
        }
		else if (top.tag == "top" && kale == "2") {
			karakter.transform.position = karakterPosition;
			Destroy(GameObject.FindGameObjectWithTag("top"));
			Destroy(GameObject.FindGameObjectWithTag("bot"));
			Spawner();
            playerSkor++;
            Playerskor.text = playerSkor.ToString();
        }
	}
	public void Spawner () {
		GameObject go = Instantiate (top, topSpawner.transform.position, Quaternion.identity);
		GameObject gb= Instantiate (bot, botSpawner.transform.position, Quaternion.identity);
		go.name = top.name;
		gb.name = bot.name;
		a.velocity = Vector2.zero;
	}
}
