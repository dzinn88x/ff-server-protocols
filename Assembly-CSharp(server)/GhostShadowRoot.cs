using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000061 RID: 97
[Token(Token = "0x2000061")]
public class GhostShadowRoot : MonoBehaviour
{
	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600012B RID: 299 RVA: 0x000022C8 File Offset: 0x000004C8
	[Token(Token = "0x1700000C")]
	public bool IsActive
	{
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x274A554", Offset = "0x274A554", VA = "0x7BBCF4A554")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x274A2B8", Offset = "0x274A2B8", VA = "0x7BBCF4A2B8")]
	public void Active(float endTime)
	{
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012D")]
	[Address(RVA = "0x274A55C", Offset = "0x274A55C", VA = "0x7BBCF4A55C")]
	private void Update()
	{
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x274A400", Offset = "0x274A400", VA = "0x7BBCF4A400")]
	public void DisActive()
	{
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x274AAA0", Offset = "0x274AAA0", VA = "0x7BBCF4AAA0")]
	public GhostShadowRoot()
	{
	}

	// Token: 0x04000143 RID: 323
	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0x18")]
	public GhostShadowRoot.onEffectFinsih OnEffectFinish;

	// Token: 0x04000144 RID: 324
	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public List<GhostShadowEffect> GhostEffectList;

	// Token: 0x04000145 RID: 325
	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public float EndTime;

	// Token: 0x04000146 RID: 326
	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x2C")]
	private bool bActive;

	// Token: 0x02000062 RID: 98
	// (Invoke) Token: 0x06000131 RID: 305
	[Token(Token = "0x2000062")]
	public delegate void onEffectFinsih();
}
