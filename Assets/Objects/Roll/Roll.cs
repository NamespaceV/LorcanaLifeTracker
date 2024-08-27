using Assets.CodeOnly;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Roll : MonoBehaviour, IPointerClickHandler
{
    private bool _active;
    private float animTime;
    const float ANIM_DURATION = 0.5f;

    public void Start()
    {
        _active = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _active = true;
        animTime = 0;
    }

    public void Update()
    {
        if (!_active) return;

        transform.Rotate(Vector3.forward, Time.deltaTime * 360.0f / ANIM_DURATION);
        SetRandomStartPlayer();
        animTime += Time.deltaTime;
        if (animTime > ANIM_DURATION) {
            transform.rotation = Quaternion.identity;
            SetRandomStartPlayer();
            _active = false;
        }
    }

    public void SetRandomStartPlayer()
    {
        foreach (var t in TurnToggle.s_all_toggles)
        {
            t.SetActive(false);
        }
        TurnToggle.s_all_toggles.Random().SetActive(true);
    }

}
