using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008E6 RID: 2278
	[Token(Token = "0x20008E6")]
	[ProtoContract]
	public class CSGetFollowStreamerListRes
	{
		// Token: 0x060025F4 RID: 9716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F4")]
		[Address(RVA = "0x21B3790", Offset = "0x21B3790", VA = "0x7BBC9B3790")]
		public CSGetFollowStreamerListRes()
		{
		}

		// Token: 0x04002A8E RID: 10894
		[Token(Token = "0x4002A8E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11173CC", Offset = "0x11173CC")]
		public List<StreamerBaseInfo> streamer_list;

		// Token: 0x04002A8F RID: 10895
		[Token(Token = "0x4002A8F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11173E0", Offset = "0x11173E0")]
		public List<StreamerBaseInfo> recommended_streamer_list;
	}
}
