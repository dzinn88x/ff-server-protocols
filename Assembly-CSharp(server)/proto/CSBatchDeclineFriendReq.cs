using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000826 RID: 2086
	[Token(Token = "0x2000826")]
	[ProtoContract]
	public class CSBatchDeclineFriendReq
	{
		// Token: 0x06002535 RID: 9525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002535")]
		[Address(RVA = "0x21B0448", Offset = "0x21B0448", VA = "0x7BBC9B0448")]
		public CSBatchDeclineFriendReq()
		{
		}

		// Token: 0x04002733 RID: 10035
		[Token(Token = "0x4002733")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110FCC", Offset = "0x1110FCC")]
		public ulong[] adder_list;
	}
}
