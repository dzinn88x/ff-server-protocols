using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200114E RID: 4430
	[Token(Token = "0x200114E")]
	public class NewPlayerSevenDaysData : CSVBaseData
	{
		// Token: 0x0600451E RID: 17694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451E")]
		[Address(RVA = "0x1A640DC", Offset = "0x1A640DC", VA = "0x7BBC2640DC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600451F")]
		[Address(RVA = "0x1A640E8", Offset = "0x1A640E8", VA = "0x7BBC2640E8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004520")]
		[Address(RVA = "0x1A6437C", Offset = "0x1A6437C", VA = "0x7BBC26437C")]
		public NewPlayerSevenDaysData()
		{
		}

		// Token: 0x040055AD RID: 21933
		[Token(Token = "0x40055AD")]
		[FieldOffset(Offset = "0x10")]
		public int achievementID;

		// Token: 0x040055AE RID: 21934
		[Token(Token = "0x40055AE")]
		[FieldOffset(Offset = "0x18")]
		public string achievementIntro;

		// Token: 0x040055AF RID: 21935
		[Token(Token = "0x40055AF")]
		[FieldOffset(Offset = "0x20")]
		public string ahievemtnDetailKey;

		// Token: 0x040055B0 RID: 21936
		[Token(Token = "0x40055B0")]
		[FieldOffset(Offset = "0x28")]
		public bool haveGoto;

		// Token: 0x040055B1 RID: 21937
		[Token(Token = "0x40055B1")]
		[FieldOffset(Offset = "0x2C")]
		public int gotoGuideID;

		// Token: 0x040055B2 RID: 21938
		[Token(Token = "0x40055B2")]
		[FieldOffset(Offset = "0x30")]
		public int CdtValue;

		// Token: 0x040055B3 RID: 21939
		[Token(Token = "0x40055B3")]
		[FieldOffset(Offset = "0x34")]
		public uint AwardType1;

		// Token: 0x040055B4 RID: 21940
		[Token(Token = "0x40055B4")]
		[FieldOffset(Offset = "0x38")]
		public uint AwardId1;

		// Token: 0x040055B5 RID: 21941
		[Token(Token = "0x40055B5")]
		[FieldOffset(Offset = "0x3C")]
		public uint AwardNum1;

		// Token: 0x040055B6 RID: 21942
		[Token(Token = "0x40055B6")]
		[FieldOffset(Offset = "0x40")]
		public uint AwardType2;

		// Token: 0x040055B7 RID: 21943
		[Token(Token = "0x40055B7")]
		[FieldOffset(Offset = "0x44")]
		public uint AwardId2;

		// Token: 0x040055B8 RID: 21944
		[Token(Token = "0x40055B8")]
		[FieldOffset(Offset = "0x48")]
		public uint AwardNum2;

		// Token: 0x040055B9 RID: 21945
		[Token(Token = "0x40055B9")]
		[FieldOffset(Offset = "0x50")]
		public string AwardName1;

		// Token: 0x040055BA RID: 21946
		[Token(Token = "0x40055BA")]
		[FieldOffset(Offset = "0x58")]
		public string AwardName2;
	}
}
