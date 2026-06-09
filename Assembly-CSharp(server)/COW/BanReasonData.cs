using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010AC RID: 4268
	[Token(Token = "0x20010AC")]
	public class BanReasonData : CSVBaseData
	{
		// Token: 0x06004299 RID: 17049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004299")]
		[Address(RVA = "0x21CCA28", Offset = "0x21CCA28", VA = "0x7BBC9CCA28", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429A")]
		[Address(RVA = "0x21CCA34", Offset = "0x21CCA34", VA = "0x7BBC9CCA34", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429B")]
		[Address(RVA = "0x21CCB14", Offset = "0x21CCB14", VA = "0x7BBC9CCB14")]
		public BanReasonData()
		{
		}

		// Token: 0x040051A1 RID: 20897
		[Token(Token = "0x40051A1")]
		[FieldOffset(Offset = "0x10")]
		public int ReasonId;

		// Token: 0x040051A2 RID: 20898
		[Token(Token = "0x40051A2")]
		[FieldOffset(Offset = "0x18")]
		public string ReasonKey;

		// Token: 0x040051A3 RID: 20899
		[Token(Token = "0x40051A3")]
		[FieldOffset(Offset = "0x20")]
		public bool TimeLimited;
	}
}
