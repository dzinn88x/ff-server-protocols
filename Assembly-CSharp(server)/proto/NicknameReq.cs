using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005E1 RID: 1505
	[Token(Token = "0x20005E1")]
	[ProtoContract]
	public class NicknameReq
	{
		// Token: 0x06002361 RID: 9057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002361")]
		[Address(RVA = "0x249EC18", Offset = "0x249EC18", VA = "0x7BBCC9EC18")]
		public NicknameReq()
		{
		}

		// Token: 0x04001DCB RID: 7627
		[Token(Token = "0x4001DCB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11055A0", Offset = "0x11055A0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11055A0", Offset = "0x11055A0")]
		public string nickname;
	}
}
