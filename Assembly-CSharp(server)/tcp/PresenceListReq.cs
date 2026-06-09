using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004F3 RID: 1267
	[Token(Token = "0x20004F3")]
	[ProtoContract]
	public class PresenceListReq
	{
		// Token: 0x06001FA8 RID: 8104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA8")]
		[Address(RVA = "0x24A5938", Offset = "0x24A5938", VA = "0x7BBCCA5938")]
		public PresenceListReq()
		{
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11577D0", Offset = "0x11577D0")]
		public ulong[] account_ids
		{
			[Token(Token = "0x6001FA9")]
			[Address(RVA = "0x24A5940", Offset = "0x24A5940", VA = "0x7BBCCA5940")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137E44", Offset = "0x1137E44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FAA")]
			[Address(RVA = "0x24A5948", Offset = "0x24A5948", VA = "0x7BBCCA5948")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137E54", Offset = "0x1137E54")]
			set
			{
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115780C", Offset = "0x115780C")]
		public uint account_list_type
		{
			[Token(Token = "0x6001FAB")]
			[Address(RVA = "0x24A5950", Offset = "0x24A5950", VA = "0x7BBCCA5950")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137E64", Offset = "0x1137E64")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001FAC")]
			[Address(RVA = "0x24A5958", Offset = "0x24A5958", VA = "0x7BBCCA5958")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137E74", Offset = "0x1137E74")]
			set
			{
			}
		}

		// Token: 0x04001769 RID: 5993
		[Token(Token = "0x4001769")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11034E4", Offset = "0x11034E4")]
		private ulong[] <account_ids>k__BackingField;

		// Token: 0x0400176A RID: 5994
		[Token(Token = "0x400176A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11034F4", Offset = "0x11034F4")]
		private uint <account_list_type>k__BackingField;
	}
}
