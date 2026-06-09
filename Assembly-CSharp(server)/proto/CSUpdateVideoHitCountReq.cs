using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008DF RID: 2271
	[Token(Token = "0x20008DF")]
	[ProtoContract]
	public class CSUpdateVideoHitCountReq
	{
		// Token: 0x060025ED RID: 9709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025ED")]
		[Address(RVA = "0x21B7C90", Offset = "0x21B7C90", VA = "0x7BBC9B7C90")]
		public CSUpdateVideoHitCountReq()
		{
		}

		// Token: 0x04002A77 RID: 10871
		[Token(Token = "0x4002A77")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111705C", Offset = "0x111705C")]
		public ulong streamer_id;

		// Token: 0x04002A78 RID: 10872
		[Token(Token = "0x4002A78")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117070", Offset = "0x1117070")]
		public uint video_id;
	}
}
