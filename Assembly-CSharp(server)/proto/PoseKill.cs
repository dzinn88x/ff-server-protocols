using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000643 RID: 1603
	[Token(Token = "0x2000643")]
	[ProtoContract]
	public class PoseKill
	{
		// Token: 0x060023AD RID: 9133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AD")]
		[Address(RVA = "0x249F6DC", Offset = "0x249F6DC", VA = "0x7BBCC9F6DC")]
		public PoseKill()
		{
		}

		// Token: 0x04001FB4 RID: 8116
		[Token(Token = "0x4001FB4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110837C", Offset = "0x110837C")]
		public uint pose;

		// Token: 0x04001FB5 RID: 8117
		[Token(Token = "0x4001FB5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108390", Offset = "0x1108390")]
		public uint cnt;
	}
}
