using UnityEngine;

public class White : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習
    [Header("子彈")]
    public GameObject Bullet;
    [Header("子彈發射位置")]
    public Transform point;
    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip SoundShoot;

    public void Shoot()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            aud.PlayOneShot(SoundShoot);  // 播放音效

            point.position = new Vector3(-3.3f,-2.2f,0);  // 子彈出發的位置
            Quaternion rot = new Quaternion(0, 0, 0, 0);  // 子彈的旋轉
            Instantiate(Bullet,point.position,rot); // 生出子彈
        }
    }

    private void Update()
    {
        Shoot();
    }

    #endregion

    #region KID 區域 - 不要偷看 @3@
    [Header("移動速度"), Range(0f, 100f)]
    public float speed = 1.5f;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        rig.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * speed);
    }
    #endregion
}
