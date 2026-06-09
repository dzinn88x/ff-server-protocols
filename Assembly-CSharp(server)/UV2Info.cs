using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200022B RID: 555
[Token(Token = "0x200022B")]
public class UV2Info : ScriptableObject
{
	// Token: 0x06000B36 RID: 2870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B36")]
	[Address(RVA = "0x260CAE0", Offset = "0x260CAE0", VA = "0x7BBCE0CAE0")]
	public UV2Info()
	{
	}

	// Token: 0x04000A2F RID: 2607
	[Token(Token = "0x4000A2F")]
	[FieldOffset(Offset = "0x18")]
	public Mesh[] meshes;

	// Token: 0x04000A30 RID: 2608
	[Token(Token = "0x4000A30")]
	[FieldOffset(Offset = "0x20")]
	public Mesh[] clonedMeshes;
}
