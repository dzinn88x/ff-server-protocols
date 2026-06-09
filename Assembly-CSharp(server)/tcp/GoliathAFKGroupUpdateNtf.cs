using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004C6 RID: 1222
	[Token(Token = "0x20004C6")]
	[ProtoContract]
	public class GoliathAFKGroupUpdateNtf
	{
		// Token: 0x06001ED6 RID: 7894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0x24A3088", Offset = "0x24A3088", VA = "0x7BBCCA3088")]
		public GoliathAFKGroupUpdateNtf()
		{
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x0000D338 File Offset: 0x0000B538
		// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000478")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156CE0", Offset = "0x1156CE0")]
		public ulong group_id
		{
			[Token(Token = "0x6001ED7")]
			[Address(RVA = "0x24A3090", Offset = "0x24A3090", VA = "0x7BBCCA3090")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11372E4", Offset = "0x11372E4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001ED8")]
			[Address(RVA = "0x24A3098", Offset = "0x24A3098", VA = "0x7BBCCA3098")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11372F4", Offset = "0x11372F4")]
			set
			{
			}
		}

		// Token: 0x040016B7 RID: 5815
		[Token(Token = "0x40016B7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102F34", Offset = "0x1102F34")]
		private ulong <group_id>k__BackingField;
	}
}
