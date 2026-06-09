using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006F0 RID: 1776
	[Token(Token = "0x20006F0")]
	[ProtoContract]
	public class CSGetPlayerTCStatsReq
	{
		// Token: 0x060023FE RID: 9214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x21B5624", Offset = "0x21B5624", VA = "0x7BBC9B5624")]
		public CSGetPlayerTCStatsReq()
		{
		}

		// Token: 0x040022B2 RID: 8882
		[Token(Token = "0x40022B2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109DA8", Offset = "0x1109DA8")]
		public ulong account_id;

		// Token: 0x040022B3 RID: 8883
		[Token(Token = "0x40022B3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109DBC", Offset = "0x1109DBC")]
		public uint season_id;

		// Token: 0x040022B4 RID: 8884
		[Token(Token = "0x40022B4")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109DD0", Offset = "0x1109DD0")]
		public uint game_mode;

		// Token: 0x040022B5 RID: 8885
		[Token(Token = "0x40022B5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109DE4", Offset = "0x1109DE4")]
		public uint match_mode;
	}
}
