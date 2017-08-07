using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    //スコアを表示するテキスト
    private GameObject ScoreText;
    //初期スコアを設定
    int TotalScore = 0;
    //タグによっての点数を決める
    //SmallStarTagのスコア
    int SmallStarScore = 10;
    //LargeStarTagのスコア
    int LargeStarScore = 20;
    //SmallCloudTagのスコア
    int SmallCloudScore = 30;
    //LargeCloudTagのスコア
    int LargeCloudScore = 50;

	// Use this for initialization
	void Start () {
       
        //シーン中のScoreTextオブジェクトを取得
        this.ScoreText = GameObject.Find("ScoreText");
		
	}
	
	// Update is called once per frame
	void Update () {     

        //ScoreTextにスコアを表示
        this.ScoreText.GetComponent<UnityEngine.UI.Text>().text = "Score" + TotalScore;
		
	}
    //衝突時に呼ばれる関数
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            TotalScore += SmallStarScore; 
        }else if(collision.gameObject.tag == "LargeStarTag")
        {
            TotalScore += LargeStarScore;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            TotalScore += SmallCloudScore;
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            TotalScore += LargeCloudScore;
        }



    }
}

