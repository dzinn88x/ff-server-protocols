using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000935 RID: 2357
	[Token(Token = "0x2000935")]
	[ProtoContract]
	public class CSFreshActivityTriggerReq
	{
		// Token: 0x06002643 RID: 9795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002643")]
		[Address(RVA = "0x21B1598", Offset = "0x21B1598", VA = "0x7BBC9B1598")]
		public CSFreshActivityTriggerReq()
		{
		}

		// Token: 0x04002B8B RID: 11147
		[Token(Token = "0x4002B8B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118C68", Offset = "0x1118C68")]
		public uint event_type;
	}
}
