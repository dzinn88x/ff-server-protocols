using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000473 RID: 1139
	[Token(Token = "0x2000473")]
	[ProtoContract]
	public class RemoveMemberReq
	{
		// Token: 0x06001CBC RID: 7356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBC")]
		[Address(RVA = "0x24A5B80", Offset = "0x24A5B80", VA = "0x7BBCCA5B80")]
		public RemoveMemberReq()
		{
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		// (set) Token: 0x06001CBE RID: 7358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154F1C", Offset = "0x1154F1C")]
		public ulong clan_id
		{
			[Token(Token = "0x6001CBD")]
			[Address(RVA = "0x24A5B88", Offset = "0x24A5B88", VA = "0x7BBCCA5B88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135524", Offset = "0x1135524")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CBE")]
			[Address(RVA = "0x24A5B90", Offset = "0x24A5B90", VA = "0x7BBCCA5B90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135534", Offset = "0x1135534")]
			set
			{
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
		// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154F30", Offset = "0x1154F30")]
		public ulong remover_id
		{
			[Token(Token = "0x6001CBF")]
			[Address(RVA = "0x24A5B98", Offset = "0x24A5B98", VA = "0x7BBCCA5B98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135544", Offset = "0x1135544")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CC0")]
			[Address(RVA = "0x24A5BA0", Offset = "0x24A5BA0", VA = "0x7BBCCA5BA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135554", Offset = "0x1135554")]
			set
			{
			}
		}

		// Token: 0x04001505 RID: 5381
		[Token(Token = "0x4001505")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102054", Offset = "0x1102054")]
		private ulong <clan_id>k__BackingField;

		// Token: 0x04001506 RID: 5382
		[Token(Token = "0x4001506")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102064", Offset = "0x1102064")]
		private ulong <remover_id>k__BackingField;
	}
}
