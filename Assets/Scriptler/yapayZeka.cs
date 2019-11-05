using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yapayZeka : MonoBehaviour
{

	private Vector3 Top;
	private Vector2 Topdirection;

    private float Xdif;
	private float Ydif;

    public float XFarkUst; //zıplama komutu için
    public float XFarkAlt; //zıplama komutu için
    public float YFarkUst; //zıplama komutu için
    public float YFarkAlt; //zıplama komutu için

    public float speed;

    public Rigidbody2D ground;//rakibin kafasının üstünde olması durumu eklenecek
    private bool botTouching = true;


    /*void Update () {
		Top = GameObject.FindGameObjectWithTag("top").transform.position;

		Xdif = Top.x - transform.position.x;

		Topdirection = new Vector2 (Xdif, Ydif);

		GetComponent<Rigidbody2D>().AddForce (Topdirection.normalized * speed);
		//Debug.Log (Topdirection);
	}*/

    private void Update()
    {
        Top = GameObject.FindGameObjectWithTag("top").transform.position;
        Xdif = Top.x - transform.position.x;
        Ydif = Top.y - transform.position.y;

        // Debug.Log(Top.x - GetComponent<Rigidbody2D>().position.x);
        if (Mathf.Abs( Top.x - GetComponent<Rigidbody2D>().position.x)<0.3f)
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().AddForce(Topdirection * 10 * (speed));
        }

        Topdirection = new Vector2(1 , 0);
        topSolda(Top.x, Top.y , Topdirection);
        topSagda(Top.x, Top.y , Topdirection);
        topaDogruZiplama(Top.x, Top.y);

    }

    private void topSolda(float x, float y, Vector2 topdirection)
    {
        if (x < gameObject.transform.position.x)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);            
        }
    }
    private void topSagda(float x, float y, Vector2 topdirection)
    {        
        if (x > gameObject.transform.position.x)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);            
        }
    }

    private void topaDogruZiplama(float x, float y)
    {
        if (botTouching)
        {
            float xFark = Mathf.Abs(x - gameObject.transform.position.x); //mutlak değer olmazsa mesela top  -10 da 
                                                                                 //adam ise 5 de fark -15 olacağı için gene zıplıyor.
            float yFark = y - gameObject.transform.position.y; //top üstte olacağı zaman zıplayacağı için bunda mutlak a gerek yok.

            if ( xFark <= XFarkUst && xFark > XFarkAlt && yFark <= YFarkUst && yFark >= YFarkAlt  )
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, speed * 5f );
            }
        }
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.rigidbody.tag == "zemin1" || collision.rigidbody.tag == "zemin2")
        {
            botTouching = true;
        }

    }
    void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.rigidbody.tag == "zemin1" || collision.rigidbody.tag == "zemin2")
        {
            botTouching = false;
        }
    }
    
}
