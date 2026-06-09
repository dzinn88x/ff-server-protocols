using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001156 RID: 4438
	[Token(Token = "0x2001156")]
	public class PayWindowSubImages_Android_Data : CSVBaseData
	{
		// Token: 0x06004539 RID: 17721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004539")]
		[Address(RVA = "0x204B020", Offset = "0x204B020", VA = "0x7BBC84B020", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600453A")]
		[Address(RVA = "0x204B02C", Offset = "0x204B02C", VA = "0x7BBC84B02C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600453B")]
		[Address(RVA = "0x204B2FC", Offset = "0x204B2FC", VA = "0x7BBC84B2FC")]
		public PayWindowSubImages_Android_Data()
		{
		}

		// Token: 0x040055E2 RID: 21986
		[Token(Token = "0x40055E2")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x040055E3 RID: 21987
		[Token(Token = "0x40055E3")]
		[FieldOffset(Offset = "0x18")]
		public string IAPCdnUrlKey;

		// Token: 0x040055E4 RID: 21988
		[Token(Token = "0x40055E4")]
		[FieldOffset(Offset = "0x20")]
		public string AdCdnUrlKey;

		// Token: 0x040055E5 RID: 21989
		[Token(Token = "0x40055E5")]
		[FieldOffset(Offset = "0x28")]
		public string IAPResourceName;

		// Token: 0x040055E6 RID: 21990
		[Token(Token = "0x40055E6")]
		[FieldOffset(Offset = "0x30")]
		public string AdResourceName;

		// Token: 0x040055E7 RID: 21991
		[Token(Token = "0x40055E7")]
		[FieldOffset(Offset = "0x38")]
		public ResourceID IAPResourceId;

		// Token: 0x040055E8 RID: 21992
		[Token(Token = "0x40055E8")]
		[FieldOffset(Offset = "0x3C")]
		public ResourceID AdResourceId;
	}
}
