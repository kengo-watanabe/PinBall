using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScreen : MonoBehaviour {
    //HingiJointコンポーネントを入れる
    private HingeJoint myHingeJoint;
    //初期の傾き
    private float defaultAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;

    // Use this for initialization
    void Start () {
        //HinjiJointコンポーネント取得
        this.myHingeJoint = GetComponent<HingeJoint>();
        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);

    }
	
	// Update is called once per frame
	void Update () {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began && tag == "LeftFlipperTag":
                    SetAngle(this.flickAngle);
                    

            }
        }
		
	}
}
