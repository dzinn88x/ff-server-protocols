using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000208 RID: 520
[Token(Token = "0x2000208")]
public class PerfInfo
{
	// Token: 0x06000A48 RID: 2632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A48")]
	[Address(RVA = "0x23C152C", Offset = "0x23C152C", VA = "0x7BBCBC152C")]
	public PerfInfo()
	{
	}

	// Token: 0x040009B1 RID: 2481
	[Token(Token = "0x40009B1")]
	[FieldOffset(Offset = "0x10")]
	public float height;

	// Token: 0x040009B2 RID: 2482
	[Token(Token = "0x40009B2")]
	[FieldOffset(Offset = "0x14")]
	public int matNum;

	// Token: 0x040009B3 RID: 2483
	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0x18")]
	public HashSet<Material> materials;

	// Token: 0x040009B4 RID: 2484
	[Token(Token = "0x40009B4")]
	[FieldOffset(Offset = "0x20")]
	public int drawCallNum;

	// Token: 0x040009B5 RID: 2485
	[Token(Token = "0x40009B5")]
	[FieldOffset(Offset = "0x24")]
	public int drawCallNumInTotal;

	// Token: 0x040009B6 RID: 2486
	[Token(Token = "0x40009B6")]
	[FieldOffset(Offset = "0x28")]
	public int tris;

	// Token: 0x040009B7 RID: 2487
	[Token(Token = "0x40009B7")]
	[FieldOffset(Offset = "0x2C")]
	public int trisInTotal;

	// Token: 0x040009B8 RID: 2488
	[Token(Token = "0x40009B8")]
	[FieldOffset(Offset = "0x30")]
	public string hint;

	// Token: 0x040009B9 RID: 2489
	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x38")]
	public int warning;
}
