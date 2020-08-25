using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace ProjectBlue.MeshRendererActivationTimeline
{

    [TrackColor(0f, 1f, 0.0516715f)]
    [TrackClipType(typeof(MeshRendererActivationClip))]
    [TrackBindingType(typeof(MeshRendererActivationController))]
    public class MeshRendererActivationTrack : TrackAsset
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return ScriptPlayable<MeshRendererActivationMixerBehaviour>.Create(graph, inputCount);
        }
    }

}