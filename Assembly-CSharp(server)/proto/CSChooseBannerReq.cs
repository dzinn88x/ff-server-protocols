using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200076A RID: 1898
	[Token(Token = "0x200076A")]
	[ProtoContract]
	public class CSChooseBannerReq
	{
		// Token: 0x06002477 RID: 9335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002477")]
		[Address(RVA = "0x21B0650", Offset = "0x21B0650", VA = "0x7BBC9B0650")]
		public CSChooseBannerReq()
		{
		}

		// Token: 0x04002525 RID: 9509
		[Token(Token = "0x4002525")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D7C8", Offset = "0x110D7C8")]
		public uint banner_id;
	}
}
