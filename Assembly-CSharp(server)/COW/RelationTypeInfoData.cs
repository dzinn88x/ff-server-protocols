using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001180 RID: 4480
	[Token(Token = "0x2001180")]
	public class RelationTypeInfoData : CSVBaseData
	{
		// Token: 0x060045B7 RID: 17847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B7")]
		[Address(RVA = "0x1753450", Offset = "0x1753450", VA = "0x7BBBF53450", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B8")]
		[Address(RVA = "0x175345C", Offset = "0x175345C", VA = "0x7BBBF5345C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B9")]
		[Address(RVA = "0x1753690", Offset = "0x1753690", VA = "0x7BBBF53690")]
		public RelationTypeInfoData()
		{
		}

		// Token: 0x040056B3 RID: 22195
		[Token(Token = "0x40056B3")]
		[FieldOffset(Offset = "0x10")]
		public uint RelationType;

		// Token: 0x040056B4 RID: 22196
		[Token(Token = "0x40056B4")]
		[FieldOffset(Offset = "0x18")]
		public string RelationName;

		// Token: 0x040056B5 RID: 22197
		[Token(Token = "0x40056B5")]
		[FieldOffset(Offset = "0x20")]
		public uint RelationFriendMax;

		// Token: 0x040056B6 RID: 22198
		[Token(Token = "0x40056B6")]
		[FieldOffset(Offset = "0x24")]
		public uint RelationItem;

		// Token: 0x040056B7 RID: 22199
		[Token(Token = "0x40056B7")]
		[FieldOffset(Offset = "0x28")]
		public uint RejectCountDown;

		// Token: 0x040056B8 RID: 22200
		[Token(Token = "0x40056B8")]
		[FieldOffset(Offset = "0x2C")]
		public uint RelationBreakUpCD;

		// Token: 0x040056B9 RID: 22201
		[Token(Token = "0x40056B9")]
		[FieldOffset(Offset = "0x30")]
		public uint RelationBreakUpCountDown;

		// Token: 0x040056BA RID: 22202
		[Token(Token = "0x40056BA")]
		[FieldOffset(Offset = "0x34")]
		public ResourceID RelationBrokenBadgeIcon;

		// Token: 0x040056BB RID: 22203
		[Token(Token = "0x40056BB")]
		[FieldOffset(Offset = "0x38")]
		public string RelationBgUrl;

		// Token: 0x040056BC RID: 22204
		[Token(Token = "0x40056BC")]
		[FieldOffset(Offset = "0x40")]
		public string RelationLetterUrl;
	}
}
