using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006D4 RID: 1748
	[Token(Token = "0x20006D4")]
	[ProtoContract]
	public class LoginQueueInfo
	{
		// Token: 0x060023E3 RID: 9187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E3")]
		[Address(RVA = "0x21BBE84", Offset = "0x21BBE84", VA = "0x7BBC9BBE84")]
		public LoginQueueInfo()
		{
		}

		// Token: 0x04002278 RID: 8824
		[Token(Token = "0x4002278")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11093F8", Offset = "0x11093F8")]
		public bool Allow;

		// Token: 0x04002279 RID: 8825
		[Token(Token = "0x4002279")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110940C", Offset = "0x110940C")]
		public uint queue_position;

		// Token: 0x0400227A RID: 8826
		[Token(Token = "0x400227A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109420", Offset = "0x1109420")]
		public uint need_wait_secs;

		// Token: 0x0400227B RID: 8827
		[Token(Token = "0x400227B")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109434", Offset = "0x1109434")]
		public bool queue_is_full;
	}
}
