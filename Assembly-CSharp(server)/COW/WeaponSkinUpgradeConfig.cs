using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020011A7 RID: 4519
	[Token(Token = "0x20011A7")]
	public class WeaponSkinUpgradeConfig : CSVBaseData
	{
		// Token: 0x0600464C RID: 17996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600464C")]
		[Address(RVA = "0x17A02BC", Offset = "0x17A02BC", VA = "0x7BBBFA02BC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464D")]
		[Address(RVA = "0x17A02C8", Offset = "0x17A02C8", VA = "0x7BBBFA02C8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464E")]
		[Address(RVA = "0x17A0750", Offset = "0x17A0750", VA = "0x7BBBFA0750")]
		public WeaponSkinUpgradeConfig()
		{
		}

		// Token: 0x04005799 RID: 22425
		[Token(Token = "0x4005799")]
		[FieldOffset(Offset = "0x10")]
		public uint weapon_skin_id;

		// Token: 0x0400579A RID: 22426
		[Token(Token = "0x400579A")]
		[FieldOffset(Offset = "0x14")]
		public uint next_id;

		// Token: 0x0400579B RID: 22427
		[Token(Token = "0x400579B")]
		[FieldOffset(Offset = "0x18")]
		public uint level;

		// Token: 0x0400579C RID: 22428
		[Token(Token = "0x400579C")]
		[FieldOffset(Offset = "0x20")]
		public List<WeaponSkinUpdateItemDesc> items;

		// Token: 0x0400579D RID: 22429
		[Token(Token = "0x400579D")]
		[FieldOffset(Offset = "0x28")]
		public uint reward_item;
	}
}
