using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006B4 RID: 1716
	[Token(Token = "0x20006B4")]
	[ProtoContract]
	public class AccountInfoWithStatsToClient
	{
		// Token: 0x060023DA RID: 9178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DA")]
		[Address(RVA = "0x21AE5EC", Offset = "0x21AE5EC", VA = "0x7BBC9AE5EC")]
		public AccountInfoWithStatsToClient()
		{
		}

		// Token: 0x040021AD RID: 8621
		[Token(Token = "0x40021AD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109114", Offset = "0x1109114")]
		public ulong account_id;

		// Token: 0x040021AE RID: 8622
		[Token(Token = "0x40021AE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109128", Offset = "0x1109128")]
		public uint games_played;

		// Token: 0x040021AF RID: 8623
		[Token(Token = "0x40021AF")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110913C", Offset = "0x110913C")]
		public uint wins;

		// Token: 0x040021B0 RID: 8624
		[Token(Token = "0x40021B0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109150", Offset = "0x1109150")]
		public uint kills;

		// Token: 0x040021B1 RID: 8625
		[Token(Token = "0x40021B1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109164", Offset = "0x1109164")]
		public PlayerDetailedStats detailed_stats;
	}
}
