using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004B1 RID: 1201
	[Token(Token = "0x20004B1")]
	[ProtoContract]
	public class ShowPetActionNtf
	{
		// Token: 0x06001E79 RID: 7801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E79")]
		[Address(RVA = "0x24A7104", Offset = "0x24A7104", VA = "0x7BBCCA7104")]
		public ShowPetActionNtf()
		{
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		// (set) Token: 0x06001E7B RID: 7803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000452")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11567CC", Offset = "0x11567CC")]
		public ulong account_id
		{
			[Token(Token = "0x6001E7A")]
			[Address(RVA = "0x24A710C", Offset = "0x24A710C", VA = "0x7BBCCA710C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136E24", Offset = "0x1136E24")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001E7B")]
			[Address(RVA = "0x24A7114", Offset = "0x24A7114", VA = "0x7BBCCA7114")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136E34", Offset = "0x1136E34")]
			set
			{
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
		// (set) Token: 0x06001E7D RID: 7805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000453")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11567E0", Offset = "0x11567E0")]
		public uint action_id
		{
			[Token(Token = "0x6001E7C")]
			[Address(RVA = "0x24A711C", Offset = "0x24A711C", VA = "0x7BBCCA711C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136E44", Offset = "0x1136E44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E7D")]
			[Address(RVA = "0x24A7124", Offset = "0x24A7124", VA = "0x7BBCCA7124")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136E54", Offset = "0x1136E54")]
			set
			{
			}
		}

		// Token: 0x04001677 RID: 5751
		[Token(Token = "0x4001677")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102CD4", Offset = "0x1102CD4")]
		private ulong <account_id>k__BackingField;

		// Token: 0x04001678 RID: 5752
		[Token(Token = "0x4001678")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102CE4", Offset = "0x1102CE4")]
		private uint <action_id>k__BackingField;
	}
}
