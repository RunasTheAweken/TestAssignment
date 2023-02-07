using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private float maxhp;
    public float CurrentHp;
    public Image image;
    public Animator animUI;
    private Animator anim;
    public AudioSource[] sources;
    public AudioSource backgroundsource;

    private void Start()
    {
        anim = GetComponent<Animator>();
        maxhp = CurrentHp; 
    }





    public void TakeDamagePlayer(float Damage)
    {
        CurrentHp -= Damage;
        
        sources[0].Play();

        float normilizedHP = (CurrentHp - 1) / (maxhp - 1);

        image.fillAmount = normilizedHP;

        anim.SetBool("TakedDamage", true);

        if (CurrentHp <= 0)
        {
            sources[0].enabled = false;
            sources[1].Play();
            GetComponent<PlayerController>().enabled= false;
            GetComponent<PlayerShootController>().enabled= false;
            GetComponent<PlayerShootController>().StopCorutine();
            animUI.SetBool("IsDead", true);
            backgroundsource.enabled = false;
            enabled = false;
        }
    }
    public void ResetAnim() 
    {
        anim.SetBool("TakedDamage", false);
    }

}
