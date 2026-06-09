using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001160 RID: 4448
	[Token(Token = "0x2001160")]
	internal class PetLevelExpData : CSVBaseData
	{
		// Token: 0x0600454D RID: 17741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454D")]
		[Address(RVA = "0x20514F0", Offset = "0x20514F0", VA = "0x7BBC8514F0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600454E")]
		[Address(RVA = "0x20514FC", Offset = "0x20514FC", VA = "0x7BBC8514FC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600454F")]
		[Address(RVA = "0x2051644", Offset = "0x2051644", VA = "0x7BBC851644")]
		public PetLevelExpData()
		{
		}

		// Token: 0x04005623 RID: 22051
		[Token(Token = "0x4005623")]
		[FieldOffset(Offset = "0x10")]
		public int Lv;

		// Token: 0x04005624 RID: 22052
		[Token(Token = "0x4005624")]
		[FieldOffset(Offset = "0x14")]
		public int ExpNormal;

		// Token: 0x04005625 RID: 22053
		[Token(Token = "0x4005625")]
		[FieldOffset(Offset = "0x18")]
		public int ExpGood;

		// Token: 0x04005626 RID: 22054
		[Token(Token = "0x4005626")]
		[FieldOffset(Offset = "0x1C")]
		public int ExpRare;

		// Token: 0x04005627 RID: 22055
		[Token(Token = "0x4005627")]
		[FieldOffset(Offset = "0x20")]
		public int ExpEpic;

		// Token: 0x04005628 RID: 22056
		[Token(Token = "0x4005628")]
		[FieldOffset(Offset = "0x24")]
		public int ExpLegend;
	}
}
