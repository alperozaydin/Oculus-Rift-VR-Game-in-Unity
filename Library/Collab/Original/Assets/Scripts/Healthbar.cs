using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour {
    public Image currentHealthbar;
    public Text ratioText;
    public GameObject gameOver;
    public GameOverScript script;
    


    private float hitpoint = 100;
    private float maxHitpoint = 100;

    public void Start()
    {
        UpdateHealthbar();
        gameOver= GameObject.Find("Canvas/GameOver");

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
          
             script= gameOver.GetComponent<GameOverScript>();
            script.enabled = true;



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
