using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour {

    public Transform FoodFab;

	// Use this for initialization
	void Start () {
        FoodFab.GetComponent<FoodFactory>().CreateFood();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
