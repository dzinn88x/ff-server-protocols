using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B10 RID: 2832
	[Token(Token = "0x2000B10")]
	[ProtoContract]
	public class AnniversaryTimeSettingDesc
	{
		// Token: 0x06002818 RID: 10264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002818")]
		[Address(RVA = "0x21AF098", Offset = "0x21AF098", VA = "0x7BBC9AF098")]
		public AnniversaryTimeSettingDesc()
		{
		}

		// Token: 0x0400358E RID: 13710
		[Token(Token = "0x400358E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AE68", Offset = "0x112AE68")]
		public uint id;

		// Token: 0x0400358F RID: 13711
		[Token(Token = "0x400358F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AE7C", Offset = "0x112AE7C")]
		public ulong material_amount;

		// Token: 0x04003590 RID: 13712
		[Token(Token = "0x4003590")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AE90", Offset = "0x112AE90")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112AE90", Offset = "0x112AE90")]
		public string time;
	}
}
