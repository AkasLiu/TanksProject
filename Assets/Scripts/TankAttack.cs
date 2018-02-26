using UnityEngine;
using System.Collections;

public class TankAttack : MonoBehaviour {

    public GameObject shellPrefab;
    private Transform firePostion;
    public KeyCode fireKey=KeyCode.Space;
    private float shellSpeed = 15;
    public AudioClip shootAudio;

	// Use this for initialization
	void Start () {
        firePostion = transform.Find("FirePosition");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(fireKey))
        {
            AudioSource.PlayClipAtPoint(shootAudio, transform.position);
            GameObject go=GameObject.Instantiate(shellPrefab,firePostion.position,firePostion.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;
        } 
	}
}
