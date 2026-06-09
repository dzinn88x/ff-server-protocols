using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001EE2 RID: 7906
	[Token(Token = "0x2001EE2")]
	internal class UIModelInvitation : UIBaseModel
	{
		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x0600ADBF RID: 44479 RVA: 0x000302B8 File Offset: 0x0002E4B8
		// (set) Token: 0x0600ADBE RID: 44478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B78")]
		public bool IsBlockAllInvitation
		{
			[Token(Token = "0x600ADBF")]
			[Address(RVA = "0x2376FB0", Offset = "0x2376FB0", VA = "0x7BBCB76FB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11465BC", Offset = "0x11465BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600ADBE")]
			[Address(RVA = "0x2376FA4", Offset = "0x2376FA4", VA = "0x7BBCB76FA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11465AC", Offset = "0x11465AC")]
			private set
			{
			}
		}

		// Token: 0x0600ADC0 RID: 44480 RVA: 0x000302D0 File Offset: 0x0002E4D0
		[Token(Token = "0x600ADC0")]
		[Address(RVA = "0x2376FB8", Offset = "0x2376FB8", VA = "0x7BBCB76FB8", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600ADC1 RID: 44481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADC1")]
		[Address(RVA = "0x2376FC0", Offset = "0x2376FC0", VA = "0x7BBCB76FC0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600ADC2 RID: 44482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADC2")]
		[Address(RVA = "0x2376FC8", Offset = "0x2376FC8", VA = "0x7BBCB76FC8", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600ADC3 RID: 44483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADC3")]
		[Address(RVA = "0x2376FF8", Offset = "0x2376FF8", VA = "0x7BBCB76FF8")]
		public void ClearData()
		{
		}

		// Token: 0x0600ADC4 RID: 44484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADC4")]
		[Address(RVA = "0x2377058", Offset = "0x2377058", VA = "0x7BBCB77058")]
		public void AddInvitationData(object[] args)
		{
		}

		// Token: 0x0600ADC5 RID: 44485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADC5")]
		[Address(RVA = "0x2377188", Offset = "0x2377188", VA = "0x7BBCB77188")]
		public void AddIgnorePlayer(ulong accountId)
		{
		}

		// Token: 0x0600ADC6 RID: 44486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADC6")]
		[Address(RVA = "0x23772B0", Offset = "0x23772B0", VA = "0x7BBCB772B0")]
		public void RemoveIgnorePlayer(ulong accountId)
		{
		}

		// Token: 0x0600ADC7 RID: 44487 RVA: 0x000302E8 File Offset: 0x0002E4E8
		[Token(Token = "0x600ADC7")]
		[Address(RVA = "0x237735C", Offset = "0x237735C", VA = "0x7BBCB7735C")]
		public bool CheckIsInIgnoreList(ulong accountId)
		{
			return default(bool);
		}

		// Token: 0x0600ADC8 RID: 44488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADC8")]
		[Address(RVA = "0x2377444", Offset = "0x2377444", VA = "0x7BBCB77444")]
		public void StartBlockAll()
		{
		}

		// Token: 0x0600ADC9 RID: 44489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADC9")]
		[Address(RVA = "0x2377450", Offset = "0x2377450", VA = "0x7BBCB77450")]
		public void CancelBlockAll()
		{
		}

		// Token: 0x0600ADCA RID: 44490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADCA")]
		[Address(RVA = "0x2377458", Offset = "0x2377458", VA = "0x7BBCB77458")]
		public UIModelInvitation()
		{
		}

		// Token: 0x0400B1D3 RID: 45523
		[Token(Token = "0x400B1D3")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ulong, ulong> m_IgnorePlayerDict;

		// Token: 0x0400B1D4 RID: 45524
		[Token(Token = "0x400B1D4")]
		[FieldOffset(Offset = "0x20")]
		public Queue<object[]> InvitationDataQueue;

		// Token: 0x0400B1D5 RID: 45525
		[Token(Token = "0x400B1D5")]
		[FieldOffset(Offset = "0x28")]
		public Queue<ulong> InvitationTimeQueue;

		// Token: 0x0400B1D6 RID: 45526
		[Token(Token = "0x400B1D6")]
		[FieldOffset(Offset = "0x30")]
		public Queue<ulong> InvitationIDQueue;

		// Token: 0x0400B1D7 RID: 45527
		[Token(Token = "0x400B1D7")]
		[FieldOffset(Offset = "0x38")]
		private ulong m_InvitationID;

		// Token: 0x0400B1D8 RID: 45528
		[Token(Token = "0x400B1D8")]
		[FieldOffset(Offset = "0x40")]
		public ulong NowTopInvitationID;

		// Token: 0x0400B1D9 RID: 45529
		[Token(Token = "0x400B1D9")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11300FC", Offset = "0x11300FC")]
		private bool <IsBlockAllInvitation>k__BackingField;
	}
}
