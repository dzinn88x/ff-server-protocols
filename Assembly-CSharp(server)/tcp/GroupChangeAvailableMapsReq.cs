using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004B3 RID: 1203
	[Token(Token = "0x20004B3")]
	[ProtoContract]
	public class GroupChangeAvailableMapsReq
	{
		// Token: 0x06001E81 RID: 7809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E81")]
		[Address(RVA = "0x24A3314", Offset = "0x24A3314", VA = "0x7BBCCA3314")]
		public GroupChangeAvailableMapsReq()
		{
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
		// (set) Token: 0x06001E83 RID: 7811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000455")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156830", Offset = "0x1156830")]
		public ulong group_id
		{
			[Token(Token = "0x6001E82")]
			[Address(RVA = "0x24A331C", Offset = "0x24A331C", VA = "0x7BBCCA331C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136E84", Offset = "0x1136E84")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001E83")]
			[Address(RVA = "0x24A3324", Offset = "0x24A3324", VA = "0x7BBCCA3324")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136E94", Offset = "0x1136E94")]
			set
			{
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000456")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156844", Offset = "0x1156844")]
		public uint[] available_maps
		{
			[Token(Token = "0x6001E84")]
			[Address(RVA = "0x24A332C", Offset = "0x24A332C", VA = "0x7BBCCA332C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136EA4", Offset = "0x1136EA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E85")]
			[Address(RVA = "0x24A3334", Offset = "0x24A3334", VA = "0x7BBCCA3334")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136EB4", Offset = "0x1136EB4")]
			set
			{
			}
		}

		// Token: 0x0400167A RID: 5754
		[Token(Token = "0x400167A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102D04", Offset = "0x1102D04")]
		private ulong <group_id>k__BackingField;

		// Token: 0x0400167B RID: 5755
		[Token(Token = "0x400167B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102D14", Offset = "0x1102D14")]
		private uint[] <available_maps>k__BackingField;
	}
}
