using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW
{
	// Token: 0x020020A4 RID: 8356
	[Token(Token = "0x20020A4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FDCF4", Offset = "0x10FDCF4")]
	internal class UIInvitationTipsBoxContentController : UIBaseController
	{
		// Token: 0x0600BBFE RID: 48126 RVA: 0x000352E0 File Offset: 0x000334E0
		[Token(Token = "0x600BBFE")]
		[Address(RVA = "0x1919F38", Offset = "0x1919F38", VA = "0x7BBC119F38")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600BBFF RID: 48127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBFF")]
		[Address(RVA = "0x1919F88", Offset = "0x1919F88", VA = "0x7BBC119F88", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600BC00 RID: 48128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC00")]
		[Address(RVA = "0x191A4B4", Offset = "0x191A4B4", VA = "0x7BBC11A4B4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600BC01 RID: 48129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC01")]
		[Address(RVA = "0x191A5DC", Offset = "0x191A5DC", VA = "0x7BBC11A5DC")]
		private void Update()
		{
		}

		// Token: 0x0600BC02 RID: 48130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BC02")]
		[Address(RVA = "0x191A87C", Offset = "0x191A87C", VA = "0x7BBC11A87C")]
		public object GetData()
		{
			return null;
		}

		// Token: 0x0600BC03 RID: 48131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC03")]
		[Address(RVA = "0x191A884", Offset = "0x191A884", VA = "0x7BBC11A884")]
		public void UpdateRank(int rank, float rankPoint, bool enableLabel2 = false)
		{
		}

		// Token: 0x0600BC04 RID: 48132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC04")]
		[Address(RVA = "0x191AF14", Offset = "0x191AF14", VA = "0x7BBC11AF14")]
		private void OnChangeBlockPlayer()
		{
		}

		// Token: 0x0600BC05 RID: 48133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC05")]
		[Address(RVA = "0x191B3FC", Offset = "0x191B3FC", VA = "0x7BBC11B3FC")]
		private void BeforeSetData()
		{
		}

		// Token: 0x0600BC06 RID: 48134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC06")]
		[Address(RVA = "0x191B4A4", Offset = "0x191B4A4", VA = "0x7BBC11B4A4")]
		public void SetData(object[] args, ulong time, bool isFirst, ulong invitationID)
		{
		}

		// Token: 0x0600BC07 RID: 48135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC07")]
		[Address(RVA = "0x191BEF8", Offset = "0x191BEF8", VA = "0x7BBC11BEF8")]
		public void SetUIData(GroupInviteNtf inviteNtfData, [Optional] Action callback)
		{
		}

		// Token: 0x0600BC08 RID: 48136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC08")]
		[Address(RVA = "0x191C718", Offset = "0x191C718", VA = "0x7BBC11C718")]
		public void SetUIData(RoomInviteNtf inviteNtfData, [Optional] Action callback)
		{
		}

		// Token: 0x0600BC09 RID: 48137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC09")]
		[Address(RVA = "0x191CD08", Offset = "0x191CD08", VA = "0x7BBC11CD08")]
		public void SetUIData(FriendAccountInfo inviteNtfData)
		{
		}

		// Token: 0x0600BC0A RID: 48138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC0A")]
		[Address(RVA = "0x191D30C", Offset = "0x191D30C", VA = "0x7BBC11D30C")]
		public void SetUIData(RecommendFriendInfo recommendFriend)
		{
		}

		// Token: 0x0600BC0B RID: 48139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC0B")]
		[Address(RVA = "0x191C9D8", Offset = "0x191C9D8", VA = "0x7BBC11C9D8")]
		public void SetUIData(GroupJoinRequestNtf inviteNtfData, [Optional] Action callback)
		{
		}

		// Token: 0x0600BC0C RID: 48140 RVA: 0x000352F8 File Offset: 0x000334F8
		[Token(Token = "0x600BC0C")]
		[Address(RVA = "0x191D8BC", Offset = "0x191D8BC", VA = "0x7BBC11D8BC")]
		public proto.EPresence.AccountPresence GetPresence()
		{
			return proto.EPresence.AccountPresence.AccountPresence_NONE;
		}

		// Token: 0x0600BC0D RID: 48141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC0D")]
		[Address(RVA = "0x191D0C0", Offset = "0x191D0C0", VA = "0x7BBC11D0C0")]
		public void SetReservationUIData(FriendAccountInfo inviteInfo)
		{
		}

		// Token: 0x0600BC0E RID: 48142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC0E")]
		[Address(RVA = "0x191D950", Offset = "0x191D950", VA = "0x7BBC11D950")]
		private void RefuseInvite()
		{
		}

		// Token: 0x0600BC0F RID: 48143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC0F")]
		[Address(RVA = "0x191D654", Offset = "0x191D654", VA = "0x7BBC11D654")]
		private void AfterSetData()
		{
		}

		// Token: 0x0600BC10 RID: 48144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BC10")]
		[Address(RVA = "0x191DC84", Offset = "0x191DC84", VA = "0x7BBC11DC84")]
		private string GetTimeString()
		{
			return null;
		}

		// Token: 0x0600BC11 RID: 48145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC11")]
		[Address(RVA = "0x191DD98", Offset = "0x191DD98", VA = "0x7BBC11DD98")]
		private void OnClickName()
		{
		}

		// Token: 0x0600BC12 RID: 48146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC12")]
		[Address(RVA = "0x191DEF8", Offset = "0x191DEF8", VA = "0x7BBC11DEF8")]
		private void OnClickOK()
		{
		}

		// Token: 0x0600BC13 RID: 48147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC13")]
		[Address(RVA = "0x191DF28", Offset = "0x191DF28", VA = "0x7BBC11DF28")]
		private void OnClickCancel()
		{
		}

		// Token: 0x0600BC14 RID: 48148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC14")]
		[Address(RVA = "0x191A730", Offset = "0x191A730", VA = "0x7BBC11A730")]
		public void OnTipsBoxClose()
		{
		}

		// Token: 0x0600BC15 RID: 48149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC15")]
		[Address(RVA = "0x191DF58", Offset = "0x191DF58", VA = "0x7BBC11DF58")]
		private void OnClickToggle()
		{
		}

		// Token: 0x0600BC16 RID: 48150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC16")]
		[Address(RVA = "0x191DF6C", Offset = "0x191DF6C", VA = "0x7BBC11DF6C")]
		private void AnimEvtHandler(params object[] data)
		{
		}

		// Token: 0x0600BC17 RID: 48151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC17")]
		[Address(RVA = "0x191E368", Offset = "0x191E368", VA = "0x7BBC11E368")]
		public void SetContentDepth(int depth)
		{
		}

		// Token: 0x0600BC18 RID: 48152 RVA: 0x00035310 File Offset: 0x00033510
		[Token(Token = "0x600BC18")]
		[Address(RVA = "0x191DD24", Offset = "0x191DD24", VA = "0x7BBC11DD24")]
		private int GetCurrentExpireLeftSeconds()
		{
			return 0;
		}

		// Token: 0x0600BC19 RID: 48153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC19")]
		[Address(RVA = "0x191E3B0", Offset = "0x191E3B0", VA = "0x7BBC11E3B0")]
		public void PlayUpAni()
		{
		}

		// Token: 0x0600BC1A RID: 48154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC1A")]
		[Address(RVA = "0x191E424", Offset = "0x191E424", VA = "0x7BBC11E424")]
		public UIInvitationTipsBoxContentController()
		{
		}

		// Token: 0x0600BC1B RID: 48155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC1B")]
		[Address(RVA = "0x191E48C", Offset = "0x191E48C", VA = "0x7BBC11E48C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147D74", Offset = "0x1147D74")]
		private void <SetUIData>b__35_0()
		{
		}

		// Token: 0x0600BC1C RID: 48156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC1C")]
		[Address(RVA = "0x191E794", Offset = "0x191E794", VA = "0x7BBC11E794")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147D84", Offset = "0x1147D84")]
		private void <SetUIData>b__35_1()
		{
		}

		// Token: 0x0600BC1D RID: 48157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC1D")]
		[Address(RVA = "0x191EA9C", Offset = "0x191EA9C", VA = "0x7BBC11EA9C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147D94", Offset = "0x1147D94")]
		private void <SetUIData>b__35_2()
		{
		}

		// Token: 0x0600BC1E RID: 48158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC1E")]
		[Address(RVA = "0x191ED60", Offset = "0x191ED60", VA = "0x7BBC11ED60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147DA4", Offset = "0x1147DA4")]
		private void <AfterSetData>b__43_0()
		{
		}

		// Token: 0x0400BCAA RID: 48298
		[Token(Token = "0x400BCAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UIInvitationTipsBoxContentView m_View;

		// Token: 0x0400BCAB RID: 48299
		[Token(Token = "0x400BCAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UIModelGroup m_ModelGroup;

		// Token: 0x0400BCAC RID: 48300
		[Token(Token = "0x400BCAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UIModelCustomRoom m_ModelCustomRoom;

		// Token: 0x0400BCAD RID: 48301
		[Token(Token = "0x400BCAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UIModelInvitation m_ModelInvitation;

		// Token: 0x0400BCAE RID: 48302
		[Token(Token = "0x400BCAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Action m_OnOK;

		// Token: 0x0400BCAF RID: 48303
		[Token(Token = "0x400BCAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Action m_OnCancel;

		// Token: 0x0400BCB0 RID: 48304
		[Token(Token = "0x400BCB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Action m_OnToggle;

		// Token: 0x0400BCB1 RID: 48305
		[Token(Token = "0x400BCB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Action m_OnExpired;

		// Token: 0x0400BCB2 RID: 48306
		[Token(Token = "0x400BCB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ulong m_InviterAccountID;

		// Token: 0x0400BCB3 RID: 48307
		[Token(Token = "0x400BCB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private object m_Data;

		// Token: 0x0400BCB4 RID: 48308
		[Token(Token = "0x400BCB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ulong m_InvitationExpiredCallID;

		// Token: 0x0400BCB5 RID: 48309
		[Token(Token = "0x400BCB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ulong m_CurrentExpireTimeStamp;

		// Token: 0x0400BCB6 RID: 48310
		[Token(Token = "0x400BCB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool ShouldOut;

		// Token: 0x0400BCB7 RID: 48311
		[Token(Token = "0x400BCB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		public bool IsInAni;

		// Token: 0x0400BCB8 RID: 48312
		[Token(Token = "0x400BCB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		public bool ShouldUp;

		// Token: 0x0400BCB9 RID: 48313
		[Token(Token = "0x400BCB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ulong InvitationID;

		// Token: 0x0400BCBA RID: 48314
		[Token(Token = "0x400BCBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float m_TimeStart;

		// Token: 0x0400BCBB RID: 48315
		[Token(Token = "0x400BCBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ulong m_AccountID;

		// Token: 0x0400BCBC RID: 48316
		[Token(Token = "0x400BCBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private string m_NickName;

		// Token: 0x0400BCBD RID: 48317
		[Token(Token = "0x400BCBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int m_Rank;

		// Token: 0x0400BCBE RID: 48318
		[Token(Token = "0x400BCBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float m_RankPoints;

		// Token: 0x0400BCBF RID: 48319
		[Token(Token = "0x400BCBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool m_HasExpired;

		// Token: 0x0400BCC0 RID: 48320
		[Token(Token = "0x400BCC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NotifyData m_NotifyData;

		// Token: 0x0400BCC1 RID: 48321
		[Token(Token = "0x400BCC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private FriendAccountInfo m_FriendInfo;

		// Token: 0x0400BCC2 RID: 48322
		[Token(Token = "0x400BCC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool m_SentInvite;

		// Token: 0x020020A5 RID: 8357
		[Token(Token = "0x20020A5")]
		private enum NotifyIDType
		{
			// Token: 0x0400BCC4 RID: 48324
			[Token(Token = "0x400BCC4")]
			GroupInvite = 1,
			// Token: 0x0400BCC5 RID: 48325
			[Token(Token = "0x400BCC5")]
			GroupJoin,
			// Token: 0x0400BCC6 RID: 48326
			[Token(Token = "0x400BCC6")]
			FriendRequese,
			// Token: 0x0400BCC7 RID: 48327
			[Token(Token = "0x400BCC7")]
			FriendRecommed,
			// Token: 0x0400BCC8 RID: 48328
			[Token(Token = "0x400BCC8")]
			TeamReservation,
			// Token: 0x0400BCC9 RID: 48329
			[Token(Token = "0x400BCC9")]
			RoomInvite
		}

		// Token: 0x020020A6 RID: 8358
		[Token(Token = "0x20020A6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDD2C", Offset = "0x10FDD2C")]
		private sealed class <>c__DisplayClass33_0
		{
			// Token: 0x0600BC1F RID: 48159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC1F")]
			[Address(RVA = "0x191D64C", Offset = "0x191D64C", VA = "0x7BBC11D64C")]
			public <>c__DisplayClass33_0()
			{
			}

			// Token: 0x0600BC20 RID: 48160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC20")]
			[Address(RVA = "0x191EEF8", Offset = "0x191EEF8", VA = "0x7BBC11EEF8")]
			internal void <SetUIData>b__0()
			{
			}

			// Token: 0x0600BC21 RID: 48161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC21")]
			[Address(RVA = "0x191F15C", Offset = "0x191F15C", VA = "0x7BBC11F15C")]
			internal void <SetUIData>b__1()
			{
			}

			// Token: 0x0400BCCA RID: 48330
			[Token(Token = "0x400BCCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIInvitationTipsBoxContentController <>4__this;

			// Token: 0x0400BCCB RID: 48331
			[Token(Token = "0x400BCCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GroupInviteNtf inviteNtfData;
		}

		// Token: 0x020020A7 RID: 8359
		[Token(Token = "0x20020A7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDD3C", Offset = "0x10FDD3C")]
		private sealed class <>c__DisplayClass34_0
		{
			// Token: 0x0600BC22 RID: 48162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC22")]
			[Address(RVA = "0x191D8A4", Offset = "0x191D8A4", VA = "0x7BBC11D8A4")]
			public <>c__DisplayClass34_0()
			{
			}

			// Token: 0x0600BC23 RID: 48163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC23")]
			[Address(RVA = "0x191F4CC", Offset = "0x191F4CC", VA = "0x7BBC11F4CC")]
			internal void <SetUIData>b__0()
			{
			}

			// Token: 0x0600BC24 RID: 48164 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC24")]
			[Address(RVA = "0x191F694", Offset = "0x191F694", VA = "0x7BBC11F694")]
			internal void <SetUIData>b__1()
			{
			}

			// Token: 0x0400BCCC RID: 48332
			[Token(Token = "0x400BCCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIInvitationTipsBoxContentController <>4__this;

			// Token: 0x0400BCCD RID: 48333
			[Token(Token = "0x400BCCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RoomInviteNtf inviteNtfData;
		}

		// Token: 0x020020A8 RID: 8360
		[Token(Token = "0x20020A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDD4C", Offset = "0x10FDD4C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600BC26 RID: 48166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC26")]
			[Address(RVA = "0x191EE18", Offset = "0x191EE18", VA = "0x7BBC11EE18")]
			public <>c()
			{
			}

			// Token: 0x0600BC27 RID: 48167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC27")]
			[Address(RVA = "0x191EE20", Offset = "0x191EE20", VA = "0x7BBC11EE20")]
			internal void <SetUIData>b__35_3()
			{
			}

			// Token: 0x0400BCCE RID: 48334
			[Token(Token = "0x400BCCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIInvitationTipsBoxContentController.<>c <>9;

			// Token: 0x0400BCCF RID: 48335
			[Token(Token = "0x400BCCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__35_3;
		}

		// Token: 0x020020A9 RID: 8361
		[Token(Token = "0x20020A9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDD5C", Offset = "0x10FDD5C")]
		private sealed class <>c__DisplayClass36_0
		{
			// Token: 0x0600BC28 RID: 48168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC28")]
			[Address(RVA = "0x191D8AC", Offset = "0x191D8AC", VA = "0x7BBC11D8AC")]
			public <>c__DisplayClass36_0()
			{
			}

			// Token: 0x0600BC29 RID: 48169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC29")]
			[Address(RVA = "0x191F884", Offset = "0x191F884", VA = "0x7BBC11F884")]
			internal void <SetUIData>b__0()
			{
			}

			// Token: 0x0600BC2A RID: 48170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC2A")]
			[Address(RVA = "0x191FB4C", Offset = "0x191FB4C", VA = "0x7BBC11FB4C")]
			internal void <SetUIData>b__1()
			{
			}

			// Token: 0x0600BC2B RID: 48171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC2B")]
			[Address(RVA = "0x191FBBC", Offset = "0x191FBBC", VA = "0x7BBC11FBBC")]
			internal void <SetUIData>b__2()
			{
			}

			// Token: 0x0600BC2C RID: 48172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC2C")]
			[Address(RVA = "0x191FD30", Offset = "0x191FD30", VA = "0x7BBC11FD30")]
			internal void <SetUIData>b__3()
			{
			}

			// Token: 0x0400BCD0 RID: 48336
			[Token(Token = "0x400BCD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIInvitationTipsBoxContentController <>4__this;

			// Token: 0x0400BCD1 RID: 48337
			[Token(Token = "0x400BCD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RecommendFriendInfo recommendFriend;
		}

		// Token: 0x020020AA RID: 8362
		[Token(Token = "0x20020AA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDD6C", Offset = "0x10FDD6C")]
		private sealed class <>c__DisplayClass37_0
		{
			// Token: 0x0600BC2D RID: 48173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC2D")]
			[Address(RVA = "0x191D8B4", Offset = "0x191D8B4", VA = "0x7BBC11D8B4")]
			public <>c__DisplayClass37_0()
			{
			}

			// Token: 0x0600BC2E RID: 48174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC2E")]
			[Address(RVA = "0x191FDA0", Offset = "0x191FDA0", VA = "0x7BBC11FDA0")]
			internal void <SetUIData>b__0()
			{
			}

			// Token: 0x0600BC2F RID: 48175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC2F")]
			[Address(RVA = "0x191FE94", Offset = "0x191FE94", VA = "0x7BBC11FE94")]
			internal void <SetUIData>b__1()
			{
			}

			// Token: 0x0400BCD2 RID: 48338
			[Token(Token = "0x400BCD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GroupInfo groupInfo;

			// Token: 0x0400BCD3 RID: 48339
			[Token(Token = "0x400BCD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GroupJoinRequestNtf inviteNtfData;

			// Token: 0x0400BCD4 RID: 48340
			[Token(Token = "0x400BCD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIInvitationTipsBoxContentController <>4__this;
		}

		// Token: 0x020020AB RID: 8363
		[Token(Token = "0x20020AB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDD7C", Offset = "0x10FDD7C")]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x0600BC30 RID: 48176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC30")]
			[Address(RVA = "0x191D948", Offset = "0x191D948", VA = "0x7BBC11D948")]
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x0600BC31 RID: 48177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC31")]
			[Address(RVA = "0x1920128", Offset = "0x1920128", VA = "0x7BBC120128")]
			internal void <SetReservationUIData>b__0()
			{
			}

			// Token: 0x0600BC32 RID: 48178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BC32")]
			[Address(RVA = "0x1920E28", Offset = "0x1920E28", VA = "0x7BBC120E28")]
			internal void <SetReservationUIData>b__1()
			{
			}

			// Token: 0x0400BCD5 RID: 48341
			[Token(Token = "0x400BCD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIInvitationTipsBoxContentController <>4__this;

			// Token: 0x0400BCD6 RID: 48342
			[Token(Token = "0x400BCD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public proto.EPresence.AccountPresence presence;
		}
	}
}
