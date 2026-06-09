using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000834 RID: 2100
	[Token(Token = "0x2000834")]
	[ProtoContract]
	public class CSGetRecommandedFriendsByCdtReq
	{
		// Token: 0x06002549 RID: 9545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002549")]
		[Address(RVA = "0x21B58A8", Offset = "0x21B58A8", VA = "0x7BBC9B58A8")]
		public CSGetRecommandedFriendsByCdtReq()
		{
		}

		// Token: 0x04002757 RID: 10071
		[Token(Token = "0x4002757")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11113DC", Offset = "0x11113DC")]
		public ESocial.Language language;

		// Token: 0x04002758 RID: 10072
		[Token(Token = "0x4002758")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11113F0", Offset = "0x11113F0")]
		public ESocial.Gender gender;

		// Token: 0x04002759 RID: 10073
		[Token(Token = "0x4002759")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111404", Offset = "0x1111404")]
		public ESocial.TimeActive time_active;

		// Token: 0x0400275A RID: 10074
		[Token(Token = "0x400275A")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111418", Offset = "0x1111418")]
		public ESocial.ModePrefer mode_prefer;

		// Token: 0x0400275B RID: 10075
		[Token(Token = "0x400275B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111142C", Offset = "0x111142C")]
		public uint rank;
	}
}
