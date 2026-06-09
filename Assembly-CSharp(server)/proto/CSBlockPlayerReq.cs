using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200082E RID: 2094
	[Token(Token = "0x200082E")]
	[ProtoContract]
	public class CSBlockPlayerReq
	{
		// Token: 0x06002543 RID: 9539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002543")]
		[Address(RVA = "0x21B04CC", Offset = "0x21B04CC", VA = "0x7BBC9B04CC")]
		public CSBlockPlayerReq()
		{
		}

		// Token: 0x04002750 RID: 10064
		[Token(Token = "0x4002750")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111328", Offset = "0x1111328")]
		public ulong blocked_id;
	}
}
