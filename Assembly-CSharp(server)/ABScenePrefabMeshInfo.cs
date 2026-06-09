using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020001CB RID: 459
[Token(Token = "0x20001CB")]
public class ABScenePrefabMeshInfo
{
	// Token: 0x06000999 RID: 2457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000999")]
	[Address(RVA = "0x1F82E0C", Offset = "0x1F82E0C", VA = "0x7BBC782E0C")]
	public ABScenePrefabMeshInfo(int prefabID, List<int> meshIDList)
	{
	}

	// Token: 0x04000921 RID: 2337
	[Token(Token = "0x4000921")]
	[FieldOffset(Offset = "0x10")]
	public int m_prefabID;

	// Token: 0x04000922 RID: 2338
	[Token(Token = "0x4000922")]
	[FieldOffset(Offset = "0x18")]
	public List<int> m_meshIDList;
}
