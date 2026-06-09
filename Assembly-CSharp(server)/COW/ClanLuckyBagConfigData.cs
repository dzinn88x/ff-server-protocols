using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010BE RID: 4286
	[Token(Token = "0x20010BE")]
	public class ClanLuckyBagConfigData : CSVBaseData
	{
		// Token: 0x060042DB RID: 17115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DB")]
		[Address(RVA = "0x14F8F20", Offset = "0x14F8F20", VA = "0x7BBBCF8F20", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042DC")]
		[Address(RVA = "0x14F8F68", Offset = "0x14F8F68", VA = "0x7BBBCF8F68", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042DD")]
		[Address(RVA = "0x14F9068", Offset = "0x14F9068", VA = "0x7BBBCF9068")]
		public ClanLuckyBagConfigData()
		{
		}

		// Token: 0x040051FD RID: 20989
		[Token(Token = "0x40051FD")]
		public const string PRIMARYKEY = "key";

		// Token: 0x040051FE RID: 20990
		[Token(Token = "0x40051FE")]
		[FieldOffset(Offset = "0x10")]
		public uint EffectiveHours;

		// Token: 0x040051FF RID: 20991
		[Token(Token = "0x40051FF")]
		[FieldOffset(Offset = "0x14")]
		public uint MaxDrawNumPerDay;

		// Token: 0x04005200 RID: 20992
		[Token(Token = "0x4005200")]
		[FieldOffset(Offset = "0x18")]
		public uint MaxBagsPerClan;

		// Token: 0x04005201 RID: 20993
		[Token(Token = "0x4005201")]
		[FieldOffset(Offset = "0x1C")]
		public uint GuildTokenItemID;
	}
}
