using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000619 RID: 1561
	[Token(Token = "0x2000619")]
	[ProtoContract]
	public class PlatformBalanceRes
	{
		// Token: 0x06002394 RID: 9108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002394")]
		[Address(RVA = "0x249F3E8", Offset = "0x249F3E8", VA = "0x7BBCC9F3E8")]
		public PlatformBalanceRes()
		{
		}

		// Token: 0x04001F18 RID: 7960
		[Token(Token = "0x4001F18")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107C9C", Offset = "0x1107C9C")]
		public uint point;
	}
}
