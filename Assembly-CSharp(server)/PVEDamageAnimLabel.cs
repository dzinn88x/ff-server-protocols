using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000139 RID: 313
[Token(Token = "0x2000139")]
internal class PVEDamageAnimLabel : MonoBehaviour
{
	// Token: 0x17000050 RID: 80
	// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000050")]
	public AttackableEntity Owner
	{
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x22AC050", Offset = "0x22AC050", VA = "0x7BBCAAC050")]
		set
		{
		}
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x22AC058", Offset = "0x22AC058", VA = "0x7BBCAAC058")]
	private void Awake()
	{
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x22AC448", Offset = "0x22AC448", VA = "0x7BBCAAC448")]
	private void Start()
	{
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x22AC458", Offset = "0x22AC458", VA = "0x7BBCAAC458")]
	private void MoveObjecTo()
	{
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x000030F0 File Offset: 0x000012F0
	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x22AC6EC", Offset = "0x22AC6EC", VA = "0x7BBCAAC6EC")]
	public float ReduceValue()
	{
		return 0f;
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E5")]
	[Address(RVA = "0x22AC9B4", Offset = "0x22AC9B4", VA = "0x7BBCAAC9B4")]
	public void SetLabelString(int score, Color color, bool followTarget = true)
	{
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x22ACC00", Offset = "0x22ACC00", VA = "0x7BBCAACC00")]
	public void Reset()
	{
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00003108 File Offset: 0x00001308
	[Token(Token = "0x17000051")]
	public bool IsUsing
	{
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x22ACF80", Offset = "0x22ACF80", VA = "0x7BBCAACF80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x22ACF88", Offset = "0x22ACF88", VA = "0x7BBCAACF88")]
	private void Update()
	{
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x22AD014", Offset = "0x22AD014", VA = "0x7BBCAAD014")]
	public void OnFinished()
	{
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005EA")]
	[Address(RVA = "0x22AD110", Offset = "0x22AD110", VA = "0x7BBCAAD110")]
	public PVEDamageAnimLabel()
	{
	}

	// Token: 0x04000507 RID: 1287
	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0x18")]
	public UILabel m_Label;

	// Token: 0x04000508 RID: 1288
	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0x20")]
	public float[] HeadPos;

	// Token: 0x04000509 RID: 1289
	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x28")]
	public bool FollowTarget;

	// Token: 0x0400050A RID: 1290
	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0x2C")]
	public float DistanceHead;

	// Token: 0x0400050B RID: 1291
	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x30")]
	public float RedColorScale;

	// Token: 0x0400050C RID: 1292
	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x34")]
	public bool DistanceReduce;

	// Token: 0x0400050D RID: 1293
	[Token(Token = "0x400050D")]
	[FieldOffset(Offset = "0x35")]
	private bool m_IsStart;

	// Token: 0x0400050E RID: 1294
	[Token(Token = "0x400050E")]
	[FieldOffset(Offset = "0x38")]
	private AttackableEntity m_Owner;

	// Token: 0x0400050F RID: 1295
	[Token(Token = "0x400050F")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 m_MovePos;

	// Token: 0x04000510 RID: 1296
	[Token(Token = "0x4000510")]
	[FieldOffset(Offset = "0x4C")]
	private float m_RandX;

	// Token: 0x04000511 RID: 1297
	[Token(Token = "0x4000511")]
	[FieldOffset(Offset = "0x50")]
	private float m_RandY;

	// Token: 0x04000512 RID: 1298
	[Token(Token = "0x4000512")]
	[FieldOffset(Offset = "0x58")]
	private TweenScale m_Scale;

	// Token: 0x04000513 RID: 1299
	[Token(Token = "0x4000513")]
	[FieldOffset(Offset = "0x60")]
	private TweenPosition m_LabelPos;

	// Token: 0x04000514 RID: 1300
	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0x68")]
	private Transform m_CachedTransform;

	// Token: 0x04000515 RID: 1301
	[Token(Token = "0x4000515")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsUsing;

	// Token: 0x04000516 RID: 1302
	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x78")]
	private UITweener[] m_Tweeners;

	// Token: 0x04000517 RID: 1303
	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x80")]
	private Vector3[] m_CacheScaleValue;

	// Token: 0x04000518 RID: 1304
	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x88")]
	private bool m_StillFollow;
}
