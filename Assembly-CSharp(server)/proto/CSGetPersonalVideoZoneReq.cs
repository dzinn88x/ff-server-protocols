using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008D9 RID: 2265
	[Token(Token = "0x20008D9")]
	[ProtoContract]
	public class CSGetPersonalVideoZoneReq
	{
		// Token: 0x060025E7 RID: 9703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E7")]
		[Address(RVA = "0x21B51B4", Offset = "0x21B51B4", VA = "0x7BBC9B51B4")]
		public CSGetPersonalVideoZoneReq()
		{
		}

		// Token: 0x04002A69 RID: 10857
		[Token(Token = "0x4002A69")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116F08", Offset = "0x1116F08")]
		public ulong other_account_id;

		// Token: 0x04002A6A RID: 10858
		[Token(Token = "0x4002A6A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116F1C", Offset = "0x1116F1C")]
		public ELive.VideoType video_type;

		// Token: 0x04002A6B RID: 10859
		[Token(Token = "0x4002A6B")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116F30", Offset = "0x1116F30")]
		public uint page_id;
	}
}
