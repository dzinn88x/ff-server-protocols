using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000818 RID: 2072
	[Token(Token = "0x2000818")]
	[ProtoContract]
	public class CSTransformGeneralDebrisReq
	{
		// Token: 0x06002527 RID: 9511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002527")]
		[Address(RVA = "0x21B7AA4", Offset = "0x21B7AA4", VA = "0x7BBC9B7AA4")]
		public CSTransformGeneralDebrisReq()
		{
		}

		// Token: 0x04002719 RID: 10009
		[Token(Token = "0x4002719")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110D9C", Offset = "0x1110D9C")]
		public uint general_debris_id;

		// Token: 0x0400271A RID: 10010
		[Token(Token = "0x400271A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110DB0", Offset = "0x1110DB0")]
		public uint transform_cnt;

		// Token: 0x0400271B RID: 10011
		[Token(Token = "0x400271B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110DC4", Offset = "0x1110DC4")]
		public uint target_debris_id;
	}
}
