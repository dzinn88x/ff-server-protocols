using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200114C RID: 4428
	[Token(Token = "0x200114C")]
	public class NewPlayerLevelUpTaskData : CSVBaseData
	{
		// Token: 0x06004518 RID: 17688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004518")]
		[Address(RVA = "0x1A63A6C", Offset = "0x1A63A6C", VA = "0x7BBC263A6C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004519")]
		[Address(RVA = "0x1A63A78", Offset = "0x1A63A78", VA = "0x7BBC263A78", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600451A")]
		[Address(RVA = "0x1A63C10", Offset = "0x1A63C10", VA = "0x7BBC263C10")]
		public NewPlayerLevelUpTaskData()
		{
		}

		// Token: 0x0400558E RID: 21902
		[Token(Token = "0x400558E")]
		[FieldOffset(Offset = "0x10")]
		public uint TaskId;

		// Token: 0x0400558F RID: 21903
		[Token(Token = "0x400558F")]
		[FieldOffset(Offset = "0x14")]
		public uint AwardType;

		// Token: 0x04005590 RID: 21904
		[Token(Token = "0x4005590")]
		[FieldOffset(Offset = "0x18")]
		public uint AwardId;

		// Token: 0x04005591 RID: 21905
		[Token(Token = "0x4005591")]
		[FieldOffset(Offset = "0x1C")]
		public uint AwardNum;

		// Token: 0x04005592 RID: 21906
		[Token(Token = "0x4005592")]
		[FieldOffset(Offset = "0x20")]
		public uint AwardTime;

		// Token: 0x04005593 RID: 21907
		[Token(Token = "0x4005593")]
		[FieldOffset(Offset = "0x24")]
		public uint CdtType;

		// Token: 0x04005594 RID: 21908
		[Token(Token = "0x4005594")]
		[FieldOffset(Offset = "0x28")]
		public uint CdtValue;

		// Token: 0x04005595 RID: 21909
		[Token(Token = "0x4005595")]
		[FieldOffset(Offset = "0x30")]
		public string CDNurl;
	}
}
