using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A39 RID: 2617
	[Token(Token = "0x2000A39")]
	[ProtoContract]
	public class ClanExtendScaleDesc
	{
		// Token: 0x06002743 RID: 10051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002743")]
		[Address(RVA = "0x21B85B4", Offset = "0x21B85B4", VA = "0x7BBC9B85B4")]
		public ClanExtendScaleDesc()
		{
		}

		// Token: 0x04002FBE RID: 12222
		[Token(Token = "0x4002FBE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FFF4", Offset = "0x111FFF4")]
		public uint extend_times;

		// Token: 0x04002FBF RID: 12223
		[Token(Token = "0x4002FBF")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120008", Offset = "0x1120008")]
		public uint extend_size;

		// Token: 0x04002FC0 RID: 12224
		[Token(Token = "0x4002FC0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112001C", Offset = "0x112001C")]
		public uint diamond_cost;
	}
}
