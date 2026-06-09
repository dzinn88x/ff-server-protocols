using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010C0 RID: 4288
	[Token(Token = "0x20010C0")]
	public class ClanScalesData : CSVBaseData
	{
		// Token: 0x060042E1 RID: 17121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E1")]
		[Address(RVA = "0x14F99D4", Offset = "0x14F99D4", VA = "0x7BBBCF99D4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042E2 RID: 17122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042E2")]
		[Address(RVA = "0x14F99E0", Offset = "0x14F99E0", VA = "0x7BBBCF99E0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042E3")]
		[Address(RVA = "0x14F9AE0", Offset = "0x14F9AE0", VA = "0x7BBBCF9AE0")]
		public ClanScalesData()
		{
		}

		// Token: 0x04005204 RID: 20996
		[Token(Token = "0x4005204")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x04005205 RID: 20997
		[Token(Token = "0x4005205")]
		[FieldOffset(Offset = "0x14")]
		public uint MaxMember;

		// Token: 0x04005206 RID: 20998
		[Token(Token = "0x4005206")]
		[FieldOffset(Offset = "0x18")]
		public uint GoldCost;

		// Token: 0x04005207 RID: 20999
		[Token(Token = "0x4005207")]
		[FieldOffset(Offset = "0x1C")]
		public uint DiamondCost;
	}
}
