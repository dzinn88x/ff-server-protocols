using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020A RID: 522
[Token(Token = "0x200020A")]
[Serializable]
public class LightmapAreaInfoNoRef
{
	// Token: 0x06000A5A RID: 2650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5A")]
	[Address(RVA = "0x252207C", Offset = "0x252207C", VA = "0x7BBCD2207C")]
	public void Clear()
	{
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x2522148", Offset = "0x2522148", VA = "0x7BBCD22148")]
	public LightmapAreaInfoNoRef()
	{
	}

	// Token: 0x040009CE RID: 2510
	[Token(Token = "0x40009CE")]
	[FieldOffset(Offset = "0x10")]
	public int[] areaID;

	// Token: 0x040009CF RID: 2511
	[Token(Token = "0x40009CF")]
	[FieldOffset(Offset = "0x18")]
	public List<string> rendererID;

	// Token: 0x040009D0 RID: 2512
	[Token(Token = "0x40009D0")]
	[FieldOffset(Offset = "0x20")]
	public List<Texture2D> lightmaps;

	// Token: 0x040009D1 RID: 2513
	[Token(Token = "0x40009D1")]
	[FieldOffset(Offset = "0x28")]
	public List<Texture2D> shadowmasks;

	// Token: 0x040009D2 RID: 2514
	[Token(Token = "0x40009D2")]
	[FieldOffset(Offset = "0x30")]
	public List<LightmapInfo> lightmapInfo;
}
