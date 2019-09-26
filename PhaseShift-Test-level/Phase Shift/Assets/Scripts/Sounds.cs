using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sounds : MonoBehaviour
{

    public AudioSource teleportSound;
    public Image flash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(Flash());
            teleportSound.Play();
            //flash.enabled = true;
            
        }
    }

    public IEnumerator Flash()
    {
        flash.enabled = true;
        yield return new WaitForSeconds(0.5f);
        flash.enabled = false;
    }
}
