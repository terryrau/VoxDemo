using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour {

    //public Text score;
    public Sprite[] numbers;
    public GameObject[] numPos;
    //public SpriteRenderer number;
    public int score = 0;
    public int maxScore = 9999;
    char[] arrOfNum;
    public bool recalc;


    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        score++;
        UpdateScore(score);
    }

    void UpdateScore(int score)
    {
        arrOfNum = score.ToString().ToCharArray();

        if(score > maxScore)
        {
            score = maxScore;
            UpdateScore(score);
        }else if(score < 0){
            score = 0;
            UpdateScore(score);
        }
        else
        {
            for(int i = 0; i < arrOfNum.Length; i++)
            {
                int y = int.Parse(arrOfNum[i].ToString());
                numPos[i].SetActive(true);
                numPos[i].GetComponent<SpriteRenderer>().sprite = numbers[y];
            }

            //check for trailing zeros to hide
            if(arrOfNum.Length < numPos.Length)
            {
                for(int i = arrOfNum.Length; i < numPos.Length; i++)
                {
                    numPos[i].SetActive(false);
                }
            }
        }

    }
}
