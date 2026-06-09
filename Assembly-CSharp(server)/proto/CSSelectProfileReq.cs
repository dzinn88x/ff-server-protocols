using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000801 RID: 2049
	[Token(Token = "0x2000801")]
	[ProtoContract]
	public class CSSelectProfileReq
	{
		// Token: 0x06002510 RID: 9488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002510")]
		[Address(RVA = "0x21B75F0", Offset = "0x21B75F0", VA = "0x7BBC9B75F0")]
		public CSSelectProfileReq()
		{
		}

		// Token: 0x040026E7 RID: 9959
		[Token(Token = "0x40026E7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110964", Offset = "0x1110964")]
		public uint avatar_id;
	}
}
