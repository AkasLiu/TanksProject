using UnityEngine;
using System.Collections;

public class TankAttack : MonoBehaviour {

    public GameObject shellPrefab;
    private Transform firePostion;
    public KeyCode fireKey=KeyCode.Space;

	// Use this for initialization
	void Start () {
        firePostion = transform.Find("FirePosition");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(fireKey))
        {
            GameObject.Instantiate(shellPrefab,firePostion.position,firePostion.rotation);
        }
	}
}
