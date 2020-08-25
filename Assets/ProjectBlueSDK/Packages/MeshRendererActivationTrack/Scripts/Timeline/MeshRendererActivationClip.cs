using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace ProjectBlue.MeshRendererActivationTimeline
{

    [Serializable]
    public class MeshRendererActivationClip : PlayableAsset, ITimelineClipAsset
    {
        public MeshRendererActivationBehaviour template = new MeshRendererActivationBehaviour();

        public ClipCaps clipCaps {
            get { return ClipCaps.None; }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<MeshRendererActivationBehaviour>.Create(graph, template);
            MeshRendererActivationBehaviour clone = playable.GetBehaviour();
            return playable;
        }
    }

}