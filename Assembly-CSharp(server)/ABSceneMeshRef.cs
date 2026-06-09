using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CC RID: 460
[Token(Token = "0x20001CC")]
public class ABSceneMeshRef
{
	// Token: 0x0600099A RID: 2458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099A")]
	[Address(RVA = "0x1F82DD0", Offset = "0x1F82DD0", VA = "0x7BBC782DD0")]
	public ABSceneMeshRef(int refCount, Mesh mesh)
	{
	}

	// Token: 0x04000923 RID: 2339
	[Token(Token = "0x4000923")]
	[FieldOffset(Offset = "0x10")]
	public int m_refCount;

	// Token: 0x04000924 RID: 2340
	[Token(Token = "0x4000924")]
	[FieldOffset(Offset = "0x18")]
	public Mesh m_mesh;
}
