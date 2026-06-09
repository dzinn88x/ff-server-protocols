using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006E RID: 110
[Token(Token = "0x200006E")]
[Serializable]
public class PVESceneState
{
	// Token: 0x0600014E RID: 334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014E")]
	[Address(RVA = "0x23C0D38", Offset = "0x23C0D38", VA = "0x7BBCBC0D38")]
	public void InitData()
	{
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014F")]
	[Address(RVA = "0x23C0D3C", Offset = "0x23C0D3C", VA = "0x7BBCBC0D3C")]
	public void EnterState()
	{
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000150")]
	[Address(RVA = "0x23C0F48", Offset = "0x23C0F48", VA = "0x7BBCBC0F48")]
	public PVESceneState()
	{
	}

	// Token: 0x0400016A RID: 362
	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FFB98", Offset = "0x10FFB98")]
	public int index;

	// Token: 0x0400016B RID: 363
	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> ActiveObjects;

	// Token: 0x0400016C RID: 364
	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> DisActiveObjects;

	// Token: 0x0400016D RID: 365
	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x28")]
	public bool IsChangeWheather;

	// Token: 0x0400016E RID: 366
	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x2C")]
	public int WheatherIndex;

	// Token: 0x0400016F RID: 367
	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x30")]
	public float WheatherDuration;
}
