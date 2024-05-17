using TMPro;
using UnityEngine;

public class TextBar : ViewHealth
{
    [SerializeField] private TextMeshProUGUI _textHealth;
    
    protected override void Change()
    {
        _textHealth.text = $"{Health.Value}/{Health.MaxValue}";
    }
}
