using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020E RID: 526
[Token(Token = "0x200020E")]
public class BlockInfo2
{
	// Token: 0x06000A61 RID: 2657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A61")]
	[Address(RVA = "0x1F8C468", Offset = "0x1F8C468", VA = "0x7BBC78C468")]
	public BlockInfo2()
	{
	}

	// Token: 0x040009E6 RID: 2534
	[Token(Token = "0x40009E6")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 center;

	// Token: 0x040009E7 RID: 2535
	[Token(Token = "0x40009E7")]
	[FieldOffset(Offset = "0x1C")]
	public Bounds bounds;

	// Token: 0x040009E8 RID: 2536
	[Token(Token = "0x40009E8")]
	[FieldOffset(Offset = "0x38")]
	public List<ObjectPerfInfo> objects;
}
