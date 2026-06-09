using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007EE RID: 2030
	[Token(Token = "0x20007EE")]
	[ProtoContract]
	public class CSGetClanRaceInfoRes
	{
		// Token: 0x060024FD RID: 9469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FD")]
		[Address(RVA = "0x21B2C24", Offset = "0x21B2C24", VA = "0x7BBC9B2C24")]
		public CSGetClanRaceInfoRes()
		{
		}

		// Token: 0x04002698 RID: 9880
		[Token(Token = "0x4002698")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110130", Offset = "0x1110130")]
		public uint stage;

		// Token: 0x04002699 RID: 9881
		[Token(Token = "0x4002699")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110144", Offset = "0x1110144")]
		public bool is_open;

		// Token: 0x0400269A RID: 9882
		[Token(Token = "0x400269A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110158", Offset = "0x1110158")]
		public List<ClanRaceRewardsDesc> rewards;

		// Token: 0x0400269B RID: 9883
		[Token(Token = "0x400269B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111016C", Offset = "0x111016C")]
		public uint race_point;

		// Token: 0x0400269C RID: 9884
		[Token(Token = "0x400269C")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110180", Offset = "0x1110180")]
		public uint latest_race_week_id;

		// Token: 0x0400269D RID: 9885
		[Token(Token = "0x400269D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110194", Offset = "0x1110194")]
		public List<RaceAwardExchange> exchange_info;

		// Token: 0x0400269E RID: 9886
		[Token(Token = "0x400269E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11101A8", Offset = "0x11101A8")]
		public ClanRaceOpenInfo clan_race_open_info;
	}
}
