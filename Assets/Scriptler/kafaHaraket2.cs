using UnityEngine;
using System.Collections;


public class kafaHaraket2 : MonoBehaviour
{
	public Animator anim;
    public int  hizX;
	public int  hizY;
	public int  hiz;
	private bool moveLeft;
	private bool moveRight;

    public int ziplamaSayisi = 1;
    public float bekleme = 0.0f;
    

    public Rigidbody2D ground;//rakibin kafasının üstünde olması durumu eklenecek

	void Start()
	{
		
	}

    public void haraket(string baslat) {
		if (baslat == "sol") {
			anim = gameObject.GetComponent<Animator>();
			anim.Play("karakter");
           // GetComponent<Rigidbody2D>().velocity = new Vector2(-hizX,0);   
		}
		if (baslat == "sag") {
			GetComponent<Rigidbody2D>().velocity = new Vector2(hizX,0);
        }
		if (baslat == "yukari") {
            if (ziplamaSayisi>1 && bekleme == 0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, hizY * Time.deltaTime);
                ziplamaSayisi--;
            }
		}
        if (baslat == "dur") //hızı 0 yapar
        {
			//transform.Translate (0* Time.deltaTime, 0, 0);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

    }
    
    void Update()
    {
		if(moveLeft && !moveRight)
		{
			transform.Translate (-hiz * Time.deltaTime, 0, 0);
		}
		if(moveRight && !moveLeft)
		{
			
			transform.Translate (hiz * Time.deltaTime, 0, 0);
		}
        bekleme -= Time.deltaTime;
        bekleme = Mathf.Max(0, bekleme);
        //Debug.Log("time" + bekleme.ToString()+ "--------" + "ziplamaSayisi:" + ziplamaSayisi.ToString());
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.rigidbody.tag == "zemin1" || collision.rigidbody.tag == "zemin2")
        {
			bekleme = 0.0f;

        }
        
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.rigidbody.tag == "zemin1" || collision.rigidbody.tag == "zemin2" )
        {
            ziplamaSayisi = 2;
        }
        else { }
    }

    public void MoveMeLeft()
	{
		moveLeft = true;
	}
	public void StopMeLeft()
	{
		moveLeft = false;
	}
	public void MoveMeRight()
	{
		moveRight = true;
	}
	public void StopMeRight()
	{
		moveRight = false;
	}
}

