using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200115E RID: 4446
	[Token(Token = "0x200115E")]
	internal class PetFoodData : CSVBaseData
	{
		// Token: 0x06004549 RID: 17737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004549")]
		[Address(RVA = "0x2051094", Offset = "0x2051094", VA = "0x7BBC851094", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600454A")]
		[Address(RVA = "0x20510A0", Offset = "0x20510A0", VA = "0x7BBC8510A0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600454B")]
		[Address(RVA = "0x20511AC", Offset = "0x20511AC", VA = "0x7BBC8511AC")]
		public PetFoodData()
		{
		}

		// Token: 0x0400561E RID: 22046
		[Token(Token = "0x400561E")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x0400561F RID: 22047
		[Token(Token = "0x400561F")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x04005620 RID: 22048
		[Token(Token = "0x4005620")]
		[FieldOffset(Offset = "0x20")]
		public int Exp;

		// Token: 0x04005621 RID: 22049
		[Token(Token = "0x4005621")]
		[FieldOffset(Offset = "0x28")]
		public uint[] SuitPetIDList;
	}
}
