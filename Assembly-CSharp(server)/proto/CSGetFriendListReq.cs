using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000829 RID: 2089
	[Token(Token = "0x2000829")]
	[ProtoContract]
	public class CSGetFriendListReq
	{
		// Token: 0x06002538 RID: 9528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002538")]
		[Address(RVA = "0x21B3A44", Offset = "0x21B3A44", VA = "0x7BBC9B3A44")]
		public CSGetFriendListReq()
		{
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
		[Token(Token = "0x6002539")]
		[Address(RVA = "0x21B3A4C", Offset = "0x21B3A4C", VA = "0x7BBC9B3A4C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0000F600 File Offset: 0x0000D800
		[Token(Token = "0x600253A")]
		[Address(RVA = "0x21B3BD8", Offset = "0x21B3BD8", VA = "0x7BBC9B3BD8", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400273A RID: 10042
		[Token(Token = "0x400273A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11110F8", Offset = "0x11110F8")]
		public bool need_presence;

		// Token: 0x0400273B RID: 10043
		[Token(Token = "0x400273B")]
		[FieldOffset(Offset = "0x11")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111110C", Offset = "0x111110C")]
		public bool need_stats;

		// Token: 0x0400273C RID: 10044
		[Token(Token = "0x400273C")]
		[FieldOffset(Offset = "0x12")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111120", Offset = "0x1111120")]
		public bool need_ranking_stats;

		// Token: 0x0400273D RID: 10045
		[Token(Token = "0x400273D")]
		[FieldOffset(Offset = "0x13")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111134", Offset = "0x1111134")]
		public bool need_casual_stats;

		// Token: 0x0400273E RID: 10046
		[Token(Token = "0x400273E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111148", Offset = "0x1111148")]
		public bool need_cs_ranking_stats;
	}
}
