using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010B8 RID: 4280
	[Token(Token = "0x20010B8")]
	public class BillboardLocalizationData : CSVBaseData
	{
		// Token: 0x060042C3 RID: 17091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C3")]
		[Address(RVA = "0x14E3CE4", Offset = "0x14E3CE4", VA = "0x7BBBCE3CE4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C4")]
		[Address(RVA = "0x14E3CEC", Offset = "0x14E3CEC", VA = "0x7BBBCE3CEC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C5")]
		[Address(RVA = "0x14E3DC8", Offset = "0x14E3DC8", VA = "0x7BBBCE3DC8")]
		public BillboardLocalizationData()
		{
		}

		// Token: 0x040051DE RID: 20958
		[Token(Token = "0x40051DE")]
		[FieldOffset(Offset = "0x10")]
		public string Region;

		// Token: 0x040051DF RID: 20959
		[Token(Token = "0x40051DF")]
		[FieldOffset(Offset = "0x18")]
		public string BillboardServerAdd;
	}
}
