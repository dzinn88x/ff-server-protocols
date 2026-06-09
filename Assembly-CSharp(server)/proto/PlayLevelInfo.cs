using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200079E RID: 1950
	[Token(Token = "0x200079E")]
	[ProtoContract]
	public class PlayLevelInfo
	{
		// Token: 0x060024AD RID: 9389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AD")]
		[Address(RVA = "0x249F640", Offset = "0x249F640", VA = "0x7BBCC9F640")]
		public PlayLevelInfo()
		{
		}

		// Token: 0x040025AF RID: 9647
		[Token(Token = "0x40025AF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E524", Offset = "0x110E524")]
		public uint id;

		// Token: 0x040025B0 RID: 9648
		[Token(Token = "0x40025B0")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E538", Offset = "0x110E538")]
		public uint level;

		// Token: 0x040025B1 RID: 9649
		[Token(Token = "0x40025B1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E54C", Offset = "0x110E54C")]
		public EStore.PayLevelInfoState state;
	}
}
