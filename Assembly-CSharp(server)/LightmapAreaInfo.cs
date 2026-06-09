using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000207 RID: 519
[Token(Token = "0x2000207")]
[Serializable]
public class LightmapAreaInfo
{
	// Token: 0x06000A46 RID: 2630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A46")]
	[Address(RVA = "0x2521ED0", Offset = "0x2521ED0", VA = "0x7BBCD21ED0")]
	public void Clear()
	{
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A47")]
	[Address(RVA = "0x2521F9C", Offset = "0x2521F9C", VA = "0x7BBCD21F9C")]
	public LightmapAreaInfo()
	{
	}

	// Token: 0x040009AC RID: 2476
	[Token(Token = "0x40009AC")]
	[FieldOffset(Offset = "0x10")]
	public int[] areaID;

	// Token: 0x040009AD RID: 2477
	[Token(Token = "0x40009AD")]
	[FieldOffset(Offset = "0x18")]
	public List<Renderer> renderers;

	// Token: 0x040009AE RID: 2478
	[Token(Token = "0x40009AE")]
	[FieldOffset(Offset = "0x20")]
	public List<Texture2D> lightmaps;

	// Token: 0x040009AF RID: 2479
	[Token(Token = "0x40009AF")]
	[FieldOffset(Offset = "0x28")]
	public List<Texture2D> shadowmasks;

	// Token: 0x040009B0 RID: 2480
	[Token(Token = "0x40009B0")]
	[FieldOffset(Offset = "0x30")]
	public List<LightmapInfo> lightmapInfo;
}
