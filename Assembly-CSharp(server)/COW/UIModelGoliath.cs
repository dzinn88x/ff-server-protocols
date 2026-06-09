using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001EBD RID: 7869
	[Token(Token = "0x2001EBD")]
	public class UIModelGoliath : UIBaseModel, IBigEventModel
	{
		// Token: 0x0600AC90 RID: 44176 RVA: 0x0002FA18 File Offset: 0x0002DC18
		[Token(Token = "0x600AC90")]
		[Address(RVA = "0x23242A0", Offset = "0x23242A0", VA = "0x7BBCB242A0", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600AC91 RID: 44177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC91")]
		[Address(RVA = "0x23242A8", Offset = "0x23242A8", VA = "0x7BBCB242A8", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600AC92 RID: 44178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC92")]
		[Address(RVA = "0x23243C4", Offset = "0x23243C4", VA = "0x7BBCB243C4", Slot = "12")]
		protected override void OnSceneChange(params object[] data)
		{
		}

		// Token: 0x0600AC93 RID: 44179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC93")]
		[Address(RVA = "0x23244A0", Offset = "0x23244A0", VA = "0x7BBCB244A0")]
		public void StartMsgSender()
		{
		}

		// Token: 0x0600AC94 RID: 44180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC94")]
		[Address(RVA = "0x232457C", Offset = "0x232457C", VA = "0x7BBCB2457C", Slot = "14")]
		public void OnProcessEventOpenInfo()
		{
		}

		// Token: 0x0600AC95 RID: 44181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC95")]
		[Address(RVA = "0x232462C", Offset = "0x232462C", VA = "0x7BBCB2462C")]
		public void RequestGoliathSetting()
		{
		}

		// Token: 0x0600AC96 RID: 44182 RVA: 0x0002FA30 File Offset: 0x0002DC30
		[Token(Token = "0x600AC96")]
		[Address(RVA = "0x23247D8", Offset = "0x23247D8", VA = "0x7BBCB247D8")]
		public uint GetTokenID()
		{
			return 0U;
		}

		// Token: 0x0600AC97 RID: 44183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC97")]
		[Address(RVA = "0x23247F0", Offset = "0x23247F0", VA = "0x7BBCB247F0")]
		public string GetWebUrl()
		{
			return null;
		}

		// Token: 0x0600AC98 RID: 44184 RVA: 0x0002FA48 File Offset: 0x0002DC48
		[Token(Token = "0x600AC98")]
		[Address(RVA = "0x2324854", Offset = "0x2324854", VA = "0x7BBCB24854")]
		public bool IsWebOpen()
		{
			return default(bool);
		}

		// Token: 0x0600AC99 RID: 44185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC99")]
		[Address(RVA = "0x2324934", Offset = "0x2324934", VA = "0x7BBCB24934")]
		public GoliathAFKTaskDesc GetAFKTaskDescByID(uint taskID)
		{
			return null;
		}

		// Token: 0x0600AC9A RID: 44186 RVA: 0x0002FA60 File Offset: 0x0002DC60
		[Token(Token = "0x600AC9A")]
		[Address(RVA = "0x23249A8", Offset = "0x23249A8", VA = "0x7BBCB249A8")]
		public uint GetTokenCount()
		{
			return 0U;
		}

		// Token: 0x0600AC9B RID: 44187 RVA: 0x0002FA78 File Offset: 0x0002DC78
		[Token(Token = "0x600AC9B")]
		[Address(RVA = "0x2324A84", Offset = "0x2324A84", VA = "0x7BBCB24A84")]
		public ResourceID GetTokenIconRes()
		{
			return default(ResourceID);
		}

		// Token: 0x0600AC9C RID: 44188 RVA: 0x0002FA90 File Offset: 0x0002DC90
		[Token(Token = "0x600AC9C")]
		[Address(RVA = "0x2324B68", Offset = "0x2324B68", VA = "0x7BBCB24B68")]
		public uint GetAFKGroupBonusPercent(int memberCnt)
		{
			return 0U;
		}

		// Token: 0x0600AC9D RID: 44189 RVA: 0x0002FAA8 File Offset: 0x0002DCA8
		[Token(Token = "0x600AC9D")]
		[Address(RVA = "0x2324BA8", Offset = "0x2324BA8", VA = "0x7BBCB24BA8")]
		public ulong GetNextFinishedAFKGroupTime()
		{
			return 0UL;
		}

		// Token: 0x0600AC9E RID: 44190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC9E")]
		[Address(RVA = "0x2324E50", Offset = "0x2324E50", VA = "0x7BBCB24E50")]
		public void CacheGroupReceivedInvitation(FastBigEventMsg msg)
		{
		}

		// Token: 0x0600AC9F RID: 44191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC9F")]
		[Address(RVA = "0x2325078", Offset = "0x2325078", VA = "0x7BBCB25078")]
		public void ClearInvalidInvitation(ulong groupID)
		{
		}

		// Token: 0x0600ACA0 RID: 44192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACA0")]
		[Address(RVA = "0x2325190", Offset = "0x2325190", VA = "0x7BBCB25190")]
		public void ClearExpiredInvitation()
		{
		}

		// Token: 0x0600ACA1 RID: 44193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ACA1")]
		[Address(RVA = "0x23252D8", Offset = "0x23252D8", VA = "0x7BBCB252D8")]
		public List<FastBigEventMsg> GetGroupReceivedInvitation()
		{
			return null;
		}

		// Token: 0x0600ACA2 RID: 44194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACA2")]
		[Address(RVA = "0x2325480", Offset = "0x2325480", VA = "0x7BBCB25480")]
		public void CacheGroupInvitationToSend(ulong accountID, FastBigEventMsg msg)
		{
		}

		// Token: 0x0600ACA3 RID: 44195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACA3")]
		[Address(RVA = "0x23255C8", Offset = "0x23255C8", VA = "0x7BBCB255C8")]
		private void SendCachedGroupInvitation()
		{
		}

		// Token: 0x0600ACA4 RID: 44196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACA4")]
		[Address(RVA = "0x2325718", Offset = "0x2325718", VA = "0x7BBCB25718")]
		public UIModelGoliath()
		{
		}

		// Token: 0x0600ACA5 RID: 44197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACA5")]
		[Address(RVA = "0x2325818", Offset = "0x2325818", VA = "0x7BBCB25818")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114640C", Offset = "0x114640C")]
		private void <RequestGoliathSetting>b__17_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B11E RID: 45342
		[Token(Token = "0x400B11E")]
		[FieldOffset(Offset = "0x18")]
		private GoliathSettingDesc m_SettingDesc;

		// Token: 0x0400B11F RID: 45343
		[Token(Token = "0x400B11F")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<uint, GoliathAFKTaskDesc> m_AFKTasks;

		// Token: 0x0400B120 RID: 45344
		[Token(Token = "0x400B120")]
		[FieldOffset(Offset = "0x28")]
		private List<UIModelGoliath.MsgReceived> m_ReceivedInvitations;

		// Token: 0x0400B121 RID: 45345
		[Token(Token = "0x400B121")]
		[FieldOffset(Offset = "0x30")]
		private Queue<UIModelGoliath.MsgToSend> m_InvitationsToSend;

		// Token: 0x0400B122 RID: 45346
		[Token(Token = "0x400B122")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<ulong> m_RecipientsSet;

		// Token: 0x0400B123 RID: 45347
		[Token(Token = "0x400B123")]
		[FieldOffset(Offset = "0x40")]
		private uint m_MsgSender;

		// Token: 0x0400B124 RID: 45348
		[Token(Token = "0x400B124")]
		[FieldOffset(Offset = "0x44")]
		public uint MAX_INVITATION_CNT;

		// Token: 0x0400B125 RID: 45349
		[Token(Token = "0x400B125")]
		[FieldOffset(Offset = "0x48")]
		public uint MAX_GROUP_MEMBER_CNT;

		// Token: 0x0400B126 RID: 45350
		[Token(Token = "0x400B126")]
		[FieldOffset(Offset = "0x4C")]
		private float SEND_MSG_CD;

		// Token: 0x0400B127 RID: 45351
		[Token(Token = "0x400B127")]
		[FieldOffset(Offset = "0x50")]
		private ulong CACHE_MSG_DURATION;

		// Token: 0x02001EBE RID: 7870
		[Token(Token = "0x2001EBE")]
		private class MsgToSend
		{
			// Token: 0x0600ACA6 RID: 44198 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACA6")]
			[Address(RVA = "0x23255C0", Offset = "0x23255C0", VA = "0x7BBCB255C0")]
			public MsgToSend()
			{
			}

			// Token: 0x0400B128 RID: 45352
			[Token(Token = "0x400B128")]
			[FieldOffset(Offset = "0x10")]
			public ulong AccountID;

			// Token: 0x0400B129 RID: 45353
			[Token(Token = "0x400B129")]
			[FieldOffset(Offset = "0x18")]
			public string Msg;
		}

		// Token: 0x02001EBF RID: 7871
		[Token(Token = "0x2001EBF")]
		private class MsgReceived
		{
			// Token: 0x0600ACA7 RID: 44199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACA7")]
			[Address(RVA = "0x2325070", Offset = "0x2325070", VA = "0x7BBCB25070")]
			public MsgReceived()
			{
			}

			// Token: 0x0400B12A RID: 45354
			[Token(Token = "0x400B12A")]
			[FieldOffset(Offset = "0x10")]
			public FastBigEventMsg Msg;

			// Token: 0x0400B12B RID: 45355
			[Token(Token = "0x400B12B")]
			[FieldOffset(Offset = "0x18")]
			public ulong ReceivedTime;
		}

		// Token: 0x02001EC0 RID: 7872
		[Token(Token = "0x2001EC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCAF4", Offset = "0x10FCAF4")]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x0600ACA8 RID: 44200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACA8")]
			[Address(RVA = "0x2325068", Offset = "0x2325068", VA = "0x7BBCB25068")]
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x0600ACA9 RID: 44201 RVA: 0x0002FAC0 File Offset: 0x0002DCC0
			[Token(Token = "0x600ACA9")]
			[Address(RVA = "0x2325A44", Offset = "0x2325A44", VA = "0x7BBCB25A44")]
			internal bool <CacheGroupReceivedInvitation>b__0(UIModelGoliath.MsgReceived item)
			{
				return default(bool);
			}

			// Token: 0x0400B12C RID: 45356
			[Token(Token = "0x400B12C")]
			[FieldOffset(Offset = "0x10")]
			public FastBigEventMsg msg;
		}

		// Token: 0x02001EC1 RID: 7873
		[Token(Token = "0x2001EC1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCB04", Offset = "0x10FCB04")]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x0600ACAA RID: 44202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACAA")]
			[Address(RVA = "0x2325188", Offset = "0x2325188", VA = "0x7BBCB25188")]
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x0600ACAB RID: 44203 RVA: 0x0002FAD8 File Offset: 0x0002DCD8
			[Token(Token = "0x600ACAB")]
			[Address(RVA = "0x2325AA8", Offset = "0x2325AA8", VA = "0x7BBCB25AA8")]
			internal bool <ClearInvalidInvitation>b__0(UIModelGoliath.MsgReceived item)
			{
				return default(bool);
			}

			// Token: 0x0400B12D RID: 45357
			[Token(Token = "0x400B12D")]
			[FieldOffset(Offset = "0x10")]
			public ulong groupID;
		}
	}
}
