using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008DD RID: 2269
	[Token(Token = "0x20008DD")]
	[ProtoContract]
	public class CSGetAllVideoListByVideoTypeReq
	{
		// Token: 0x060025EB RID: 9707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EB")]
		[Address(RVA = "0x21B1EAC", Offset = "0x21B1EAC", VA = "0x7BBC9B1EAC")]
		public CSGetAllVideoListByVideoTypeReq()
		{
		}

		// Token: 0x04002A74 RID: 10868
		[Token(Token = "0x4002A74")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117020", Offset = "0x1117020")]
		public ELive.VideoType video_type;

		// Token: 0x04002A75 RID: 10869
		[Token(Token = "0x4002A75")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117034", Offset = "0x1117034")]
		public uint page_id;
	}
}
