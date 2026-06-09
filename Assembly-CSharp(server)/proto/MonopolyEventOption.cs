using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B38 RID: 2872
	[Token(Token = "0x2000B38")]
	[ProtoContract]
	public class MonopolyEventOption
	{
		// Token: 0x06002840 RID: 10304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002840")]
		[Address(RVA = "0x249E460", Offset = "0x249E460", VA = "0x7BBCC9E460")]
		public MonopolyEventOption()
		{
		}

		// Token: 0x0400368B RID: 13963
		[Token(Token = "0x400368B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112CD6C", Offset = "0x112CD6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CD6C", Offset = "0x112CD6C")]
		public string event_option;

		// Token: 0x0400368C RID: 13964
		[Token(Token = "0x400368C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CDBC", Offset = "0x112CDBC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112CDBC", Offset = "0x112CDBC")]
		public string event_result;

		// Token: 0x0400368D RID: 13965
		[Token(Token = "0x400368D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CE0C", Offset = "0x112CE0C")]
		public EMiniGame.MonopolyEventResultType event_result_type;

		// Token: 0x0400368E RID: 13966
		[Token(Token = "0x400368E")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CE20", Offset = "0x112CE20")]
		public uint event_result_value;
	}
}
