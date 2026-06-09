using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000617 RID: 1559
	[Token(Token = "0x2000617")]
	[ProtoContract]
	public class PlatformGuestBindRes
	{
		// Token: 0x06002392 RID: 9106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002392")]
		[Address(RVA = "0x249F45C", Offset = "0x249F45C", VA = "0x7BBCC9F45C")]
		public PlatformGuestBindRes()
		{
		}

		// Token: 0x04001F13 RID: 7955
		[Token(Token = "0x4001F13")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107BC0", Offset = "0x1107BC0")]
		public uint result;
	}
}
