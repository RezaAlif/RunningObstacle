using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class MyScript : MonoBehaviour
    {
        public FixedTouchField touchField;
        public FixedButton button;
        bool Lari;
        GameManager manager;

        // Use this for initialization
        void Start()
        {
            manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {
            var fps = GetComponent < RigidbodyFirstPersonController> ();

            fps.RunAxis = new Vector2(0, 2);
            fps.JumpAxis = button.Pressed;
            fps.mouseLook.LookAxis = touchField.TouchDist;
            Running();
        }

        void Running() {
            var fps = GetComponent<RigidbodyFirstPersonController>();

            if(manager.Dead == false)
            {
                fps.movementSettings.ForwardSpeed = 10;
                fps.movementSettings.StrafeSpeed = 10;
            }
            else
            {
                fps.movementSettings.ForwardSpeed = 0;
                fps.movementSettings.StrafeSpeed = 0;
            }
        }

        public void Run(bool Berlari) {
            Lari = Berlari;
        }
    }
}