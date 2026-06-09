using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A7E RID: 2686
	[Token(Token = "0x2000A7E")]
	[ProtoContract]
	public class EPUpdateDesc
	{
		// Token: 0x06002788 RID: 10120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002788")]
		[Address(RVA = "0x21B9A0C", Offset = "0x21B9A0C", VA = "0x7BBC9B9A0C")]
		public EPUpdateDesc()
		{
		}

		// Token: 0x0400316E RID: 12654
		[Token(Token = "0x400316E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122CE0", Offset = "0x1122CE0")]
		public uint ep_id;

		// Token: 0x0400316F RID: 12655
		[Token(Token = "0x400316F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122CF4", Offset = "0x1122CF4")]
		public bool ep_entrance;

		// Token: 0x04003170 RID: 12656
		[Token(Token = "0x4003170")]
		[FieldOffset(Offset = "0x15")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122D08", Offset = "0x1122D08")]
		public bool ep_quest;

		// Token: 0x04003171 RID: 12657
		[Token(Token = "0x4003171")]
		[FieldOffset(Offset = "0x16")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122D1C", Offset = "0x1122D1C")]
		public bool ep_badge;
	}
}
