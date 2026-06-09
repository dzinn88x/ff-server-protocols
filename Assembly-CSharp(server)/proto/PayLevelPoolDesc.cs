using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AB3 RID: 2739
	[Token(Token = "0x2000AB3")]
	[ProtoContract]
	public class PayLevelPoolDesc
	{
		// Token: 0x060027BD RID: 10173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BD")]
		[Address(RVA = "0x249F0B8", Offset = "0x249F0B8", VA = "0x7BBCC9F0B8")]
		public PayLevelPoolDesc()
		{
		}

		// Token: 0x0400337D RID: 13181
		[Token(Token = "0x400337D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126DB8", Offset = "0x1126DB8")]
		public uint id;

		// Token: 0x0400337E RID: 13182
		[Token(Token = "0x400337E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126DCC", Offset = "0x1126DCC")]
		public uint unique_id;

		// Token: 0x0400337F RID: 13183
		[Token(Token = "0x400337F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126DE0", Offset = "0x1126DE0")]
		public uint start_time;

		// Token: 0x04003380 RID: 13184
		[Token(Token = "0x4003380")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126DF4", Offset = "0x1126DF4")]
		public uint end_time;
	}
}
