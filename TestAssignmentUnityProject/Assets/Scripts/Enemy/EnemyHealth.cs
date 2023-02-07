using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    private float maxhp;
    public float CurrentHp;
    public Image image;
    public float ScoreCost;
    public Score score;
    Animator anim;
    public AudioSource[] sources;

    private void Start()
    {
        maxhp = CurrentHp;
        score = GameObject.Find("GameManager").GetComponent<Score>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Arrow(Clone)")
        {
            TakeDamage(20);
        }
    }




    public void TakeDamage(float Damage)
    {
        CurrentHp -= Damage;
        sources[0].Play();
        anim.SetBool("IsTakedDamage", true);

        float normilizedHP = (CurrentHp - 1) / (maxhp - 1);
        image.fillAmount = normilizedHP;
        if (CurrentHp == 0) 
        {
            sources[1].Play();
            Destroy(gameObject, sources[1].volume + 0.2f);
            score.GiveScore(ScoreCost);
        }
    }
    public void ResetAnimator() 
    {
        anim.SetBool("IsTakedDamage", false);
    }
}
