using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008E7 RID: 2279
	[Token(Token = "0x20008E7")]
	[ProtoContract]
	public class CSGetSingleFollowTypeReq
	{
		// Token: 0x060025F5 RID: 9717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F5")]
		[Address(RVA = "0x21B5AB0", Offset = "0x21B5AB0", VA = "0x7BBC9B5AB0")]
		public CSGetSingleFollowTypeReq()
		{
		}

		// Token: 0x04002A90 RID: 10896
		[Token(Token = "0x4002A90")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11173F4", Offset = "0x11173F4")]
		public ulong streamer_id;
	}
}
