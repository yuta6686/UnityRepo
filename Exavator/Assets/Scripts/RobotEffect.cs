using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEffect : MonoBehaviour
{
    public ParticleSystem eff_aura;

    

    // Start is called before the first frame update
    void Start()
    {
        eff_aura = eff_aura.GetComponent<ParticleSystem>();

        
    }

    // Update is called once per frame
    void Update()
    {                      
       /* if (Input.GetKey(KeyCode.Space))
        {
                
            eff_aura.Play();
        }  */                         
    }
}
