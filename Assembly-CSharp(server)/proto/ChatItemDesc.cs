using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009DA RID: 2522
	[Token(Token = "0x20009DA")]
	[ProtoContract]
	public class ChatItemDesc
	{
		// Token: 0x060026E4 RID: 9956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E4")]
		[Address(RVA = "0x21B8278", Offset = "0x21B8278", VA = "0x7BBC9B8278")]
		public ChatItemDesc()
		{
		}

		// Token: 0x04002D93 RID: 11667
		[Token(Token = "0x4002D93")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B814", Offset = "0x111B814")]
		public uint id;

		// Token: 0x04002D94 RID: 11668
		[Token(Token = "0x4002D94")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B828", Offset = "0x111B828")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111B828", Offset = "0x111B828")]
		public string name;

		// Token: 0x04002D95 RID: 11669
		[Token(Token = "0x4002D95")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B878", Offset = "0x111B878")]
		public uint coins_price;

		// Token: 0x04002D96 RID: 11670
		[Token(Token = "0x4002D96")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B88C", Offset = "0x111B88C")]
		public uint gems_price;
	}
}
