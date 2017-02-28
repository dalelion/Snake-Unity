using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFactory : MonoBehaviour {
    public Transform FoodObject;

	public void CreateFood() {
        Instantiate(FoodObject, new Vector3(Random.Range(-7, 7), Random.Range(-5, 5), 0), Quaternion.identity);
        Debug.Log("Food Spawned");
    }
}