using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010C4 RID: 4292
	[Token(Token = "0x20010C4")]
	public class BannerData : CSVBaseData, IGetId
	{
		// Token: 0x060042E7 RID: 17127 RVA: 0x00014988 File Offset: 0x00012B88
		[Token(Token = "0x60042E7")]
		[Address(RVA = "0x21CDA10", Offset = "0x21CDA10", VA = "0x7BBC9CDA10", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E8")]
		[Address(RVA = "0x21CDA18", Offset = "0x21CDA18", VA = "0x7BBC9CDA18", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042E9")]
		[Address(RVA = "0x21CDA24", Offset = "0x21CDA24", VA = "0x7BBC9CDA24", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042EA")]
		[Address(RVA = "0x21CDDF4", Offset = "0x21CDDF4", VA = "0x7BBC9CDDF4")]
		public BannerData()
		{
		}

		// Token: 0x0400521A RID: 21018
		[Token(Token = "0x400521A")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400521B RID: 21019
		[Token(Token = "0x400521B")]
		[FieldOffset(Offset = "0x18")]
		public uint iID;

		// Token: 0x0400521C RID: 21020
		[Token(Token = "0x400521C")]
		[FieldOffset(Offset = "0x1C")]
		public uint sortId;

		// Token: 0x0400521D RID: 21021
		[Token(Token = "0x400521D")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID baseRes;

		// Token: 0x0400521E RID: 21022
		[Token(Token = "0x400521E")]
		[FieldOffset(Offset = "0x24")]
		public ResourceID effectRes;

		// Token: 0x0400521F RID: 21023
		[Token(Token = "0x400521F")]
		[FieldOffset(Offset = "0x28")]
		public ResourceID briefRes;

		// Token: 0x04005220 RID: 21024
		[Token(Token = "0x4005220")]
		[FieldOffset(Offset = "0x2C")]
		public ESourceType sourceTypeKey;
	}
}
