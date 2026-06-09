using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008D6 RID: 2262
	[Token(Token = "0x20008D6")]
	[ProtoContract]
	public class LoginBroadcastRes
	{
		// Token: 0x060025E4 RID: 9700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E4")]
		[Address(RVA = "0x21BBE10", Offset = "0x21BBE10", VA = "0x7BBC9BBE10")]
		public LoginBroadcastRes()
		{
		}

		// Token: 0x04002A60 RID: 10848
		[Token(Token = "0x4002A60")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116E18", Offset = "0x1116E18")]
		public CSScrollMarqueeRes scroll_res;

		// Token: 0x04002A61 RID: 10849
		[Token(Token = "0x4002A61")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116E2C", Offset = "0x1116E2C")]
		public CSGetBroadcastListRes broadcast_res;
	}
}
