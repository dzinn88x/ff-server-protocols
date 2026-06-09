using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C6 RID: 454
[Token(Token = "0x20001C6")]
[Serializable]
public class SceneSplit
{
	// Token: 0x06000992 RID: 2450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000992")]
	[Address(RVA = "0x2257FA0", Offset = "0x2257FA0", VA = "0x7BBCA57FA0")]
	public SceneSplit()
	{
	}

	// Token: 0x04000903 RID: 2307
	[Token(Token = "0x4000903")]
	[FieldOffset(Offset = "0x10")]
	public int posX;

	// Token: 0x04000904 RID: 2308
	[Token(Token = "0x4000904")]
	[FieldOffset(Offset = "0x14")]
	public int posY;

	// Token: 0x04000905 RID: 2309
	[Token(Token = "0x4000905")]
	[FieldOffset(Offset = "0x18")]
	public int posZ;

	// Token: 0x04000906 RID: 2310
	[Token(Token = "0x4000906")]
	[FieldOffset(Offset = "0x20")]
	public string sceneName;

	// Token: 0x04000907 RID: 2311
	[Token(Token = "0x4000907")]
	[FieldOffset(Offset = "0x28")]
	public GameObject sceneGo;

	// Token: 0x04000908 RID: 2312
	[Token(Token = "0x4000908")]
	[FieldOffset(Offset = "0x30")]
	public bool loaded;

	// Token: 0x04000909 RID: 2313
	[Token(Token = "0x4000909")]
	[FieldOffset(Offset = "0x34")]
	public float posXLimitMove;

	// Token: 0x0400090A RID: 2314
	[Token(Token = "0x400090A")]
	[FieldOffset(Offset = "0x38")]
	public int xDeloadLimit;

	// Token: 0x0400090B RID: 2315
	[Token(Token = "0x400090B")]
	[FieldOffset(Offset = "0x3C")]
	public float posYLimitMove;

	// Token: 0x0400090C RID: 2316
	[Token(Token = "0x400090C")]
	[FieldOffset(Offset = "0x40")]
	public int yDeloadLimit;

	// Token: 0x0400090D RID: 2317
	[Token(Token = "0x400090D")]
	[FieldOffset(Offset = "0x44")]
	public float posZLimitMove;

	// Token: 0x0400090E RID: 2318
	[Token(Token = "0x400090E")]
	[FieldOffset(Offset = "0x48")]
	public int zDeloadLimit;

	// Token: 0x0400090F RID: 2319
	[Token(Token = "0x400090F")]
	[FieldOffset(Offset = "0x4C")]
	public int sceneNameID;

	// Token: 0x04000910 RID: 2320
	[Token(Token = "0x4000910")]
	[FieldOffset(Offset = "0x50")]
	public int sceneBuildID;
}
