using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CE RID: 462
[Token(Token = "0x20001CE")]
public class ABSceneMatRef
{
	// Token: 0x0600099C RID: 2460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099C")]
	[Address(RVA = "0x1F82DC8", Offset = "0x1F82DC8", VA = "0x7BBC782DC8")]
	public ABSceneMatRef()
	{
	}

	// Token: 0x04000927 RID: 2343
	[Token(Token = "0x4000927")]
	[FieldOffset(Offset = "0x10")]
	public List<KeyValuePair<int, short>> m_texPairs;

	// Token: 0x04000928 RID: 2344
	[Token(Token = "0x4000928")]
	[FieldOffset(Offset = "0x18")]
	public int m_refCount;

	// Token: 0x04000929 RID: 2345
	[Token(Token = "0x4000929")]
	[FieldOffset(Offset = "0x20")]
	public Material m_mat;
}
