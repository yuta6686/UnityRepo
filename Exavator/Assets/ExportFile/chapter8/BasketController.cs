using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip bombSE;

    AudioSource aud;

    GameObject director;

    // Start is called before the first frame update
    void Start()
    {
        director = GameObject.Find("GameDirector");
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Apple")
        {
            Debug.Log("Tag = Apple");
            aud.PlayOneShot(this.appleSE);
            director.GetComponent<GameDirectorBasket>().GetApple();
            
        }
        else if(other.gameObject.tag == "Bomb")
        {
            Debug.Log("Tag = Bomb");
            aud.PlayOneShot(this.bombSE);
            director.GetComponent<GameDirectorBasket>().GetBomb();
        }

        
        Destroy(other.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //  マウス座標をワールド座標に変換
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            
            RaycastHit hit;

            //  光線がステージにあたっているか？
            if (Physics.Raycast(ray,out hit, Mathf.Infinity))
            {

                //  四捨五入
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);

                transform.position = new Vector3(x, 0, z);
            }
        }
    }
}
