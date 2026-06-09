using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200117F RID: 4479
	[Token(Token = "0x200117F")]
	internal class RelationAnniversaryData : CSVBaseData
	{
		// Token: 0x060045B4 RID: 17844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B4")]
		[Address(RVA = "0x1753324", Offset = "0x1753324", VA = "0x7BBBF53324", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B5")]
		[Address(RVA = "0x1753330", Offset = "0x1753330", VA = "0x7BBBF53330", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B6")]
		[Address(RVA = "0x17533E8", Offset = "0x17533E8", VA = "0x7BBBF533E8")]
		public RelationAnniversaryData()
		{
		}

		// Token: 0x040056B1 RID: 22193
		[Token(Token = "0x40056B1")]
		[FieldOffset(Offset = "0x10")]
		public uint RelationType;

		// Token: 0x040056B2 RID: 22194
		[Token(Token = "0x40056B2")]
		[FieldOffset(Offset = "0x14")]
		public uint RelationAnniversary;
	}
}
