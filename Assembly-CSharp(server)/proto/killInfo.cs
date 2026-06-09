using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006FE RID: 1790
	[Token(Token = "0x20006FE")]
	[ProtoContract]
	public class killInfo
	{
		// Token: 0x0600240C RID: 9228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240C")]
		[Address(RVA = "0x24A1BE8", Offset = "0x24A1BE8", VA = "0x7BBCCA1BE8")]
		public killInfo()
		{
		}

		// Token: 0x040023AA RID: 9130
		[Token(Token = "0x40023AA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B324", Offset = "0x110B324")]
		public uint kill_time;

		// Token: 0x040023AB RID: 9131
		[Token(Token = "0x40023AB")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B338", Offset = "0x110B338")]
		public uint kill_hp;
	}
}
