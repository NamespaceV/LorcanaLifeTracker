using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TurnToggle : MonoBehaviour, IPointerClickHandler
{
    public Sprite ActiveSprite;
    public Sprite InactiveSprite;
    private Image _image;
    private bool _active;


    static public List<TurnToggle> s_all_toggles = new List<TurnToggle>();
    static bool s_init_done = false;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    private void Start()
    {
        if (!s_init_done) {
            s_init_done = true;
            s_all_toggles = FindObjectsOfType<TurnToggle>().ToList();
            SetActive(true);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var active = _active;
        foreach (var t in s_all_toggles) t.SetActive(false);

        if (!active)
        {
            SetActive(true);
        }
        else
        {
            s_all_toggles
            .Where(t => t != this).First()
                .SetActive(true);
        }
    }

    public void SetActive(bool active)
    {
        _active = active;
        _image.sprite = active ? ActiveSprite : InactiveSprite;
    }
}
