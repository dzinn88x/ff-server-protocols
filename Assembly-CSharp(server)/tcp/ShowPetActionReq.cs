using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004B0 RID: 1200
	[Token(Token = "0x20004B0")]
	[ProtoContract]
	public class ShowPetActionReq
	{
		// Token: 0x06001E74 RID: 7796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E74")]
		[Address(RVA = "0x24A712C", Offset = "0x24A712C", VA = "0x7BBCCA712C")]
		public ShowPetActionReq()
		{
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x0000D080 File Offset: 0x0000B280
		// (set) Token: 0x06001E76 RID: 7798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000450")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11567A4", Offset = "0x11567A4")]
		public ulong group_id
		{
			[Token(Token = "0x6001E75")]
			[Address(RVA = "0x24A7134", Offset = "0x24A7134", VA = "0x7BBCCA7134")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136DE4", Offset = "0x1136DE4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001E76")]
			[Address(RVA = "0x24A713C", Offset = "0x24A713C", VA = "0x7BBCCA713C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136DF4", Offset = "0x1136DF4")]
			set
			{
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x0000D098 File Offset: 0x0000B298
		// (set) Token: 0x06001E78 RID: 7800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000451")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11567B8", Offset = "0x11567B8")]
		public uint action_id
		{
			[Token(Token = "0x6001E77")]
			[Address(RVA = "0x24A7144", Offset = "0x24A7144", VA = "0x7BBCCA7144")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136E04", Offset = "0x1136E04")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E78")]
			[Address(RVA = "0x24A714C", Offset = "0x24A714C", VA = "0x7BBCCA714C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136E14", Offset = "0x1136E14")]
			set
			{
			}
		}

		// Token: 0x04001675 RID: 5749
		[Token(Token = "0x4001675")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102CB4", Offset = "0x1102CB4")]
		private ulong <group_id>k__BackingField;

		// Token: 0x04001676 RID: 5750
		[Token(Token = "0x4001676")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102CC4", Offset = "0x1102CC4")]
		private uint <action_id>k__BackingField;
	}
}
