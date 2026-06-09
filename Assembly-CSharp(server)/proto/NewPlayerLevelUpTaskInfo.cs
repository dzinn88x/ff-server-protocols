using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007B0 RID: 1968
	[Token(Token = "0x20007B0")]
	[ProtoContract]
	public class NewPlayerLevelUpTaskInfo
	{
		// Token: 0x060024BF RID: 9407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024BF")]
		[Address(RVA = "0x249E9B4", Offset = "0x249E9B4", VA = "0x7BBCC9E9B4")]
		public NewPlayerLevelUpTaskInfo()
		{
		}

		// Token: 0x040025DE RID: 9694
		[Token(Token = "0x40025DE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E984", Offset = "0x110E984")]
		public uint id;

		// Token: 0x040025DF RID: 9695
		[Token(Token = "0x40025DF")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E998", Offset = "0x110E998")]
		public uint data;

		// Token: 0x040025E0 RID: 9696
		[Token(Token = "0x40025E0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E9AC", Offset = "0x110E9AC")]
		public EActivity.State state;
	}
}
