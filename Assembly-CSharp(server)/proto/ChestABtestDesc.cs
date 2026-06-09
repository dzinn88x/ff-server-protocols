using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A9A RID: 2714
	[Token(Token = "0x2000A9A")]
	[ProtoContract]
	public class ChestABtestDesc
	{
		// Token: 0x060027A4 RID: 10148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A4")]
		[Address(RVA = "0x21B8350", Offset = "0x21B8350", VA = "0x7BBC9B8350")]
		public ChestABtestDesc()
		{
		}

		// Token: 0x0400328F RID: 12943
		[Token(Token = "0x400328F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124E14", Offset = "0x1124E14")]
		public uint chest_id;

		// Token: 0x04003290 RID: 12944
		[Token(Token = "0x4003290")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124E28", Offset = "0x1124E28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1124E28", Offset = "0x1124E28")]
		public string @class;

		// Token: 0x04003291 RID: 12945
		[Token(Token = "0x4003291")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124E78", Offset = "0x1124E78")]
		public uint original_melon_pi;

		// Token: 0x04003292 RID: 12946
		[Token(Token = "0x4003292")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124E8C", Offset = "0x1124E8C")]
		public uint abtest_melon_pi;

		// Token: 0x04003293 RID: 12947
		[Token(Token = "0x4003293")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124EA0", Offset = "0x1124EA0")]
		public uint chest_sub_id;
	}
}
