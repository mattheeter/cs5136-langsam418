using UnityEngine;
using UnityEngine.InputSystem;

public class background_controller : MonoBehaviour
{
    public GameObject defaultBackground;
    public GameObject[] backgrounds;

    int index = -1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      defaultBackground.SetActive(true);
      foreach (GameObject background in backgrounds) {
        background.SetActive(false);
      }

      InputSystem.actions.FindAction("Next").performed += _ => nextBackground();
      InputSystem.actions.FindAction("Previous").performed += _ => prevBackground();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void nextBackground() {
      updateBackground(index + 1);
    }

    void prevBackground() {
      updateBackground(index - 1);
    }

    void updateBackground(int newIndex) {
      int oldIndex = index;
      index = newIndex;

      if (index != oldIndex) {
        if (oldIndex == -1) {
          defaultBackground.SetActive(false);
        } else {
          backgrounds[oldIndex].SetActive(false);
        }

        if (index < -1) {
          index = backgrounds.Length - 1;
          backgrounds[index].SetActive(true);
        } else if (index == -1) {
          defaultBackground.SetActive(true);
        } else if (index < backgrounds.Length) {
          backgrounds[index].SetActive(true);
        } else {
          index = -1;
          defaultBackground.SetActive(true);
        }
      }
    }
}
