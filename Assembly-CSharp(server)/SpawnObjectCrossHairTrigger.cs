using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003B RID: 59
[Token(Token = "0x200003B")]
public class SpawnObjectCrossHairTrigger : MonoBehaviour
{
	// Token: 0x060000B4 RID: 180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x2261E0C", Offset = "0x2261E0C", VA = "0x7BBCA61E0C")]
	private void OnEnable()
	{
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x2261FCC", Offset = "0x2261FCC", VA = "0x7BBCA61FCC")]
	private void OnDisable()
	{
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x22620A8", Offset = "0x22620A8", VA = "0x7BBCA620A8")]
	private void InitLists()
	{
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x2262024", Offset = "0x2262024", VA = "0x7BBCA62024")]
	private void ClearLists()
	{
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2262140", Offset = "0x2262140", VA = "0x7BBCA62140")]
	public bool HasAgainstEntities()
	{
		return default(bool);
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x22624A8", Offset = "0x22624A8", VA = "0x7BBCA624A8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x22626F8", Offset = "0x22626F8", VA = "0x7BBCA626F8")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x226285C", Offset = "0x226285C", VA = "0x7BBCA6285C")]
	public SpawnObjectCrossHairTrigger()
	{
	}

	// Token: 0x040000E2 RID: 226
	[Token(Token = "0x40000E2")]
	private const uint FLAGID_VEHICLE = 1U;

	// Token: 0x040000E3 RID: 227
	[Token(Token = "0x40000E3")]
	private const uint FLAGID_HUMAN = 2U;

	// Token: 0x040000E4 RID: 228
	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Model;

	// Token: 0x040000E5 RID: 229
	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x0")]
	public static SpawnObjectCrossHairTrigger ActiveInstance;

	// Token: 0x040000E6 RID: 230
	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x20")]
	public List<AgainstObjectType> AgainstObjectTypeList;

	// Token: 0x040000E7 RID: 231
	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<AttackableEntity, List<Collider>> m_EntityDic;

	// Token: 0x040000E8 RID: 232
	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x30")]
	private List<AttackableEntity> m_RemoveList;

	// Token: 0x040000E9 RID: 233
	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x38")]
	private BitArray AgainstTypeFlag;
}
