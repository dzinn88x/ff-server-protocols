using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000206 RID: 518
[Token(Token = "0x2000206")]
[Serializable]
public class LightmapInfo
{
	// Token: 0x06000A45 RID: 2629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A45")]
	[Address(RVA = "0x2522228", Offset = "0x2522228", VA = "0x7BBCD22228")]
	public LightmapInfo()
	{
	}

	// Token: 0x040009AA RID: 2474
	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x10")]
	public int lightmapIndex;

	// Token: 0x040009AB RID: 2475
	[Token(Token = "0x40009AB")]
	[FieldOffset(Offset = "0x14")]
	public Vector4 lightmapScaleOffset;
}
