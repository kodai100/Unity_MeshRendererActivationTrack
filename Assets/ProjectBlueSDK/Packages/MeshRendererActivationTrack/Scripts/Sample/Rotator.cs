using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectBlue.MeshRendererActivationTimeline
{

    public class Rotator : MonoBehaviour
    {

        public float speed;

        float time = 0;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            time += Time.deltaTime;


            transform.rotation = Quaternion.Euler(0, time * speed, 0);


        }
    }

}