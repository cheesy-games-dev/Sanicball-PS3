using System.Collections;
using UnityEngine;

namespace Sanicball
{
    public static class UISound
    {
        private static AudioSource instance;

        [RuntimeInitializeOnLoadMethod]
        private static void Init()
        {
            instance = new GameObject("UI Sound").AddComponent<AudioSource>();
            Object.DontDestroyOnLoad(instance.gameObject);
        }


        public static void Play(AudioClip clip)
        {
            instance.PlayOneShot(clip);
        }
    }
}
