using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200111A RID: 4378
	[Token(Token = "0x200111A")]
	public class LevelEntranceData : CSVBaseData
	{
		// Token: 0x06004484 RID: 17540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004484")]
		[Address(RVA = "0x1401310", Offset = "0x1401310", VA = "0x7BBBC01310", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004485")]
		[Address(RVA = "0x140131C", Offset = "0x140131C", VA = "0x7BBBC0131C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004486 RID: 17542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004486")]
		[Address(RVA = "0x14014C4", Offset = "0x14014C4", VA = "0x7BBBC014C4")]
		public LevelEntranceData()
		{
		}

		// Token: 0x04005487 RID: 21639
		[Token(Token = "0x4005487")]
		[FieldOffset(Offset = "0x10")]
		public uint EntranceId;

		// Token: 0x04005488 RID: 21640
		[Token(Token = "0x4005488")]
		[FieldOffset(Offset = "0x18")]
		public string EntranceNameKey;

		// Token: 0x04005489 RID: 21641
		[Token(Token = "0x4005489")]
		[FieldOffset(Offset = "0x20")]
		public uint LockStatus;

		// Token: 0x0400548A RID: 21642
		[Token(Token = "0x400548A")]
		[FieldOffset(Offset = "0x24")]
		public uint UnlockType;

		// Token: 0x0400548B RID: 21643
		[Token(Token = "0x400548B")]
		[FieldOffset(Offset = "0x28")]
		public uint UnlockNum;

		// Token: 0x0400548C RID: 21644
		[Token(Token = "0x400548C")]
		[FieldOffset(Offset = "0x2C")]
		public uint AnnounceLevel;

		// Token: 0x0400548D RID: 21645
		[Token(Token = "0x400548D")]
		[FieldOffset(Offset = "0x30")]
		public ResourceID IconResId;
	}
}
