using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001129 RID: 4393
	[Token(Token = "0x2001129")]
	public class LinkEquipSetTimeData : CSVBaseData
	{
		// Token: 0x060044AB RID: 17579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044AB")]
		[Address(RVA = "0x14049C0", Offset = "0x14049C0", VA = "0x7BBBC049C0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044AC")]
		[Address(RVA = "0x14049CC", Offset = "0x14049CC", VA = "0x7BBBC049CC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044AD")]
		[Address(RVA = "0x1404C24", Offset = "0x1404C24", VA = "0x7BBBC04C24")]
		public LinkEquipSetTimeData()
		{
		}

		// Token: 0x040054D8 RID: 21720
		[Token(Token = "0x40054D8")]
		[FieldOffset(Offset = "0x10")]
		public uint Id;

		// Token: 0x040054D9 RID: 21721
		[Token(Token = "0x40054D9")]
		[FieldOffset(Offset = "0x18")]
		public DateTime StartTime;

		// Token: 0x040054DA RID: 21722
		[Token(Token = "0x40054DA")]
		[FieldOffset(Offset = "0x20")]
		public DateTime EndTime;

		// Token: 0x040054DB RID: 21723
		[Token(Token = "0x40054DB")]
		[FieldOffset(Offset = "0x28")]
		public uint[] Builds;
	}
}
