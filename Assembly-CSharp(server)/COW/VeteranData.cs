using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011A2 RID: 4514
	[Token(Token = "0x20011A2")]
	public class VeteranData : CSVBaseData
	{
		// Token: 0x06004640 RID: 17984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004640")]
		[Address(RVA = "0x179A9E0", Offset = "0x179A9E0", VA = "0x7BBBF9A9E0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004641")]
		[Address(RVA = "0x179A9E8", Offset = "0x179A9E8", VA = "0x7BBBF9A9E8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004642")]
		[Address(RVA = "0x179AAFC", Offset = "0x179AAFC", VA = "0x7BBBF9AAFC")]
		public VeteranData()
		{
		}

		// Token: 0x04005777 RID: 22391
		[Token(Token = "0x4005777")]
		[FieldOffset(Offset = "0x10")]
		public string Region;

		// Token: 0x04005778 RID: 22392
		[Token(Token = "0x4005778")]
		[FieldOffset(Offset = "0x18")]
		public int LeaveDays;

		// Token: 0x04005779 RID: 22393
		[Token(Token = "0x4005779")]
		[FieldOffset(Offset = "0x1C")]
		public int VeteranDuration;

		// Token: 0x0400577A RID: 22394
		[Token(Token = "0x400577A")]
		[FieldOffset(Offset = "0x20")]
		public int VeteranLevel;
	}
}
