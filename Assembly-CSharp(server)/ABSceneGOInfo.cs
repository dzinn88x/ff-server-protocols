using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CA RID: 458
[Token(Token = "0x20001CA")]
public class ABSceneGOInfo
{
	// Token: 0x06000998 RID: 2456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000998")]
	[Address(RVA = "0x1F82BEC", Offset = "0x1F82BEC", VA = "0x7BBC782BEC")]
	public ABSceneGOInfo(int id, Vector3 pos, Quaternion rotation, Vector3 scale, string previewname, List<ABSceneLightMapInfo> lightmapInfoList)
	{
	}

	// Token: 0x0400091A RID: 2330
	[Token(Token = "0x400091A")]
	[FieldOffset(Offset = "0x10")]
	public int m_prefabID;

	// Token: 0x0400091B RID: 2331
	[Token(Token = "0x400091B")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 m_pos;

	// Token: 0x0400091C RID: 2332
	[Token(Token = "0x400091C")]
	[FieldOffset(Offset = "0x20")]
	public Quaternion m_rotation;

	// Token: 0x0400091D RID: 2333
	[Token(Token = "0x400091D")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 m_scale;

	// Token: 0x0400091E RID: 2334
	[Token(Token = "0x400091E")]
	[FieldOffset(Offset = "0x40")]
	public string m_previewName;

	// Token: 0x0400091F RID: 2335
	[Token(Token = "0x400091F")]
	[FieldOffset(Offset = "0x48")]
	public List<ABSceneLightMapInfo> m_lightmapInfoList;

	// Token: 0x04000920 RID: 2336
	[Token(Token = "0x4000920")]
	[FieldOffset(Offset = "0x50")]
	public ABLevelObjectInfo LevelObjectInfo;
}
