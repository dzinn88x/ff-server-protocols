using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000583 RID: 1411
	[Token(Token = "0x2000583")]
	[ProtoContract]
	public class HackerInfo
	{
		// Token: 0x06002342 RID: 9026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002342")]
		[Address(RVA = "0x21BB1D8", Offset = "0x21BB1D8", VA = "0x7BBC9BB1D8")]
		public HackerInfo()
		{
		}

		// Token: 0x04001B8A RID: 7050
		[Token(Token = "0x4001B8A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1104F88", Offset = "0x1104F88")]
		public uint hacker_cdt_id;

		// Token: 0x04001B8B RID: 7051
		[Token(Token = "0x4001B8B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1104F9C", Offset = "0x1104F9C")]
		public uint hacker_tag;

		// Token: 0x04001B8C RID: 7052
		[Token(Token = "0x4001B8C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1104FB0", Offset = "0x1104FB0")]
		public long hackerpool_time;
	}
}
