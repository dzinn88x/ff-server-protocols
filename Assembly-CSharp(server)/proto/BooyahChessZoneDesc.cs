using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B32 RID: 2866
	[Token(Token = "0x2000B32")]
	[ProtoContract]
	public class BooyahChessZoneDesc
	{
		// Token: 0x0600283A RID: 10298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283A")]
		[Address(RVA = "0x21AFC4C", Offset = "0x21AFC4C", VA = "0x7BBC9AFC4C")]
		public BooyahChessZoneDesc()
		{
		}

		// Token: 0x0400365F RID: 13919
		[Token(Token = "0x400365F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C8D0", Offset = "0x112C8D0")]
		public uint id;

		// Token: 0x04003660 RID: 13920
		[Token(Token = "0x4003660")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C8E4", Offset = "0x112C8E4")]
		public uint step;

		// Token: 0x04003661 RID: 13921
		[Token(Token = "0x4003661")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C8F8", Offset = "0x112C8F8")]
		public bool booyah;

		// Token: 0x04003662 RID: 13922
		[Token(Token = "0x4003662")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C90C", Offset = "0x112C90C")]
		public double radius;
	}
}
