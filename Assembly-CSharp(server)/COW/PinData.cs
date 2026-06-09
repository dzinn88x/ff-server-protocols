using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010D5 RID: 4309
	[Token(Token = "0x20010D5")]
	public class PinData : CSVBaseData, IGetId
	{
		// Token: 0x06004323 RID: 17187 RVA: 0x00014A78 File Offset: 0x00012C78
		[Token(Token = "0x6004323")]
		[Address(RVA = "0x2053680", Offset = "0x2053680", VA = "0x7BBC853680", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004324")]
		[Address(RVA = "0x2053688", Offset = "0x2053688", VA = "0x7BBC853688", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004325")]
		[Address(RVA = "0x2053694", Offset = "0x2053694", VA = "0x7BBC853694", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004326")]
		[Address(RVA = "0x2053770", Offset = "0x2053770", VA = "0x7BBC853770")]
		public PinData()
		{
		}

		// Token: 0x040052C1 RID: 21185
		[Token(Token = "0x40052C1")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x040052C2 RID: 21186
		[Token(Token = "0x40052C2")]
		[FieldOffset(Offset = "0x14")]
		public uint sortId;

		// Token: 0x040052C3 RID: 21187
		[Token(Token = "0x40052C3")]
		[FieldOffset(Offset = "0x18")]
		public EPinSourceType sourceType;
	}
}
