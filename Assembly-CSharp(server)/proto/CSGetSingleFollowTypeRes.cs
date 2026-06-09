using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008E8 RID: 2280
	[Token(Token = "0x20008E8")]
	[ProtoContract]
	public class CSGetSingleFollowTypeRes
	{
		// Token: 0x060025F6 RID: 9718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F6")]
		[Address(RVA = "0x21B5AB8", Offset = "0x21B5AB8", VA = "0x7BBC9B5AB8")]
		public CSGetSingleFollowTypeRes()
		{
		}

		// Token: 0x04002A91 RID: 10897
		[Token(Token = "0x4002A91")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117408", Offset = "0x1117408")]
		public bool is_streamer;

		// Token: 0x04002A92 RID: 10898
		[Token(Token = "0x4002A92")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111741C", Offset = "0x111741C")]
		public ELive.FollowerType follower_type;
	}
}
