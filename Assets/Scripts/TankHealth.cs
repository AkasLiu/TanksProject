using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

    public int hp = 100;
    public GameObject tankExplosion;
    public AudioClip tankExplosionAudio;
    public Slider hpSilder;

    private int hpTotal;


	// Use this for initialization
	void Start () {
        hpTotal = hp;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void TakeDamage()
    {
        if (hp <= 0)    return;
        hp -= Random.Range(10, 20);
        hpSilder.value = (float)hp / hpTotal;
        if (hp <= 0) 
        {
            GameObject.Instantiate(tankExplosion, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(tankExplosionAudio, transform.position);
        }
    }
}
