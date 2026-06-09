using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000641 RID: 1601
	[Token(Token = "0x2000641")]
	[ProtoContract]
	public class CamouflageKill
	{
		// Token: 0x060023AB RID: 9131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AB")]
		[Address(RVA = "0x21B7E1C", Offset = "0x21B7E1C", VA = "0x7BBC9B7E1C")]
		public CamouflageKill()
		{
		}

		// Token: 0x04001FB0 RID: 8112
		[Token(Token = "0x4001FB0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110832C", Offset = "0x110832C")]
		public uint camouflage_id;

		// Token: 0x04001FB1 RID: 8113
		[Token(Token = "0x4001FB1")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108340", Offset = "0x1108340")]
		public uint cnt;
	}
}
