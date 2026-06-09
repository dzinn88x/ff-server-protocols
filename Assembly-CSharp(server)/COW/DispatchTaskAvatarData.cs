using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010DF RID: 4319
	[Token(Token = "0x20010DF")]
	public class DispatchTaskAvatarData : CSVBaseData
	{
		// Token: 0x06004366 RID: 17254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004366")]
		[Address(RVA = "0x1608BAC", Offset = "0x1608BAC", VA = "0x7BBBE08BAC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004367")]
		[Address(RVA = "0x1608CDC", Offset = "0x1608CDC", VA = "0x7BBBE08CDC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004368")]
		[Address(RVA = "0x1608CE8", Offset = "0x1608CE8", VA = "0x7BBBE08CE8")]
		public DispatchTaskAvatarData()
		{
		}

		// Token: 0x0400531C RID: 21276
		[Token(Token = "0x400531C")]
		[FieldOffset(Offset = "0x10")]
		public uint Id;

		// Token: 0x0400531D RID: 21277
		[Token(Token = "0x400531D")]
		[FieldOffset(Offset = "0x14")]
		public ResourceID Icon;

		// Token: 0x0400531E RID: 21278
		[Token(Token = "0x400531E")]
		[FieldOffset(Offset = "0x18")]
		public ResourceID SharingPortrait;
	}
}
