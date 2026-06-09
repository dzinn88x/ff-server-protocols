using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003C RID: 60
[Token(Token = "0x200003C")]
[Attribute(Name = "RequireComponent", RVA = "0x10E1A04", Offset = "0x10E1A04")]
public class LevelPickupSupply : MonoBehaviour
{
	// Token: 0x060000BC RID: 188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x2521E90", Offset = "0x2521E90", VA = "0x7BBCD21E90")]
	private void Start()
	{
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x2521EC8", Offset = "0x2521EC8", VA = "0x7BBCD21EC8")]
	public LevelPickupSupply()
	{
	}

	// Token: 0x040000EA RID: 234
	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x18")]
	public uint m_RoundID;

	// Token: 0x040000EB RID: 235
	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x1C")]
	public uint m_SubRoundID;

	// Token: 0x040000EC RID: 236
	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x20")]
	public List<LevelPickupSupply.SupplyInfo> m_SupplyInfos;

	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[Serializable]
	public struct SupplyInfo
	{
		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x0")]
		public uint m_ItemID;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x4")]
		public uint m_ItemNum;
	}
}
