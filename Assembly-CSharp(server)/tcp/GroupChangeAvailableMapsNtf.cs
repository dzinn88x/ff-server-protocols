using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004B4 RID: 1204
	[Token(Token = "0x20004B4")]
	[ProtoContract]
	public class GroupChangeAvailableMapsNtf
	{
		// Token: 0x06001E86 RID: 7814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E86")]
		[Address(RVA = "0x24A32EC", Offset = "0x24A32EC", VA = "0x7BBCCA32EC")]
		public GroupChangeAvailableMapsNtf()
		{
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		// (set) Token: 0x06001E88 RID: 7816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000457")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156880", Offset = "0x1156880")]
		public ulong account_id
		{
			[Token(Token = "0x6001E87")]
			[Address(RVA = "0x24A32F4", Offset = "0x24A32F4", VA = "0x7BBCCA32F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136EC4", Offset = "0x1136EC4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001E88")]
			[Address(RVA = "0x24A32FC", Offset = "0x24A32FC", VA = "0x7BBCCA32FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136ED4", Offset = "0x1136ED4")]
			set
			{
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E8A RID: 7818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000458")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156894", Offset = "0x1156894")]
		public uint[] available_maps
		{
			[Token(Token = "0x6001E89")]
			[Address(RVA = "0x24A3304", Offset = "0x24A3304", VA = "0x7BBCCA3304")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136EE4", Offset = "0x1136EE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E8A")]
			[Address(RVA = "0x24A330C", Offset = "0x24A330C", VA = "0x7BBCCA330C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136EF4", Offset = "0x1136EF4")]
			set
			{
			}
		}

		// Token: 0x0400167C RID: 5756
		[Token(Token = "0x400167C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102D24", Offset = "0x1102D24")]
		private ulong <account_id>k__BackingField;

		// Token: 0x0400167D RID: 5757
		[Token(Token = "0x400167D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102D34", Offset = "0x1102D34")]
		private uint[] <available_maps>k__BackingField;
	}
}
