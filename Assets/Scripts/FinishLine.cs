using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour {

    public Text score;
    public Sprite[] numbers;
    public SpriteRenderer number;
    public int counter = 0;
	// Use this for initialization
	void Start () {
        score.text = "Score: " + counter;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        counter++;
        score.text = "Score: " + counter;
        number.sprite = numbers[counter];
    }
}
