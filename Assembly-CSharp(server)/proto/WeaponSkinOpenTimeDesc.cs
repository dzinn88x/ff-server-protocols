using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B1C RID: 2844
	[Token(Token = "0x2000B1C")]
	[ProtoContract]
	public class WeaponSkinOpenTimeDesc
	{
		// Token: 0x06002824 RID: 10276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002824")]
		[Address(RVA = "0x24A1878", Offset = "0x24A1878", VA = "0x7BBCCA1878")]
		public WeaponSkinOpenTimeDesc()
		{
		}

		// Token: 0x040035F3 RID: 13811
		[Token(Token = "0x40035F3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BD90", Offset = "0x112BD90")]
		public uint weapon_set;

		// Token: 0x040035F4 RID: 13812
		[Token(Token = "0x40035F4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BDA4", Offset = "0x112BDA4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112BDA4", Offset = "0x112BDA4")]
		public string open_time;

		// Token: 0x040035F5 RID: 13813
		[Token(Token = "0x40035F5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BDF4", Offset = "0x112BDF4")]
		public long open_time_stamp;

		// Token: 0x040035F6 RID: 13814
		[Token(Token = "0x40035F6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BE08", Offset = "0x112BE08")]
		public bool is_open;
	}
}
