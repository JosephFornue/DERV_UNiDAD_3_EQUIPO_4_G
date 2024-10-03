using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class NewBehaviourScript : MonoBehaviour
{
    private AudioSource audioSource;

    void Start(){
        audioSource = GetComponent<AudioSource>();
    }
   private void OnTriggerEnter(Collider other){
    if (other.CompareTag("Player")){
        audioSource.Play();
   }
}

private void OnTriggerExit(Collider other) {
    if (other.CompareTag("Player")){
        audioSource.Stop();
    }
}
}
