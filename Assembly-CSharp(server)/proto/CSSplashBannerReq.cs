using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000846 RID: 2118
	[Token(Token = "0x2000846")]
	[ProtoContract]
	public class CSSplashBannerReq
	{
		// Token: 0x0600255B RID: 9563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255B")]
		[Address(RVA = "0x21B76A4", Offset = "0x21B76A4", VA = "0x7BBC9B76A4")]
		public CSSplashBannerReq()
		{
		}

		// Token: 0x0400277F RID: 10111
		[Token(Token = "0x400277F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11116FC", Offset = "0x11116FC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11116FC", Offset = "0x11116FC")]
		public string language;

		// Token: 0x04002780 RID: 10112
		[Token(Token = "0x4002780")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111174C", Offset = "0x111174C")]
		public EAnnouncement.Os os;

		// Token: 0x04002781 RID: 10113
		[Token(Token = "0x4002781")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111760", Offset = "0x1111760")]
		public EAnnouncement.AndroidChannel android_channel;
	}
}
