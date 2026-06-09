using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010DD RID: 4317
	[Token(Token = "0x20010DD")]
	public class DefaultLanguageConfig : CSVBaseData
	{
		// Token: 0x06004360 RID: 17248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004360")]
		[Address(RVA = "0x1600DBC", Offset = "0x1600DBC", VA = "0x7BBBE00DBC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004361")]
		[Address(RVA = "0x1600DC4", Offset = "0x1600DC4", VA = "0x7BBBE00DC4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004362")]
		[Address(RVA = "0x1600E84", Offset = "0x1600E84", VA = "0x7BBBE00E84")]
		public DefaultLanguageConfig()
		{
		}

		// Token: 0x04005318 RID: 21272
		[Token(Token = "0x4005318")]
		[FieldOffset(Offset = "0x10")]
		public string Region;

		// Token: 0x04005319 RID: 21273
		[Token(Token = "0x4005319")]
		[FieldOffset(Offset = "0x18")]
		public int Lagr;
	}
}
