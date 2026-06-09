using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000803 RID: 2051
	[Token(Token = "0x2000803")]
	[ProtoContract]
	public class CSUnlockProfileReq
	{
		// Token: 0x06002512 RID: 9490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002512")]
		[Address(RVA = "0x21B7AB4", Offset = "0x21B7AB4", VA = "0x7BBC9B7AB4")]
		public CSUnlockProfileReq()
		{
		}

		// Token: 0x040026E9 RID: 9961
		[Token(Token = "0x40026E9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111098C", Offset = "0x111098C")]
		public uint avatar_id;

		// Token: 0x040026EA RID: 9962
		[Token(Token = "0x40026EA")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11109A0", Offset = "0x11109A0")]
		public uint unlock_level;

		// Token: 0x040026EB RID: 9963
		[Token(Token = "0x40026EB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11109B4", Offset = "0x11109B4")]
		public bool use_general_debris;
	}
}
