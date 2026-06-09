using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006B6 RID: 1718
	[Token(Token = "0x20006B6")]
	[ProtoContract]
	public class AccountInfoWithTCStats
	{
		// Token: 0x060023DC RID: 9180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DC")]
		[Address(RVA = "0x21AE5F4", Offset = "0x21AE5F4", VA = "0x7BBC9AE5F4")]
		public AccountInfoWithTCStats()
		{
		}

		// Token: 0x040021BC RID: 8636
		[Token(Token = "0x40021BC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109240", Offset = "0x1109240")]
		public ulong account_id;

		// Token: 0x040021BD RID: 8637
		[Token(Token = "0x40021BD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109254", Offset = "0x1109254")]
		public uint games_played;

		// Token: 0x040021BE RID: 8638
		[Token(Token = "0x40021BE")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109268", Offset = "0x1109268")]
		public uint wins;

		// Token: 0x040021BF RID: 8639
		[Token(Token = "0x40021BF")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110927C", Offset = "0x110927C")]
		public uint kills;

		// Token: 0x040021C0 RID: 8640
		[Token(Token = "0x40021C0")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109290", Offset = "0x1109290")]
		public DetailedTCStats detailed_stats;
	}
}
