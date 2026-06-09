using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000036 RID: 54
[Token(Token = "0x2000036")]
public class PVEHyakkiMatchConfig : MonoBehaviour
{
	// Token: 0x060000AA RID: 170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x23C0B44", Offset = "0x23C0B44", VA = "0x7BBCBC0B44")]
	private void Awake()
	{
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x23C0BF8", Offset = "0x23C0BF8", VA = "0x7BBCBC0BF8")]
	public PVEHyakkiMatchConfig()
	{
	}

	// Token: 0x040000D8 RID: 216
	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FF984", Offset = "0x10FF984")]
	public int GeneralSpawnMaxAliveCount;

	// Token: 0x040000D9 RID: 217
	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FF9BC", Offset = "0x10FF9BC")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FF9BC", Offset = "0x10FF9BC")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FF9BC", Offset = "0x10FF9BC")]
	public List<PVEHyakkiMatchDifficultyRelatedConfig> DifficultyRelatedConfigs;
}
