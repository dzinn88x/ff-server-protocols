using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200114D RID: 4429
	[Token(Token = "0x200114D")]
	public class NewPlayerSevenDaysAwardData : CSVBaseData
	{
		// Token: 0x0600451B RID: 17691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451B")]
		[Address(RVA = "0x1A63C78", Offset = "0x1A63C78", VA = "0x7BBC263C78", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600451C")]
		[Address(RVA = "0x1A63C84", Offset = "0x1A63C84", VA = "0x7BBC263C84", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600451D")]
		[Address(RVA = "0x1A64074", Offset = "0x1A64074", VA = "0x7BBC264074")]
		public NewPlayerSevenDaysAwardData()
		{
		}

		// Token: 0x04005596 RID: 21910
		[Token(Token = "0x4005596")]
		[FieldOffset(Offset = "0x10")]
		public int achievementId;

		// Token: 0x04005597 RID: 21911
		[Token(Token = "0x4005597")]
		[FieldOffset(Offset = "0x14")]
		public int dayID;

		// Token: 0x04005598 RID: 21912
		[Token(Token = "0x4005598")]
		[FieldOffset(Offset = "0x18")]
		public string dayTitleKey;

		// Token: 0x04005599 RID: 21913
		[Token(Token = "0x4005599")]
		[FieldOffset(Offset = "0x20")]
		public int achievementCount;

		// Token: 0x0400559A RID: 21914
		[Token(Token = "0x400559A")]
		[FieldOffset(Offset = "0x28")]
		public uint[] achievementIDArray;

		// Token: 0x0400559B RID: 21915
		[Token(Token = "0x400559B")]
		[FieldOffset(Offset = "0x30")]
		public string CDNurl;

		// Token: 0x0400559C RID: 21916
		[Token(Token = "0x400559C")]
		[FieldOffset(Offset = "0x38")]
		public string CDNurl2;

		// Token: 0x0400559D RID: 21917
		[Token(Token = "0x400559D")]
		[FieldOffset(Offset = "0x40")]
		public uint AwardType1;

		// Token: 0x0400559E RID: 21918
		[Token(Token = "0x400559E")]
		[FieldOffset(Offset = "0x44")]
		public uint AwardId1;

		// Token: 0x0400559F RID: 21919
		[Token(Token = "0x400559F")]
		[FieldOffset(Offset = "0x48")]
		public uint AwardNum1;

		// Token: 0x040055A0 RID: 21920
		[Token(Token = "0x40055A0")]
		[FieldOffset(Offset = "0x4C")]
		public uint AwardType2;

		// Token: 0x040055A1 RID: 21921
		[Token(Token = "0x40055A1")]
		[FieldOffset(Offset = "0x50")]
		public uint AwardId2;

		// Token: 0x040055A2 RID: 21922
		[Token(Token = "0x40055A2")]
		[FieldOffset(Offset = "0x54")]
		public uint AwardNum2;

		// Token: 0x040055A3 RID: 21923
		[Token(Token = "0x40055A3")]
		[FieldOffset(Offset = "0x58")]
		public uint AwardType3;

		// Token: 0x040055A4 RID: 21924
		[Token(Token = "0x40055A4")]
		[FieldOffset(Offset = "0x5C")]
		public uint AwardId3;

		// Token: 0x040055A5 RID: 21925
		[Token(Token = "0x40055A5")]
		[FieldOffset(Offset = "0x60")]
		public uint AwardNum3;

		// Token: 0x040055A6 RID: 21926
		[Token(Token = "0x40055A6")]
		[FieldOffset(Offset = "0x64")]
		public uint AwardType4;

		// Token: 0x040055A7 RID: 21927
		[Token(Token = "0x40055A7")]
		[FieldOffset(Offset = "0x68")]
		public uint AwardId4;

		// Token: 0x040055A8 RID: 21928
		[Token(Token = "0x40055A8")]
		[FieldOffset(Offset = "0x6C")]
		public uint AwardNum4;

		// Token: 0x040055A9 RID: 21929
		[Token(Token = "0x40055A9")]
		[FieldOffset(Offset = "0x70")]
		public string AwardName1;

		// Token: 0x040055AA RID: 21930
		[Token(Token = "0x40055AA")]
		[FieldOffset(Offset = "0x78")]
		public string AwardName2;

		// Token: 0x040055AB RID: 21931
		[Token(Token = "0x40055AB")]
		[FieldOffset(Offset = "0x80")]
		public string AwardName3;

		// Token: 0x040055AC RID: 21932
		[Token(Token = "0x40055AC")]
		[FieldOffset(Offset = "0x88")]
		public string AwardName4;
	}
}
