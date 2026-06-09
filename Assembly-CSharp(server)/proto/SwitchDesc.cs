using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AD3 RID: 2771
	[Token(Token = "0x2000AD3")]
	[ProtoContract]
	public class SwitchDesc
	{
		// Token: 0x060027DB RID: 10203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DB")]
		[Address(RVA = "0x24A0CAC", Offset = "0x24A0CAC", VA = "0x7BBCCA0CAC")]
		public SwitchDesc()
		{
		}

		// Token: 0x0400340C RID: 13324
		[Token(Token = "0x400340C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127A38", Offset = "0x1127A38")]
		public ESwitch.SwitchFunc id;

		// Token: 0x0400340D RID: 13325
		[Token(Token = "0x400340D")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127A4C", Offset = "0x1127A4C")]
		public bool is_open;

		// Token: 0x0400340E RID: 13326
		[Token(Token = "0x400340E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127A60", Offset = "0x1127A60")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1127A60", Offset = "0x1127A60")]
		public string content;

		// Token: 0x0400340F RID: 13327
		[Token(Token = "0x400340F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127AB0", Offset = "0x1127AB0")]
		public long open_start_time;

		// Token: 0x04003410 RID: 13328
		[Token(Token = "0x4003410")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127AC4", Offset = "0x1127AC4")]
		public long open_end_time;
	}
}
