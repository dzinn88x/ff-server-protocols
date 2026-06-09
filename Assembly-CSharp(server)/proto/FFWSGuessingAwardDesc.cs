using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B4A RID: 2890
	[Token(Token = "0x2000B4A")]
	[ProtoContract]
	public class FFWSGuessingAwardDesc
	{
		// Token: 0x06002852 RID: 10322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002852")]
		[Address(RVA = "0x21BA124", Offset = "0x21BA124", VA = "0x7BBC9BA124")]
		public FFWSGuessingAwardDesc()
		{
		}

		// Token: 0x040036EA RID: 14058
		[Token(Token = "0x40036EA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DA64", Offset = "0x112DA64")]
		public uint session;

		// Token: 0x040036EB RID: 14059
		[Token(Token = "0x40036EB")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DA78", Offset = "0x112DA78")]
		public ELimitedEvent.FFWSGuessingAwardType award_enum;

		// Token: 0x040036EC RID: 14060
		[Token(Token = "0x40036EC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DA8C", Offset = "0x112DA8C")]
		public List<AwardDesc> awards;
	}
}
