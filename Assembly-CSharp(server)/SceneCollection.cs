using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C4 RID: 452
[Token(Token = "0x20001C4")]
[ExecuteInEditMode]
[Serializable]
public class SceneCollection : MonoBehaviour
{
	// Token: 0x06000990 RID: 2448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000990")]
	[Address(RVA = "0x225675C", Offset = "0x225675C", VA = "0x7BBCA5675C")]
	public SceneCollection()
	{
	}

	// Token: 0x040008EF RID: 2287
	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x18")]
	public string prefixName;

	// Token: 0x040008F0 RID: 2288
	[Token(Token = "0x40008F0")]
	[FieldOffset(Offset = "0x20")]
	public string prefixScene;

	// Token: 0x040008F1 RID: 2289
	[Token(Token = "0x40008F1")]
	[FieldOffset(Offset = "0x28")]
	public string path;

	// Token: 0x040008F2 RID: 2290
	[Token(Token = "0x40008F2")]
	[FieldOffset(Offset = "0x30")]
	public string[] names;

	// Token: 0x040008F3 RID: 2291
	[Token(Token = "0x40008F3")]
	[FieldOffset(Offset = "0x38")]
	public bool xSplitIs;

	// Token: 0x040008F4 RID: 2292
	[Token(Token = "0x40008F4")]
	[FieldOffset(Offset = "0x39")]
	public bool ySplitIs;

	// Token: 0x040008F5 RID: 2293
	[Token(Token = "0x40008F5")]
	[FieldOffset(Offset = "0x3A")]
	public bool zSplitIs;

	// Token: 0x040008F6 RID: 2294
	[Token(Token = "0x40008F6")]
	[FieldOffset(Offset = "0x3C")]
	public int xSize;

	// Token: 0x040008F7 RID: 2295
	[Token(Token = "0x40008F7")]
	[FieldOffset(Offset = "0x40")]
	public int ySize;

	// Token: 0x040008F8 RID: 2296
	[Token(Token = "0x40008F8")]
	[FieldOffset(Offset = "0x44")]
	public int zSize;

	// Token: 0x040008F9 RID: 2297
	[Token(Token = "0x40008F9")]
	[FieldOffset(Offset = "0x48")]
	public int xLimitsx;

	// Token: 0x040008FA RID: 2298
	[Token(Token = "0x40008FA")]
	[FieldOffset(Offset = "0x4C")]
	public int xLimitsy;

	// Token: 0x040008FB RID: 2299
	[Token(Token = "0x40008FB")]
	[FieldOffset(Offset = "0x50")]
	public int yLimitsx;

	// Token: 0x040008FC RID: 2300
	[Token(Token = "0x40008FC")]
	[FieldOffset(Offset = "0x54")]
	public int yLimitsy;

	// Token: 0x040008FD RID: 2301
	[Token(Token = "0x40008FD")]
	[FieldOffset(Offset = "0x58")]
	public int zLimitsx;

	// Token: 0x040008FE RID: 2302
	[Token(Token = "0x40008FE")]
	[FieldOffset(Offset = "0x5C")]
	public int zLimitsy;

	// Token: 0x040008FF RID: 2303
	[Token(Token = "0x40008FF")]
	[FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public bool collapsed;

	// Token: 0x04000900 RID: 2304
	[Token(Token = "0x4000900")]
	[FieldOffset(Offset = "0x64")]
	[HideInInspector]
	public int layerNumber;

	// Token: 0x04000901 RID: 2305
	[Token(Token = "0x4000901")]
	[FieldOffset(Offset = "0x68")]
	public Color color;
}
