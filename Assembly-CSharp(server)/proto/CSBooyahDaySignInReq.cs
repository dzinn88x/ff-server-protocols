using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000974 RID: 2420
	[Token(Token = "0x2000974")]
	[ProtoContract]
	public class CSBooyahDaySignInReq
	{
		// Token: 0x06002682 RID: 9858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002682")]
		[Address(RVA = "0x21B04DC", Offset = "0x21B04DC", VA = "0x7BBC9B04DC")]
		public CSBooyahDaySignInReq()
		{
		}

		// Token: 0x04002C10 RID: 11280
		[Token(Token = "0x4002C10")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119924", Offset = "0x1119924")]
		public uint sign_id;
	}
}
