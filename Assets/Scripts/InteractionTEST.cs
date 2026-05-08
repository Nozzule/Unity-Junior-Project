

namespace EJETAGame
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    //interface IInteractable
    //{
        //public void Interact();
    //}

    /**
     * Interactable test case where we change the color of a sphere gameobject
     * into a random color;
     */
    public class InteractionTEST : MonoBehaviour, IInteractable
    {
        public GameObject player;
        private Color randomColor;
        //public Transform InteractorSource;
        //public float InteractRange;
        public KeyCode escapeKey;
        public float detectionRange = 5;
        //bool keyReleased = false;
        //int lastPieceCount = 0;
        public GameObject canvasToToggle;

        //Which button the user must press to initiate the Interaction;
        public KeyCode interactionKey;
        public void Interact()
        {
            //if (Input.GetKeyDown(interactionKey))
            //{
                //this.GetComponent<Renderer>().material.color = RandomColor();
                //Debug.Log("Success");
            //}
                
        }

        //When our interaction begin, we set the UI text to prompt the user to
        //press a button to interact with the gameobject;
        public void OnInteractEnter()
        {
            InteractionText.instance.SetText("Press "+interactionKey+" to interact");
        }


        //We can debug a statement to let us know when the interaction ends;
        public void OnInteractExit()
        {
            Debug.Log("Interaction Ended");
        }

        private Color RandomColor()
        {
            return randomColor = Random.ColorHSV();
        }

        //public void Update()
        //{
            //if (Input.GetKeyDown(interactionKey))
            //{
                //Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
                //if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
                //{
                    //if (hitInfo.collider.gameObject.TryGetcomponent(out IInteractable interactObj))
                    //{
                        //interactObj.Interact();
                    //}
                //}
            //}
        //}
    }
}
