using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //  イガグリプレファブをインスタンス化（実態化）
            GameObject igaguri = Instantiate(igaguriPrefab);


            //  マウスのスクリーン座標をワールドの座標に変換
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //  Rayは光源座標(origin)と光線の方向(direction)をメンバに持っている
            //  光線のベクトルをもらう
            Vector3 worldDir = ray.direction;

            //  弾を撃つ
            igaguri.GetComponent<IgaguriController>().Shoot(worldDir.normalized*2000);
        }
    }
}
