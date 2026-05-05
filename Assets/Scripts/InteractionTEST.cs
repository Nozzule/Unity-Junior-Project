

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
        private Color randomColor;
        public GameObject canvasToToggle;
        //public Transform InteractorSource;
        //public float InteractRange;
        private float puzzle2Piece = 0;
        public KeyCode escapeKey;

        //Which button the user must press to initiate the Interaction;
        public KeyCode interactionKey;
        public void Interact()
        {
            //if (Input.GetKeyDown(interactionKey))
            //{
                //this.GetComponent<Renderer>().material.color = RandomColor();
                //Debug.Log("Success");
            //}
            Update();
                
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

        void start()
        {
            canvasToToggle.SetActive(false);
        }

        void Update()
        {
            //Keypad is almost done, ask Geiger about how to fix the issue where it won't appear the first time.
            if (Input.GetKeyDown(interactionKey) && gameObject.CompareTag("Puzzle1"))
            {
                Debug.Log("Success");
                canvasToToggle.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else if (Input.GetKeyDown(escapeKey) && gameObject.CompareTag("Puzzle1"))
            {
                Debug.Log("Exited");
                canvasToToggle.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }

            if (Input.GetKeyDown(interactionKey) && gameObject.CompareTag("Puzzle2Piece"))
            {
                Debug.Log("Success");
                puzzle2Piece ++;
                //Destroy(gameObject.CompareTag("Puzzle2Piece"));
            }
        }
    }

}
