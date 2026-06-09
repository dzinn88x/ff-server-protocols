using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010E9 RID: 4329
	[Token(Token = "0x20010E9")]
	internal class EPEventSettingData : CSVBaseData
	{
		// Token: 0x0600438C RID: 17292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600438C")]
		[Address(RVA = "0x160EF0C", Offset = "0x160EF0C", VA = "0x7BBBE0EF0C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438D")]
		[Address(RVA = "0x160EF18", Offset = "0x160EF18", VA = "0x7BBBE0EF18", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438E")]
		[Address(RVA = "0x160F31C", Offset = "0x160F31C", VA = "0x7BBBE0F31C")]
		public EPEventSettingData()
		{
		}

		// Token: 0x04005362 RID: 21346
		[Token(Token = "0x4005362")]
		[FieldOffset(Offset = "0x10")]
		public uint EPEventID;

		// Token: 0x04005363 RID: 21347
		[Token(Token = "0x4005363")]
		[FieldOffset(Offset = "0x18")]
		public DateTime StartTime;

		// Token: 0x04005364 RID: 21348
		[Token(Token = "0x4005364")]
		[FieldOffset(Offset = "0x20")]
		public DateTime EndTime;

		// Token: 0x04005365 RID: 21349
		[Token(Token = "0x4005365")]
		[FieldOffset(Offset = "0x28")]
		public string EPEventName;

		// Token: 0x04005366 RID: 21350
		[Token(Token = "0x4005366")]
		[FieldOffset(Offset = "0x30")]
		public uint BadgeItemID;

		// Token: 0x04005367 RID: 21351
		[Token(Token = "0x4005367")]
		[FieldOffset(Offset = "0x34")]
		public uint BadgeDebrisItemID;

		// Token: 0x04005368 RID: 21352
		[Token(Token = "0x4005368")]
		[FieldOffset(Offset = "0x38")]
		public uint FPChallengeID;

		// Token: 0x04005369 RID: 21353
		[Token(Token = "0x4005369")]
		[FieldOffset(Offset = "0x3C")]
		public uint ExtraMaxCoins;

		// Token: 0x0400536A RID: 21354
		[Token(Token = "0x400536A")]
		[FieldOffset(Offset = "0x40")]
		public ResourceID LobbyIcon;

		// Token: 0x0400536B RID: 21355
		[Token(Token = "0x400536B")]
		[FieldOffset(Offset = "0x48")]
		public string ThemeColor;

		// Token: 0x0400536C RID: 21356
		[Token(Token = "0x400536C")]
		[FieldOffset(Offset = "0x50")]
		public uint FreeTreasureBoxID;

		// Token: 0x0400536D RID: 21357
		[Token(Token = "0x400536D")]
		[FieldOffset(Offset = "0x58")]
		public string CdnUrl;

		// Token: 0x0400536E RID: 21358
		[Token(Token = "0x400536E")]
		[FieldOffset(Offset = "0x60")]
		public ResourceID HDEPLobbyVFX;
	}
}
