using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020C RID: 524
[Token(Token = "0x200020C")]
[Serializable]
public class ObjectPerfInfo
{
	// Token: 0x06000A5F RID: 2655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5F")]
	[Address(RVA = "0x2291574", Offset = "0x2291574", VA = "0x7BBCA91574")]
	public ObjectPerfInfo()
	{
	}

	// Token: 0x040009D6 RID: 2518
	[Token(Token = "0x40009D6")]
	[FieldOffset(Offset = "0x10")]
	public Renderer renderer;

	// Token: 0x040009D7 RID: 2519
	[Token(Token = "0x40009D7")]
	[FieldOffset(Offset = "0x18")]
	public Bounds bounds;

	// Token: 0x040009D8 RID: 2520
	[Token(Token = "0x40009D8")]
	[FieldOffset(Offset = "0x30")]
	public int tris;

	// Token: 0x040009D9 RID: 2521
	[Token(Token = "0x40009D9")]
	[FieldOffset(Offset = "0x38")]
	public Material[] mats;

	// Token: 0x040009DA RID: 2522
	[Token(Token = "0x40009DA")]
	[FieldOffset(Offset = "0x40")]
	public bool lightmapped;

	// Token: 0x040009DB RID: 2523
	[Token(Token = "0x40009DB")]
	[FieldOffset(Offset = "0x41")]
	public bool trisPreventBatch;

	// Token: 0x040009DC RID: 2524
	[Token(Token = "0x40009DC")]
	[FieldOffset(Offset = "0x44")]
	public int lodLevel;

	// Token: 0x040009DD RID: 2525
	[Token(Token = "0x40009DD")]
	[FieldOffset(Offset = "0x48")]
	public LODGroup lodGroup;

	// Token: 0x040009DE RID: 2526
	[Token(Token = "0x40009DE")]
	[FieldOffset(Offset = "0x50")]
	public string tag;
}
