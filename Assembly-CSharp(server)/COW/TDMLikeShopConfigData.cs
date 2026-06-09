using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001190 RID: 4496
	[Token(Token = "0x2001190")]
	internal class TDMLikeShopConfigData : CSVBaseData
	{
		// Token: 0x060045FB RID: 17915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045FB")]
		[Address(RVA = "0x1B41A74", Offset = "0x1B41A74", VA = "0x7BBC341A74", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FC")]
		[Address(RVA = "0x1B41A80", Offset = "0x1B41A80", VA = "0x7BBC341A80", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FD")]
		[Address(RVA = "0x1B41E00", Offset = "0x1B41E00", VA = "0x7BBC341E00")]
		public TDMLikeShopConfigData()
		{
		}

		// Token: 0x04005715 RID: 22293
		[Token(Token = "0x4005715")]
		[FieldOffset(Offset = "0x10")]
		public uint indexID;

		// Token: 0x04005716 RID: 22294
		[Token(Token = "0x4005716")]
		[FieldOffset(Offset = "0x18")]
		public List<TDMLikeShopItem> items;

		// Token: 0x04005717 RID: 22295
		[Token(Token = "0x4005717")]
		[FieldOffset(Offset = "0x20")]
		public uint mainItemId;

		// Token: 0x04005718 RID: 22296
		[Token(Token = "0x4005718")]
		[FieldOffset(Offset = "0x24")]
		public uint price;

		// Token: 0x04005719 RID: 22297
		[Token(Token = "0x4005719")]
		[FieldOffset(Offset = "0x28")]
		public uint filter;

		// Token: 0x0400571A RID: 22298
		[Token(Token = "0x400571A")]
		[FieldOffset(Offset = "0x2C")]
		public bool displayFirstOne;
	}
}
