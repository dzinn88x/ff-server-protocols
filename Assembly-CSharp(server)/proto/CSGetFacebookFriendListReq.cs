using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200082A RID: 2090
	[Token(Token = "0x200082A")]
	[ProtoContract]
	public class CSGetFacebookFriendListReq
	{
		// Token: 0x0600253B RID: 9531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253B")]
		[Address(RVA = "0x21B3644", Offset = "0x21B3644", VA = "0x7BBC9B3644")]
		public CSGetFacebookFriendListReq()
		{
		}

		// Token: 0x0400273F RID: 10047
		[Token(Token = "0x400273F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111115C", Offset = "0x111115C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111115C", Offset = "0x111115C")]
		public string token;

		// Token: 0x04002740 RID: 10048
		[Token(Token = "0x4002740")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11111AC", Offset = "0x11111AC")]
		public bool need_presence;

		// Token: 0x04002741 RID: 10049
		[Token(Token = "0x4002741")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11111C0", Offset = "0x11111C0")]
		public bool need_stats;

		// Token: 0x04002742 RID: 10050
		[Token(Token = "0x4002742")]
		[FieldOffset(Offset = "0x1A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11111D4", Offset = "0x11111D4")]
		public bool need_ranking_stats;

		// Token: 0x04002743 RID: 10051
		[Token(Token = "0x4002743")]
		[FieldOffset(Offset = "0x1B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11111E8", Offset = "0x11111E8")]
		public bool need_casual_stats;

		// Token: 0x04002744 RID: 10052
		[Token(Token = "0x4002744")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11111FC", Offset = "0x11111FC")]
		public bool need_cs_ranking_stats;
	}
}
