using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010F3 RID: 4339
	[Token(Token = "0x20010F3")]
	public class EPUpdateData : CSVBaseData
	{
		// Token: 0x060043BB RID: 17339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043BB")]
		[Address(RVA = "0x1613F64", Offset = "0x1613F64", VA = "0x7BBBE13F64", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BC")]
		[Address(RVA = "0x1614088", Offset = "0x1614088", VA = "0x7BBBE14088", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x00014C70 File Offset: 0x00012E70
		[Token(Token = "0x60043BD")]
		[Address(RVA = "0x1614094", Offset = "0x1614094", VA = "0x7BBBE14094")]
		public bool IsEntranceOpen(EEpEntrance type)
		{
			return default(bool);
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043BE")]
		[Address(RVA = "0x16140E4", Offset = "0x16140E4", VA = "0x7BBBE140E4")]
		public EPUpdateData()
		{
		}

		// Token: 0x040053B7 RID: 21431
		[Token(Token = "0x40053B7")]
		[FieldOffset(Offset = "0x10")]
		public uint EpId;

		// Token: 0x040053B8 RID: 21432
		[Token(Token = "0x40053B8")]
		[FieldOffset(Offset = "0x14")]
		public uint EpEntrance;

		// Token: 0x040053B9 RID: 21433
		[Token(Token = "0x40053B9")]
		[FieldOffset(Offset = "0x18")]
		public uint EpQuest;

		// Token: 0x040053BA RID: 21434
		[Token(Token = "0x40053BA")]
		[FieldOffset(Offset = "0x1C")]
		public uint EpBadge;

		// Token: 0x040053BB RID: 21435
		[Token(Token = "0x40053BB")]
		[FieldOffset(Offset = "0x20")]
		public uint EPDocument;
	}
}
