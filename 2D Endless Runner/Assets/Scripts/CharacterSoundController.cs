using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{
    public AudioClip jump;

    public AudioClip scoreHighlight;

    private AudioSource audioPlayer;

    // Start is called before the first frame update
    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    public void playJump()
    {
        audioPlayer.PlayOneShot(jump);
    }

    public void PlayScoreHighlight()
    {
        audioPlayer.PlayOneShot(scoreHighlight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
