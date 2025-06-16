using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;
    [SerializeField] private float health = 100;

    public Animator anim;

    public TMP_Text healthText;

    public bool isDead = false;

    public static PlayerStats instance;

    void Awake()

    {

        instance = this;

    }

    private void Start()
    {
        anim = GetComponent<Animator>();

        healthText.text = "Health: " + health.ToString();
    }

    public void TakeDamage(float damage)

    {
        Debug.Log("Take damage");
        health = health - damage;

        if (health < 0)

        {

            health = 0;

        }

        if (health > maxHealth)

        {

            health = maxHealth;

        }

        if (health == 0)

        {

            isDead = true;

            anim.SetTrigger("isDead");

        }

        healthText.text = "Health: " + health.ToString();

    }

    

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
