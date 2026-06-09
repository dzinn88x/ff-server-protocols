using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001101 RID: 4353
	[Token(Token = "0x2001101")]
	public class GachaRandomRareData : CSVBaseData
	{
		// Token: 0x06004401 RID: 17409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004401")]
		[Address(RVA = "0x186B438", Offset = "0x186B438", VA = "0x7BBC06B438", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004402")]
		[Address(RVA = "0x186B444", Offset = "0x186B444", VA = "0x7BBC06B444", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004403")]
		[Address(RVA = "0x186B520", Offset = "0x186B520", VA = "0x7BBC06B520")]
		public GachaRandomRareData()
		{
		}

		// Token: 0x04005404 RID: 21508
		[Token(Token = "0x4005404")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x04005405 RID: 21509
		[Token(Token = "0x4005405")]
		[FieldOffset(Offset = "0x14")]
		public int Probability;

		// Token: 0x04005406 RID: 21510
		[Token(Token = "0x4005406")]
		[FieldOffset(Offset = "0x18")]
		public int RandomRare;
	}
}
