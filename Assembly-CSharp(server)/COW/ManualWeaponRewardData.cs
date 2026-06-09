using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001145 RID: 4421
	[Token(Token = "0x2001145")]
	public class ManualWeaponRewardData : CSVBaseData
	{
		// Token: 0x06004500 RID: 17664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004500")]
		[Address(RVA = "0x1A56A0C", Offset = "0x1A56A0C", VA = "0x7BBC256A0C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004501")]
		[Address(RVA = "0x1A56A18", Offset = "0x1A56A18", VA = "0x7BBC256A18", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004502")]
		[Address(RVA = "0x1A56CE8", Offset = "0x1A56CE8", VA = "0x7BBC256CE8")]
		public ManualWeaponRewardData()
		{
		}

		// Token: 0x0400554C RID: 21836
		[Token(Token = "0x400554C")]
		[FieldOffset(Offset = "0x10")]
		public uint QuantityPeriod;

		// Token: 0x0400554D RID: 21837
		[Token(Token = "0x400554D")]
		[FieldOffset(Offset = "0x14")]
		public uint AwardType1;

		// Token: 0x0400554E RID: 21838
		[Token(Token = "0x400554E")]
		[FieldOffset(Offset = "0x18")]
		public uint AwardId1;

		// Token: 0x0400554F RID: 21839
		[Token(Token = "0x400554F")]
		[FieldOffset(Offset = "0x1C")]
		public uint AwardNum1;

		// Token: 0x04005550 RID: 21840
		[Token(Token = "0x4005550")]
		[FieldOffset(Offset = "0x20")]
		public uint AwardTime1;

		// Token: 0x04005551 RID: 21841
		[Token(Token = "0x4005551")]
		[FieldOffset(Offset = "0x24")]
		public uint AwardType2;

		// Token: 0x04005552 RID: 21842
		[Token(Token = "0x4005552")]
		[FieldOffset(Offset = "0x28")]
		public uint AwardId2;

		// Token: 0x04005553 RID: 21843
		[Token(Token = "0x4005553")]
		[FieldOffset(Offset = "0x2C")]
		public uint AwardNum2;

		// Token: 0x04005554 RID: 21844
		[Token(Token = "0x4005554")]
		[FieldOffset(Offset = "0x30")]
		public uint AwardTime2;

		// Token: 0x04005555 RID: 21845
		[Token(Token = "0x4005555")]
		[FieldOffset(Offset = "0x34")]
		public uint AwardType3;

		// Token: 0x04005556 RID: 21846
		[Token(Token = "0x4005556")]
		[FieldOffset(Offset = "0x38")]
		public uint AwardId3;

		// Token: 0x04005557 RID: 21847
		[Token(Token = "0x4005557")]
		[FieldOffset(Offset = "0x3C")]
		public uint AwardNum3;

		// Token: 0x04005558 RID: 21848
		[Token(Token = "0x4005558")]
		[FieldOffset(Offset = "0x40")]
		public uint AwardTime3;

		// Token: 0x04005559 RID: 21849
		[Token(Token = "0x4005559")]
		[FieldOffset(Offset = "0x48")]
		public string AwardName1;

		// Token: 0x0400555A RID: 21850
		[Token(Token = "0x400555A")]
		[FieldOffset(Offset = "0x50")]
		public string AwardName2;

		// Token: 0x0400555B RID: 21851
		[Token(Token = "0x400555B")]
		[FieldOffset(Offset = "0x58")]
		public string AwardName3;
	}
}
