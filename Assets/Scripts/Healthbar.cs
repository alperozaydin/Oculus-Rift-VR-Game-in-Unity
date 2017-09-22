using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour {
    public Image currentHealthbar;
    public Text ratioText;
    public GameObject gameOver;
    public GameObject Menu;

    public GameOverScript script;


    public GameObject StartButton;
    public GameObject HighScoreButton;
    public GameObject ExitButton;







    private float hitpoint = 100;
    private float maxHitpoint = 100;

    public void Start()
    {
        UpdateHealthbar();
        gameOver= GameObject.Find("Canvas/GameOver");
        Menu = GameObject.Find("Canvas/Menu/StartGameButton");

        StartButton = GameObject.Find("Canvas/Menu/StartGameButton");
        HighScoreButton = GameObject.Find("Canvas/Menu/HighestScoreButton");
        ExitButton = GameObject.Find("Canvas/Menu/Exit");


    }

    public void UpdateHealthbar()
    {
        float ratio = hitpoint / maxHitpoint;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = (ratio * 100).ToString() + '%';
    }

    public void TakeDamage(float Damage)
    {
        hitpoint -= Damage;

        if(hitpoint == 0)
        {

            hitpoint = 0;
            Time.timeScale = 0;

            script = gameOver.GetComponent<GameOverScript>();
            script.enabled = true;

            //StartButton.active = true;
            //HighScoreButton.active = true;
            //ExitButton.active = true;












        }
        UpdateHealthbar();
    }


    private void HealDamage(float heal)
    {
        hitpoint += heal;

        if (hitpoint > maxHitpoint)
        {
            hitpoint = maxHitpoint;
        }

        UpdateHealthbar();
    }
}
