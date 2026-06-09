using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008FE RID: 2302
	[Token(Token = "0x20008FE")]
	[ProtoContract]
	public class CSDismissTeamReq
	{
		// Token: 0x0600260C RID: 9740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260C")]
		[Address(RVA = "0x21B0F68", Offset = "0x21B0F68", VA = "0x7BBC9B0F68")]
		public CSDismissTeamReq()
		{
		}

		// Token: 0x04002AC8 RID: 10952
		[Token(Token = "0x4002AC8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117A84", Offset = "0x1117A84")]
		public ulong team_id;
	}
}
