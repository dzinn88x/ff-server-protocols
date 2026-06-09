using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200022A RID: 554
[Token(Token = "0x200022A")]
[Serializable]
public class UV2
{
	// Token: 0x06000B34 RID: 2868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B34")]
	[Address(RVA = "0x260CA50", Offset = "0x260CA50", VA = "0x7BBCE0CA50")]
	public UV2(Vector2[] verts)
	{
	}

	// Token: 0x06000B35 RID: 2869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B35")]
	[Address(RVA = "0x260CA7C", Offset = "0x260CA7C", VA = "0x7BBCE0CA7C")]
	public static implicit operator UV2(Vector2[] verts)
	{
		return null;
	}

	// Token: 0x04000A2E RID: 2606
	[Token(Token = "0x4000A2E")]
	[FieldOffset(Offset = "0x10")]
	public Vector2[] verts;
}
