using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010B3 RID: 4275
	[Token(Token = "0x20010B3")]
	public class BattleFlagConfigData : CSVBaseData, IGetId
	{
		// Token: 0x060042AF RID: 17071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AF")]
		[Address(RVA = "0x21D73E4", Offset = "0x21D73E4", VA = "0x7BBC9D73E4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x00014928 File Offset: 0x00012B28
		[Token(Token = "0x60042B0")]
		[Address(RVA = "0x21D73F0", Offset = "0x21D73F0", VA = "0x7BBC9D73F0", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B1")]
		[Address(RVA = "0x21D73F8", Offset = "0x21D73F8", VA = "0x7BBC9D73F8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B2")]
		[Address(RVA = "0x21D7754", Offset = "0x21D7754", VA = "0x7BBC9D7754")]
		public BattleFlagConfigData()
		{
		}

		// Token: 0x040051B1 RID: 20913
		[Token(Token = "0x40051B1")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x040051B2 RID: 20914
		[Token(Token = "0x40051B2")]
		[FieldOffset(Offset = "0x14")]
		public uint LinkID;

		// Token: 0x040051B3 RID: 20915
		[Token(Token = "0x40051B3")]
		[FieldOffset(Offset = "0x18")]
		public ResourceID resLobbyModel;

		// Token: 0x040051B4 RID: 20916
		[Token(Token = "0x40051B4")]
		[FieldOffset(Offset = "0x1C")]
		public ResourceID resModel;

		// Token: 0x040051B5 RID: 20917
		[Token(Token = "0x40051B5")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID EffectRes;
	}
}
