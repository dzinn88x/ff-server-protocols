using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001138 RID: 4408
	[Token(Token = "0x2001138")]
	public class FormatCultureInfoData : CSVBaseData
	{
		// Token: 0x060044DC RID: 17628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044DC")]
		[Address(RVA = "0x1B9A478", Offset = "0x1B9A478", VA = "0x7BBC39A478", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DD")]
		[Address(RVA = "0x1B9A488", Offset = "0x1B9A488", VA = "0x7BBC39A488", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DE")]
		[Address(RVA = "0x1B9A5F4", Offset = "0x1B9A5F4", VA = "0x7BBC39A5F4")]
		public FormatCultureInfoData()
		{
		}

		// Token: 0x040054FE RID: 21758
		[Token(Token = "0x40054FE")]
		[FieldOffset(Offset = "0x10")]
		public string Language;

		// Token: 0x040054FF RID: 21759
		[Token(Token = "0x40054FF")]
		[FieldOffset(Offset = "0x18")]
		public string RegionGroup;

		// Token: 0x04005500 RID: 21760
		[Token(Token = "0x4005500")]
		[FieldOffset(Offset = "0x20")]
		public string[] Regions;

		// Token: 0x04005501 RID: 21761
		[Token(Token = "0x4005501")]
		[FieldOffset(Offset = "0x28")]
		public string CultureCode;
	}
}
