using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008DC RID: 2268
	[Token(Token = "0x20008DC")]
	[ProtoContract]
	public class CSGetRecommendedVideoListRes
	{
		// Token: 0x060025EA RID: 9706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EA")]
		[Address(RVA = "0x21B59C0", Offset = "0x21B59C0", VA = "0x7BBC9B59C0")]
		public CSGetRecommendedVideoListRes()
		{
		}

		// Token: 0x04002A73 RID: 10867
		[Token(Token = "0x4002A73")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111700C", Offset = "0x111700C")]
		public List<VideoDetail> video_list;
	}
}
