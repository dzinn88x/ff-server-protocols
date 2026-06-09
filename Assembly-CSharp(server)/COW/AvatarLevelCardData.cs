using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200109E RID: 4254
	[Token(Token = "0x200109E")]
	public class AvatarLevelCardData : CSVBaseData
	{
		// Token: 0x060041A9 RID: 16809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A9")]
		[Address(RVA = "0x156209C", Offset = "0x156209C", VA = "0x7BBBD6209C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041AA")]
		[Address(RVA = "0x15620A8", Offset = "0x15620A8", VA = "0x7BBBD620A8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041AB")]
		[Address(RVA = "0x1562184", Offset = "0x1562184", VA = "0x7BBBD62184")]
		public AvatarLevelCardData()
		{
		}

		// Token: 0x040050FF RID: 20735
		[Token(Token = "0x40050FF")]
		[FieldOffset(Offset = "0x10")]
		public int cardId;

		// Token: 0x04005100 RID: 20736
		[Token(Token = "0x4005100")]
		[FieldOffset(Offset = "0x14")]
		public int maxLevel;

		// Token: 0x04005101 RID: 20737
		[Token(Token = "0x4005101")]
		[FieldOffset(Offset = "0x18")]
		public uint goPos;
	}
}
