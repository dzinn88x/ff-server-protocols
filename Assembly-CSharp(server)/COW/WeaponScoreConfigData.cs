using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010D2 RID: 4306
	[Token(Token = "0x20010D2")]
	public class WeaponScoreConfigData : CSVBaseData
	{
		// Token: 0x0600431C RID: 17180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431C")]
		[Address(RVA = "0x179D138", Offset = "0x179D138", VA = "0x7BBBF9D138", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600431D")]
		[Address(RVA = "0x179D140", Offset = "0x179D140", VA = "0x7BBBF9D140", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600431E")]
		[Address(RVA = "0x179D274", Offset = "0x179D274", VA = "0x7BBBF9D274")]
		public WeaponScoreConfigData()
		{
		}

		// Token: 0x040052A4 RID: 21156
		[Token(Token = "0x40052A4")]
		[FieldOffset(Offset = "0x10")]
		public string region;

		// Token: 0x040052A5 RID: 21157
		[Token(Token = "0x40052A5")]
		[FieldOffset(Offset = "0x18")]
		public uint IsScore;
	}
}
