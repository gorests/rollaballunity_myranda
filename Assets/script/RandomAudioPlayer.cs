using UnityEngine;
using System.Collections;

public class RandomAudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;  // The AudioSource component
    public float minTime = 2f;      // Minimum random time interval (seconds)
    public float maxTime = 5f;      // Maximum random time interval (seconds)

    private void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();  // Get the AudioSource if not assigned in Inspector
        }

        StartCoroutine(PlayRandomAudio());
    }

    private IEnumerator PlayRandomAudio()
    {
        while (true)
        {
            float randomTime = Random.Range(minTime, maxTime); // Get random time between minTime and maxTime
            yield return new WaitForSeconds(randomTime);       // Wait for random time interval

            audioSource.Play();  // Play the audio
        }
    }
}
