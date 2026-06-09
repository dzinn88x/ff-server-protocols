using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B1B RID: 2843
	[Token(Token = "0x2000B1B")]
	[ProtoContract]
	public class WeaponSkinSystemTimeDesc
	{
		// Token: 0x06002823 RID: 10275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002823")]
		[Address(RVA = "0x24A18D4", Offset = "0x24A18D4", VA = "0x7BBCCA18D4")]
		public WeaponSkinSystemTimeDesc()
		{
		}

		// Token: 0x040035F0 RID: 13808
		[Token(Token = "0x40035F0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112BCDC", Offset = "0x112BCDC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BCDC", Offset = "0x112BCDC")]
		public string region;

		// Token: 0x040035F1 RID: 13809
		[Token(Token = "0x40035F1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112BD2C", Offset = "0x112BD2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BD2C", Offset = "0x112BD2C")]
		public string open_time;

		// Token: 0x040035F2 RID: 13810
		[Token(Token = "0x40035F2")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BD7C", Offset = "0x112BD7C")]
		public long open_time_stamp;
	}
}
