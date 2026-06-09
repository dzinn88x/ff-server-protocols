using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000470 RID: 1136
	[Token(Token = "0x2000470")]
	[ProtoContract]
	public class InviteToClanReq
	{
		// Token: 0x06001CA9 RID: 7337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA9")]
		[Address(RVA = "0x24A446C", Offset = "0x24A446C", VA = "0x7BBCCA446C")]
		public InviteToClanReq()
		{
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x0000C318 File Offset: 0x0000A518
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000382")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154E04", Offset = "0x1154E04")]
		public ulong inviter_id
		{
			[Token(Token = "0x6001CAA")]
			[Address(RVA = "0x24A44D8", Offset = "0x24A44D8", VA = "0x7BBCCA44D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135424", Offset = "0x1135424")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CAB")]
			[Address(RVA = "0x24A44E0", Offset = "0x24A44E0", VA = "0x7BBCCA44E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135434", Offset = "0x1135434")]
			set
			{
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x0000C330 File Offset: 0x0000A530
		// (set) Token: 0x06001CAD RID: 7341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000383")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154E18", Offset = "0x1154E18")]
		public ulong clan_id
		{
			[Token(Token = "0x6001CAC")]
			[Address(RVA = "0x24A44E8", Offset = "0x24A44E8", VA = "0x7BBCCA44E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135444", Offset = "0x1135444")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CAD")]
			[Address(RVA = "0x24A44F0", Offset = "0x24A44F0", VA = "0x7BBCCA44F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135454", Offset = "0x1135454")]
			set
			{
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000384")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1154E2C", Offset = "0x1154E2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154E2C", Offset = "0x1154E2C")]
		public string clan_name
		{
			[Token(Token = "0x6001CAE")]
			[Address(RVA = "0x24A44F8", Offset = "0x24A44F8", VA = "0x7BBCCA44F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135464", Offset = "0x1135464")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CAF")]
			[Address(RVA = "0x24A44C8", Offset = "0x24A44C8", VA = "0x7BBCCA44C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135474", Offset = "0x1135474")]
			set
			{
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000385")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154E7C", Offset = "0x1154E7C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1154E7C", Offset = "0x1154E7C")]
		public string inviter_name
		{
			[Token(Token = "0x6001CB0")]
			[Address(RVA = "0x24A4500", Offset = "0x24A4500", VA = "0x7BBCCA4500")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135484", Offset = "0x1135484")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CB1")]
			[Address(RVA = "0x24A44D0", Offset = "0x24A44D0", VA = "0x7BBCCA44D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135494", Offset = "0x1135494")]
			set
			{
			}
		}

		// Token: 0x040014FD RID: 5373
		[Token(Token = "0x40014FD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101FD4", Offset = "0x1101FD4")]
		private ulong <inviter_id>k__BackingField;

		// Token: 0x040014FE RID: 5374
		[Token(Token = "0x40014FE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101FE4", Offset = "0x1101FE4")]
		private ulong <clan_id>k__BackingField;

		// Token: 0x040014FF RID: 5375
		[Token(Token = "0x40014FF")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101FF4", Offset = "0x1101FF4")]
		private string <clan_name>k__BackingField;

		// Token: 0x04001500 RID: 5376
		[Token(Token = "0x4001500")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102004", Offset = "0x1102004")]
		private string <inviter_name>k__BackingField;
	}
}
