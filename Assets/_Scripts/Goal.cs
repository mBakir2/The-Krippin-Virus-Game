using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
/**
 * Authors: Anmoldeep Singh Gill
 *          Chadwick Lapis
 *          Mohammad Bakir
 * Last Modified on: 16th Feb 2020
 */
public class Goal : MonoBehaviour
{
    public AudioSource SFXChannel;
    public AudioClip goalSFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            SFXChannel.PlayOneShot(goalSFX);
            GameData.goals++;
        }
    }
}
