using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class oyunbitme : MonoBehaviour
{
    public Text player;
    public Text bot;

    public Font m_font;

    private int playerSkor;
    private int botSkor;
    public int kactaBitsin;

    public TextMeshProUGUI myText;
    public Button geribas;
    public Button yenidenoyna;

    private void Start()
    {
		
        geribas.gameObject.SetActive(false);
        yenidenoyna.gameObject.SetActive(false);
    }
    void Update()
    {
        playerSkor = int.Parse(player.text);
        botSkor = int.Parse(bot.text);

        gameOver();

        //Debug.Log(playerSkor + "-" + botSkor);
    }

    private void gameOver()
    {
        if (playerSkor == kactaBitsin)
        {
            myText.text = "KAZANDIN !!!!";
            geribas.gameObject.SetActive(true);
            yenidenoyna.gameObject.SetActive(true);
            Time.timeScale = 0;
            
        }
        if (botSkor == kactaBitsin)
        {
			myText.text = "KAYBETTIN !!!!";
            geribas.gameObject.SetActive(true);
            yenidenoyna.gameObject.SetActive(true);
            Time.timeScale = 0;
            
        }
		if ( playerSkor == 10 && botSkor == 10 )

		{
			myText.text = "BERABERE !!!!";
			geribas.gameObject.SetActive(true);
			yenidenoyna.gameObject.SetActive(true);
			Time.timeScale = 0;
		}
	}
}
