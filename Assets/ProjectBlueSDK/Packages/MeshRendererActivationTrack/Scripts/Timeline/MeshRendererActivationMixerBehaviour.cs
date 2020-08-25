using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace ProjectBlue.MeshRendererActivationTimeline
{
    public class MeshRendererActivationMixerBehaviour : PlayableBehaviour
    {
        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            MeshRendererActivationController trackBinding = playerData as MeshRendererActivationController;

            if (!trackBinding)
                return;

            int inputCount = playable.GetInputCount();

            bool hasInput = false;

            for (int i = 0; i < inputCount; i++)
            {
                float inputWeight = playable.GetInputWeight(i);

                // ScriptPlayable<MeshRendererActivationBehaviour> inputPlayable = (ScriptPlayable<MeshRendererActivationBehaviour>)playable.GetInput(i);
                // MeshRendererActivationBehaviour input = inputPlayable.GetBehaviour ();

                if (playable.GetInputWeight(i) > 0)
                {
                    hasInput = true;
                    break;
                }
            }

            trackBinding.SetActive(hasInput);
        }
    }

}