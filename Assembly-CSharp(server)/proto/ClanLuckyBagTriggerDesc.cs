using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A47 RID: 2631
	[Token(Token = "0x2000A47")]
	[ProtoContract]
	public class ClanLuckyBagTriggerDesc
	{
		// Token: 0x06002751 RID: 10065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002751")]
		[Address(RVA = "0x21B8870", Offset = "0x21B8870", VA = "0x7BBC9B8870")]
		public ClanLuckyBagTriggerDesc()
		{
		}

		// Token: 0x04002FF4 RID: 12276
		[Token(Token = "0x4002FF4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11205D0", Offset = "0x11205D0")]
		public uint event_type;

		// Token: 0x04002FF5 RID: 12277
		[Token(Token = "0x4002FF5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11205E4", Offset = "0x11205E4")]
		public uint lucky_bag_capacity;
	}
}
