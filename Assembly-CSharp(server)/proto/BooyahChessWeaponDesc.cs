using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B34 RID: 2868
	[Token(Token = "0x2000B34")]
	[ProtoContract]
	public class BooyahChessWeaponDesc
	{
		// Token: 0x0600283C RID: 10300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283C")]
		[Address(RVA = "0x21AFBEC", Offset = "0x21AFBEC", VA = "0x7BBC9AFBEC")]
		public BooyahChessWeaponDesc()
		{
		}

		// Token: 0x0400366F RID: 13935
		[Token(Token = "0x400366F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CA10", Offset = "0x112CA10")]
		public uint id;

		// Token: 0x04003670 RID: 13936
		[Token(Token = "0x4003670")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CA24", Offset = "0x112CA24")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112CA24", Offset = "0x112CA24")]
		public string desc;

		// Token: 0x04003671 RID: 13937
		[Token(Token = "0x4003671")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112CA74", Offset = "0x112CA74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CA74", Offset = "0x112CA74")]
		public string key;

		// Token: 0x04003672 RID: 13938
		[Token(Token = "0x4003672")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CAC4", Offset = "0x112CAC4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112CAC4", Offset = "0x112CAC4")]
		public string icon;

		// Token: 0x04003673 RID: 13939
		[Token(Token = "0x4003673")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CB14", Offset = "0x112CB14")]
		public uint weight;
	}
}
