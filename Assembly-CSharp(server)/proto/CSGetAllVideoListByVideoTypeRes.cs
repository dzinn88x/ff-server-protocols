using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008DE RID: 2270
	[Token(Token = "0x20008DE")]
	[ProtoContract]
	public class CSGetAllVideoListByVideoTypeRes
	{
		// Token: 0x060025EC RID: 9708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EC")]
		[Address(RVA = "0x21B1EB4", Offset = "0x21B1EB4", VA = "0x7BBC9B1EB4")]
		public CSGetAllVideoListByVideoTypeRes()
		{
		}

		// Token: 0x04002A76 RID: 10870
		[Token(Token = "0x4002A76")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117048", Offset = "0x1117048")]
		public List<VideoDetail> video_list;
	}
}
