using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004D4 RID: 1236
	[Token(Token = "0x20004D4")]
	[ProtoContract]
	public class ManualWeaponRewardUpdateInfo
	{
		// Token: 0x06001EEE RID: 7918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEE")]
		[Address(RVA = "0x24A4868", Offset = "0x24A4868", VA = "0x7BBCCA4868")]
		public ManualWeaponRewardUpdateInfo()
		{
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000480")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156D80", Offset = "0x1156D80")]
		public uint quantity_period
		{
			[Token(Token = "0x6001EEF")]
			[Address(RVA = "0x24A4870", Offset = "0x24A4870", VA = "0x7BBCCA4870")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11373E4", Offset = "0x11373E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001EF0")]
			[Address(RVA = "0x24A4878", Offset = "0x24A4878", VA = "0x7BBCCA4878")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11373F4", Offset = "0x11373F4")]
			set
			{
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000481")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156D94", Offset = "0x1156D94")]
		public uint state
		{
			[Token(Token = "0x6001EF1")]
			[Address(RVA = "0x24A4880", Offset = "0x24A4880", VA = "0x7BBCCA4880")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137404", Offset = "0x1137404")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001EF2")]
			[Address(RVA = "0x24A4888", Offset = "0x24A4888", VA = "0x7BBCCA4888")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137414", Offset = "0x1137414")]
			set
			{
			}
		}

		// Token: 0x040016CF RID: 5839
		[Token(Token = "0x40016CF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102FB4", Offset = "0x1102FB4")]
		private uint <quantity_period>k__BackingField;

		// Token: 0x040016D0 RID: 5840
		[Token(Token = "0x40016D0")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102FC4", Offset = "0x1102FC4")]
		private uint <state>k__BackingField;
	}
}
