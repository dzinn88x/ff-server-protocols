using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B4C RID: 2892
	[Token(Token = "0x2000B4C")]
	[ProtoContract]
	public class FFWSSpecialTaskTextDesc
	{
		// Token: 0x06002854 RID: 10324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002854")]
		[Address(RVA = "0x21BA200", Offset = "0x21BA200", VA = "0x7BBC9BA200")]
		public FFWSSpecialTaskTextDesc()
		{
		}

		// Token: 0x040036F4 RID: 14068
		[Token(Token = "0x40036F4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DC58", Offset = "0x112DC58")]
		public uint index;

		// Token: 0x040036F5 RID: 14069
		[Token(Token = "0x40036F5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DC6C", Offset = "0x112DC6C")]
		public uint activity_id;

		// Token: 0x040036F6 RID: 14070
		[Token(Token = "0x40036F6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112DC80", Offset = "0x112DC80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DC80", Offset = "0x112DC80")]
		public string task_text1;

		// Token: 0x040036F7 RID: 14071
		[Token(Token = "0x40036F7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DCD0", Offset = "0x112DCD0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112DCD0", Offset = "0x112DCD0")]
		public string task_text2;

		// Token: 0x040036F8 RID: 14072
		[Token(Token = "0x40036F8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DD20", Offset = "0x112DD20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112DD20", Offset = "0x112DD20")]
		public string task_text3;

		// Token: 0x040036F9 RID: 14073
		[Token(Token = "0x40036F9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112DD70", Offset = "0x112DD70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DD70", Offset = "0x112DD70")]
		public string task_text4;

		// Token: 0x040036FA RID: 14074
		[Token(Token = "0x40036FA")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112DDC0", Offset = "0x112DDC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DDC0", Offset = "0x112DDC0")]
		public string task_text5;
	}
}
