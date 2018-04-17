// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using UnityEngine;

namespace RoboRyanTron.Unite2017.Variables
{
    public class VariableAudioTrigger : MonoBehaviour
    {
        public AudioSource AudioSource;

        public SoArchitecture.FloatVariable Variable;

        public SoArchitecture.FloatReference LowThreshold;

        private void Update()
        {
            if (Variable.Value < LowThreshold)
            {
                if (!AudioSource.isPlaying)
                    AudioSource.Play();
            }
            else
            {
                if (AudioSource.isPlaying)
                    AudioSource.Stop();
            }
        }
    }
}