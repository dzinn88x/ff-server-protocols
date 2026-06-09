using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020B RID: 523
[Token(Token = "0x200020B")]
public class SceneLightmapFile : ScriptableObject
{
	// Token: 0x06000A5C RID: 2652 RVA: 0x00003FF0 File Offset: 0x000021F0
	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x2257C80", Offset = "0x2257C80", VA = "0x7BBCA57C80")]
	public static bool SameID(int[] lhs, int[] rhs)
	{
		return default(bool);
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x2257D94", Offset = "0x2257D94", VA = "0x7BBCA57D94")]
	public LightmapAreaInfoNoRef GetAreaLightmap(int[] areaID, bool createIfNotExists = true)
	{
		return null;
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5E")]
	[Address(RVA = "0x2257F20", Offset = "0x2257F20", VA = "0x7BBCA57F20")]
	public SceneLightmapFile()
	{
	}

	// Token: 0x040009D3 RID: 2515
	[Token(Token = "0x40009D3")]
	[FieldOffset(Offset = "0x18")]
	public int versionID;

	// Token: 0x040009D4 RID: 2516
	[Token(Token = "0x40009D4")]
	[FieldOffset(Offset = "0x1C")]
	public bool version2018;

	// Token: 0x040009D5 RID: 2517
	[Token(Token = "0x40009D5")]
	[FieldOffset(Offset = "0x20")]
	public List<LightmapAreaInfoNoRef> areaLightmaps;
}
