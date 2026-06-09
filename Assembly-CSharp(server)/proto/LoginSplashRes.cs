using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008A4 RID: 2212
	[Token(Token = "0x20008A4")]
	[ProtoContract]
	public class LoginSplashRes
	{
		// Token: 0x060025B2 RID: 9650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B2")]
		[Address(RVA = "0x21BC05C", Offset = "0x21BC05C", VA = "0x7BBC9BC05C")]
		public LoginSplashRes()
		{
		}

		// Token: 0x04002993 RID: 10643
		[Token(Token = "0x4002993")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115950", Offset = "0x1115950")]
		public CSAnnouncementRes accouncement_res;

		// Token: 0x04002994 RID: 10644
		[Token(Token = "0x4002994")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115964", Offset = "0x1115964")]
		public SplashBannerDescList splash_res;

		// Token: 0x04002995 RID: 10645
		[Token(Token = "0x4002995")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115978", Offset = "0x1115978")]
		public CSGetActivityInfoRes activity_info_res;
	}
}
