using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001120 RID: 4384
	[Token(Token = "0x2001120")]
	public class LevelExpData : CSVBaseData
	{
		// Token: 0x06004490 RID: 17552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004490")]
		[Address(RVA = "0x1401AA8", Offset = "0x1401AA8", VA = "0x7BBBC01AA8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004491 RID: 17553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004491")]
		[Address(RVA = "0x1401AB4", Offset = "0x1401AB4", VA = "0x7BBBC01AB4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004492 RID: 17554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004492")]
		[Address(RVA = "0x1401B6C", Offset = "0x1401B6C", VA = "0x7BBBC01B6C")]
		public LevelExpData()
		{
		}

		// Token: 0x040054A8 RID: 21672
		[Token(Token = "0x40054A8")]
		[FieldOffset(Offset = "0x10")]
		public uint Level;

		// Token: 0x040054A9 RID: 21673
		[Token(Token = "0x40054A9")]
		[FieldOffset(Offset = "0x14")]
		public uint MinExp;
	}
}
