using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002016 RID: 8214
	[Token(Token = "0x2002016")]
	public class UIModelTeamReserve : UIBaseModel, IUIModelDataChangeObserver
	{
		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x0600B6F3 RID: 46835 RVA: 0x00034338 File Offset: 0x00032538
		// (set) Token: 0x0600B6F4 RID: 46836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C91")]
		public bool IsReservationBlocked
		{
			[Token(Token = "0x600B6F3")]
			[Address(RVA = "0x230A850", Offset = "0x230A850", VA = "0x7BBCB0A850")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B6F4")]
			[Address(RVA = "0x230A858", Offset = "0x230A858", VA = "0x7BBCB0A858")]
			set
			{
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x0600B6F5 RID: 46837 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B6F6 RID: 46838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C92")]
		public Dictionary<ulong, UIModelTeamReserve.ReserveStatus> ReserveStatusDic
		{
			[Token(Token = "0x600B6F5")]
			[Address(RVA = "0x230A864", Offset = "0x230A864", VA = "0x7BBCB0A864")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B6F6")]
			[Address(RVA = "0x230A86C", Offset = "0x230A86C", VA = "0x7BBCB0A86C")]
			set
			{
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x0600B6F7 RID: 46839 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B6F8 RID: 46840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C93")]
		public Dictionary<ulong, UIModelTeamReserve.ReserveReplyStatus> WaitingList
		{
			[Token(Token = "0x600B6F7")]
			[Address(RVA = "0x230A874", Offset = "0x230A874", VA = "0x7BBCB0A874")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B6F8")]
			[Address(RVA = "0x230A87C", Offset = "0x230A87C", VA = "0x7BBCB0A87C")]
			set
			{
			}
		}

		// Token: 0x0600B6F9 RID: 46841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6F9")]
		[Address(RVA = "0x230A884", Offset = "0x230A884", VA = "0x7BBCB0A884", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600B6FA RID: 46842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6FA")]
		[Address(RVA = "0x230A938", Offset = "0x230A938", VA = "0x7BBCB0A938", Slot = "11")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600B6FB RID: 46843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6FB")]
		[Address(RVA = "0x230A9AC", Offset = "0x230A9AC", VA = "0x7BBCB0A9AC")]
		private void CheckBlock()
		{
		}

		// Token: 0x0600B6FC RID: 46844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6FC")]
		[Address(RVA = "0x230AA1C", Offset = "0x230AA1C", VA = "0x7BBCB0AA1C")]
		public void UpdateStatus(ulong id)
		{
		}

		// Token: 0x0600B6FD RID: 46845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6FD")]
		[Address(RVA = "0x230AC94", Offset = "0x230AC94", VA = "0x7BBCB0AC94")]
		public void RequestReservationSend(ulong id)
		{
		}

		// Token: 0x0600B6FE RID: 46846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6FE")]
		[Address(RVA = "0x230AFE8", Offset = "0x230AFE8", VA = "0x7BBCB0AFE8")]
		public void NotifyReservationSend(ulong id)
		{
		}

		// Token: 0x0600B6FF RID: 46847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6FF")]
		[Address(RVA = "0x230B0CC", Offset = "0x230B0CC", VA = "0x7BBCB0B0CC")]
		public void NotifyReservationSend()
		{
		}

		// Token: 0x0600B700 RID: 46848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B700")]
		[Address(RVA = "0x230B6C0", Offset = "0x230B6C0", VA = "0x7BBCB0B6C0")]
		public void RequestReservationReply(ulong id, UIModelTeamReserve.ReserveReplyStatus status, UIModelTeamReserve.ReserveRejectedReason reason = UIModelTeamReserve.ReserveRejectedReason.None)
		{
		}

		// Token: 0x0600B701 RID: 46849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B701")]
		[Address(RVA = "0x230C4B4", Offset = "0x230C4B4", VA = "0x7BBCB0C4B4")]
		public void NotifyReservationReply(ulong id, bool isAccepted)
		{
		}

		// Token: 0x0600B702 RID: 46850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B702")]
		[Address(RVA = "0x230ABC4", Offset = "0x230ABC4", VA = "0x7BBCB0ABC4")]
		public FriendAccountInfo GetFriendAccountInfoById(ulong id)
		{
			return null;
		}

		// Token: 0x0600B703 RID: 46851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B703")]
		[Address(RVA = "0x230B5EC", Offset = "0x230B5EC", VA = "0x7BBCB0B5EC")]
		public void UpdateFriendList()
		{
		}

		// Token: 0x0600B704 RID: 46852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B704")]
		[Address(RVA = "0x230C568", Offset = "0x230C568", VA = "0x7BBCB0C568", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B705 RID: 46853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B705")]
		[Address(RVA = "0x230C598", Offset = "0x230C598", VA = "0x7BBCB0C598")]
		public void ClearData()
		{
		}

		// Token: 0x0600B706 RID: 46854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B706")]
		[Address(RVA = "0x230C6F8", Offset = "0x230C6F8", VA = "0x7BBCB0C6F8")]
		public void ReturnToLobby()
		{
		}

		// Token: 0x0600B707 RID: 46855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B707")]
		[Address(RVA = "0x230D080", Offset = "0x230D080", VA = "0x7BBCB0D080")]
		private void UpdateReserveReplyInfoList()
		{
		}

		// Token: 0x0600B708 RID: 46856 RVA: 0x00034350 File Offset: 0x00032550
		[Token(Token = "0x600B708")]
		[Address(RVA = "0x230D3CC", Offset = "0x230D3CC", VA = "0x7BBCB0D3CC", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B709 RID: 46857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B709")]
		[Address(RVA = "0x230D3D4", Offset = "0x230D3D4", VA = "0x7BBCB0D3D4", Slot = "14")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600B70A RID: 46858 RVA: 0x00034368 File Offset: 0x00032568
		[Token(Token = "0x600B70A")]
		[Address(RVA = "0x230D4F8", Offset = "0x230D4F8", VA = "0x7BBCB0D4F8", Slot = "15")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600B70B RID: 46859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B70B")]
		[Address(RVA = "0x230D53C", Offset = "0x230D53C", VA = "0x7BBCB0D53C")]
		public UIModelTeamReserve()
		{
		}

		// Token: 0x0400B8E2 RID: 47330
		[Token(Token = "0x400B8E2")]
		public const int PropID_UpdateReserveStatus = 1;

		// Token: 0x0400B8E3 RID: 47331
		[Token(Token = "0x400B8E3")]
		public const int PropID_UpdateReservationList = 2;

		// Token: 0x0400B8E4 RID: 47332
		[Token(Token = "0x400B8E4")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ulong, UIModelTeamReserve.ReserveStatus> m_ReserveStatusDic;

		// Token: 0x0400B8E5 RID: 47333
		[Token(Token = "0x400B8E5")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<ulong, long> m_ReserveTimeDic;

		// Token: 0x0400B8E6 RID: 47334
		[Token(Token = "0x400B8E6")]
		[FieldOffset(Offset = "0x28")]
		private bool m_ReserveFlag;

		// Token: 0x0400B8E7 RID: 47335
		[Token(Token = "0x400B8E7")]
		[FieldOffset(Offset = "0x29")]
		private bool m_AutoReject;

		// Token: 0x0400B8E8 RID: 47336
		[Token(Token = "0x400B8E8")]
		[FieldOffset(Offset = "0x2A")]
		private bool m_ReturnToLobbyFlag;

		// Token: 0x0400B8E9 RID: 47337
		[Token(Token = "0x400B8E9")]
		[FieldOffset(Offset = "0x30")]
		private List<FriendAccountInfo> m_ReserveReplyInfoList;

		// Token: 0x0400B8EA RID: 47338
		[Token(Token = "0x400B8EA")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<ulong, UIModelTeamReserve.ReserveReplyStatus> m_WaitingList;

		// Token: 0x0400B8EB RID: 47339
		[Token(Token = "0x400B8EB")]
		[FieldOffset(Offset = "0x40")]
		private List<FriendAccountInfo> m_CachedFriends;

		// Token: 0x0400B8EC RID: 47340
		[Token(Token = "0x400B8EC")]
		[FieldOffset(Offset = "0x48")]
		private bool m_SettingSwitchOn;

		// Token: 0x0400B8ED RID: 47341
		[Token(Token = "0x400B8ED")]
		[FieldOffset(Offset = "0x49")]
		private bool m_IsReservationBlocked;

		// Token: 0x0400B8EE RID: 47342
		[Token(Token = "0x400B8EE")]
		[FieldOffset(Offset = "0x4A")]
		public bool Unread;

		// Token: 0x0400B8EF RID: 47343
		[Token(Token = "0x400B8EF")]
		[FieldOffset(Offset = "0x50")]
		private List<ulong> m_NewReservationSenderIds;

		// Token: 0x0400B8F0 RID: 47344
		[Token(Token = "0x400B8F0")]
		[FieldOffset(Offset = "0x58")]
		private uint m_FriendListTimeoutDelayCallID;

		// Token: 0x02002017 RID: 8215
		[Token(Token = "0x2002017")]
		public enum ReserveStatus
		{
			// Token: 0x0400B8F2 RID: 47346
			[Token(Token = "0x400B8F2")]
			None,
			// Token: 0x0400B8F3 RID: 47347
			[Token(Token = "0x400B8F3")]
			Reserved,
			// Token: 0x0400B8F4 RID: 47348
			[Token(Token = "0x400B8F4")]
			Reserving,
			// Token: 0x0400B8F5 RID: 47349
			[Token(Token = "0x400B8F5")]
			ReserveRejected
		}

		// Token: 0x02002018 RID: 8216
		[Token(Token = "0x2002018")]
		public enum ReserveReplyStatus
		{
			// Token: 0x0400B8F7 RID: 47351
			[Token(Token = "0x400B8F7")]
			None,
			// Token: 0x0400B8F8 RID: 47352
			[Token(Token = "0x400B8F8")]
			Accepted,
			// Token: 0x0400B8F9 RID: 47353
			[Token(Token = "0x400B8F9")]
			Rejected
		}

		// Token: 0x02002019 RID: 8217
		[Token(Token = "0x2002019")]
		public enum ReserveRejectedReason
		{
			// Token: 0x0400B8FB RID: 47355
			[Token(Token = "0x400B8FB")]
			None,
			// Token: 0x0400B8FC RID: 47356
			[Token(Token = "0x400B8FC")]
			AcceptOther,
			// Token: 0x0400B8FD RID: 47357
			[Token(Token = "0x400B8FD")]
			MaxLimit,
			// Token: 0x0400B8FE RID: 47358
			[Token(Token = "0x400B8FE")]
			SettingBlock,
			// Token: 0x0400B8FF RID: 47359
			[Token(Token = "0x400B8FF")]
			TempBlock,
			// Token: 0x0400B900 RID: 47360
			[Token(Token = "0x400B900")]
			Repeated,
			// Token: 0x0400B901 RID: 47361
			[Token(Token = "0x400B901")]
			RejectAfterAll,
			// Token: 0x0400B902 RID: 47362
			[Token(Token = "0x400B902")]
			NotInGame
		}

		// Token: 0x0200201A RID: 8218
		[Token(Token = "0x200201A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD7C4", Offset = "0x10FD7C4")]
		private sealed class <>c__DisplayClass35_0
		{
			// Token: 0x0600B70C RID: 46860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B70C")]
			[Address(RVA = "0x230C560", Offset = "0x230C560", VA = "0x7BBCB0C560")]
			public <>c__DisplayClass35_0()
			{
			}

			// Token: 0x0600B70D RID: 46861 RVA: 0x00034380 File Offset: 0x00032580
			[Token(Token = "0x600B70D")]
			[Address(RVA = "0x230D68C", Offset = "0x230D68C", VA = "0x7BBCB0D68C")]
			internal bool <GetFriendAccountInfoById>b__0(FriendAccountInfo x)
			{
				return default(bool);
			}

			// Token: 0x0400B903 RID: 47363
			[Token(Token = "0x400B903")]
			[FieldOffset(Offset = "0x10")]
			public ulong id;
		}
	}
}
