using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AED RID: 2797
	[Token(Token = "0x2000AED")]
	[ProtoContract]
	public class PlatformMemCheckDesc
	{
		// Token: 0x060027F5 RID: 10229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F5")]
		[Address(RVA = "0x249F464", Offset = "0x249F464", VA = "0x7BBCC9F464")]
		public PlatformMemCheckDesc()
		{
		}

		// Token: 0x040034B4 RID: 13492
		[Token(Token = "0x40034B4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11290B8", Offset = "0x11290B8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11290B8", Offset = "0x11290B8")]
		public string client_version;

		// Token: 0x040034B5 RID: 13493
		[Token(Token = "0x40034B5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129108", Offset = "0x1129108")]
		public uint platform_type;

		// Token: 0x040034B6 RID: 13494
		[Token(Token = "0x40034B6")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112911C", Offset = "0x112911C")]
		public uint channel_type;

		// Token: 0x040034B7 RID: 13495
		[Token(Token = "0x40034B7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129130", Offset = "0x1129130")]
		public uint cpu_type;

		// Token: 0x040034B8 RID: 13496
		[Token(Token = "0x40034B8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129144", Offset = "0x1129144")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129144", Offset = "0x1129144")]
		public string mem_value;

		// Token: 0x040034B9 RID: 13497
		[Token(Token = "0x40034B9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129194", Offset = "0x1129194")]
		public uint min_random_count;

		// Token: 0x040034BA RID: 13498
		[Token(Token = "0x40034BA")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11291A8", Offset = "0x11291A8")]
		public uint max_random_count;
	}
}
