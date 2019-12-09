using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習
    [Header("血量")]
    public int Hp = 10;
    [Header("血量介面")]
    public Text TextHp;
    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip SoundHit;

    private void OnTriggerEnter2D (Collision2D collision)
    {
        if (Hp < 0) return; // 沒有生命不扣血了

        if(collision.gameObject.tag == "子彈")  // 如果碰到子彈執行
        {
            aud.PlayOneShot(SoundHit);  // 播放音效
            Hp = Hp - 1;
            TextHp.text = Hp.ToString();
            print("Hp");
        }
    }


    #endregion
}
