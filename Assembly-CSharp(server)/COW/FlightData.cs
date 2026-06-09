using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010C9 RID: 4297
	[Token(Token = "0x20010C9")]
	public class FlightData : CSVBaseData, IGetId
	{
		// Token: 0x060042FD RID: 17149 RVA: 0x00014A18 File Offset: 0x00012C18
		[Token(Token = "0x60042FD")]
		[Address(RVA = "0x1B99CFC", Offset = "0x1B99CFC", VA = "0x7BBC399CFC", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FE")]
		[Address(RVA = "0x1B99D04", Offset = "0x1B99D04", VA = "0x7BBC399D04", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042FF")]
		[Address(RVA = "0x1B99D10", Offset = "0x1B99D10", VA = "0x7BBC399D10", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004300")]
		[Address(RVA = "0x1B9A0A4", Offset = "0x1B9A0A4", VA = "0x7BBC39A0A4")]
		public FlightData()
		{
		}

		// Token: 0x04005245 RID: 21061
		[Token(Token = "0x4005245")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x04005246 RID: 21062
		[Token(Token = "0x4005246")]
		[FieldOffset(Offset = "0x14")]
		public uint sortId;

		// Token: 0x04005247 RID: 21063
		[Token(Token = "0x4005247")]
		[FieldOffset(Offset = "0x18")]
		public ResourceID previewRes;

		// Token: 0x04005248 RID: 21064
		[Token(Token = "0x4005248")]
		[FieldOffset(Offset = "0x1C")]
		public ResourceID inGameRes;

		// Token: 0x04005249 RID: 21065
		[Token(Token = "0x4005249")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID inGameRes3P;

		// Token: 0x0400524A RID: 21066
		[Token(Token = "0x400524A")]
		[FieldOffset(Offset = "0x24")]
		public ESourceType sourceTypeKey;
	}
}
