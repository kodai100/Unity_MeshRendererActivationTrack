using System.Collections.Generic;
using UnityEngine;

namespace ProjectBlue.MeshRendererActivationTimeline
{

    public class MeshRendererActivationController : MonoBehaviour
    {

        [SerializeField]
        List<MeshRenderer> targetMeshRenderers = new List<MeshRenderer>();

        public bool Active { get; private set; } = true;


        private void Reset()
        {

            var renderer = GetComponent<MeshRenderer>();

            if (renderer)
            {
                targetMeshRenderers.Add(renderer);
            }
        }

        public void SetActive(bool isActive)
        {
            Active = isActive;


            if (targetMeshRenderers == null) return;

            targetMeshRenderers.ForEach(renderer =>
            {

                renderer.enabled = Active;

            });
        }
    }

}