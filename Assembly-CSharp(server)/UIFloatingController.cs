using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D1 RID: 209
[Token(Token = "0x20000D1")]
public class UIFloatingController : MonoBehaviour
{
	// Token: 0x06000388 RID: 904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000388")]
	[Address(RVA = "0x1CA3FE4", Offset = "0x1CA3FE4", VA = "0x7BBC4A3FE4")]
	private void Start()
	{
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000389")]
	[Address(RVA = "0x1CA4028", Offset = "0x1CA4028", VA = "0x7BBC4A4028")]
	private void FixedUpdate()
	{
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038A")]
	[Address(RVA = "0x1CA4168", Offset = "0x1CA4168", VA = "0x7BBC4A4168")]
	public void SetParam(float _perRadian, float _Radius)
	{
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038B")]
	[Address(RVA = "0x1CA4178", Offset = "0x1CA4178", VA = "0x7BBC4A4178")]
	public UIFloatingController()
	{
	}

	// Token: 0x0400034F RID: 847
	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x18")]
	private float radian;

	// Token: 0x04000350 RID: 848
	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x1C")]
	public float perRadian;

	// Token: 0x04000351 RID: 849
	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0x20")]
	public float radius;

	// Token: 0x04000352 RID: 850
	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 oldPos;

	// Token: 0x04000353 RID: 851
	[Token(Token = "0x4000353")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Enable;
}
