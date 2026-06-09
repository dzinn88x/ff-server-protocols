using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001F8A RID: 8074
	[Token(Token = "0x2001F8A")]
	public class UIModelNewPlayerUpGrade : UIBaseModel
	{
		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x0600B293 RID: 45715 RVA: 0x00032658 File Offset: 0x00030858
		// (set) Token: 0x0600B294 RID: 45716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C0B")]
		public bool IsNewPlayer
		{
			[Token(Token = "0x600B293")]
			[Address(RVA = "0x241E51C", Offset = "0x241E51C", VA = "0x7BBCC1E51C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146BEC", Offset = "0x1146BEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B294")]
			[Address(RVA = "0x241E524", Offset = "0x241E524", VA = "0x7BBCC1E524")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146BFC", Offset = "0x1146BFC")]
			private set
			{
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x0600B295 RID: 45717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C0C")]
		public List<ClientNewPlayerLevelUpTaskInfo> NewPlayerUpGradeRewardsList
		{
			[Token(Token = "0x600B295")]
			[Address(RVA = "0x241E530", Offset = "0x241E530", VA = "0x7BBCC1E530")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x0600B296 RID: 45718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C0D")]
		public ClientNewPlayerLevelUpTaskInfo CurrentCliamReward
		{
			[Token(Token = "0x600B296")]
			[Address(RVA = "0x241E538", Offset = "0x241E538", VA = "0x7BBCC1E538")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B297 RID: 45719 RVA: 0x00032670 File Offset: 0x00030870
		[Token(Token = "0x600B297")]
		[Address(RVA = "0x241E540", Offset = "0x241E540", VA = "0x7BBCC1E540", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B298 RID: 45720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B298")]
		[Address(RVA = "0x241E548", Offset = "0x241E548", VA = "0x7BBCC1E548", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B299 RID: 45721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B299")]
		[Address(RVA = "0x241E5D0", Offset = "0x241E5D0", VA = "0x7BBCC1E5D0")]
		public void ProcessNewPlayerUpGradeInfos(CSGetNewPlayerLevelUpTaskInfoRes res)
		{
		}

		// Token: 0x0600B29A RID: 45722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B29A")]
		[Address(RVA = "0x241E7E8", Offset = "0x241E7E8", VA = "0x7BBCC1E7E8", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B29B RID: 45723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B29B")]
		[Address(RVA = "0x241E864", Offset = "0x241E864", VA = "0x7BBCC1E864")]
		public void RequestNewPlayerUpGradeRewardInfo(uint httpOp = 0U)
		{
		}

		// Token: 0x0600B29C RID: 45724 RVA: 0x00032688 File Offset: 0x00030888
		[Token(Token = "0x600B29C")]
		[Address(RVA = "0x241EA7C", Offset = "0x241EA7C", VA = "0x7BBCC1EA7C")]
		public bool IsNeedRequestInfoAgain()
		{
			return default(bool);
		}

		// Token: 0x0600B29D RID: 45725 RVA: 0x000326A0 File Offset: 0x000308A0
		[Token(Token = "0x600B29D")]
		[Address(RVA = "0x241EB44", Offset = "0x241EB44", VA = "0x7BBCC1EB44")]
		public bool ExistUnClaimed()
		{
			return default(bool);
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x000326B8 File Offset: 0x000308B8
		[Token(Token = "0x600B29E")]
		[Address(RVA = "0x241ECCC", Offset = "0x241ECCC", VA = "0x7BBCC1ECCC")]
		public bool ExitNeedToCliam()
		{
			return default(bool);
		}

		// Token: 0x0600B29F RID: 45727 RVA: 0x000326D0 File Offset: 0x000308D0
		[Token(Token = "0x600B29F")]
		[Address(RVA = "0x241EE38", Offset = "0x241EE38", VA = "0x7BBCC1EE38")]
		public bool isEarlySevenDays()
		{
			return default(bool);
		}

		// Token: 0x0600B2A0 RID: 45728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2A0")]
		[Address(RVA = "0x241EF24", Offset = "0x241EF24", VA = "0x7BBCC1EF24")]
		public void RequstCliamNewPlayerUpgrade(int cliam_Index)
		{
		}

		// Token: 0x0600B2A1 RID: 45729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2A1")]
		[Address(RVA = "0x241F238", Offset = "0x241F238", VA = "0x7BBCC1F238")]
		public UIModelNewPlayerUpGrade()
		{
		}

		// Token: 0x0600B2A2 RID: 45730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2A2")]
		[Address(RVA = "0x241F2C8", Offset = "0x241F2C8", VA = "0x7BBCC1F2C8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146C0C", Offset = "0x1146C0C")]
		private void <RequestNewPlayerUpGradeRewardInfo>b__20_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B588 RID: 46472
		[Token(Token = "0x400B588")]
		public const uint PropID_NewPlayerCliamRewardLisUpdate = 2U;

		// Token: 0x0400B589 RID: 46473
		[Token(Token = "0x400B589")]
		public const uint PropID_NewPlayerGetReward = 4U;

		// Token: 0x0400B58A RID: 46474
		[Token(Token = "0x400B58A")]
		[FieldOffset(Offset = "0x18")]
		private uint m_NextUpGradeLevelTarget;

		// Token: 0x0400B58B RID: 46475
		[Token(Token = "0x400B58B")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_WaitingForReponse;

		// Token: 0x0400B58C RID: 46476
		[Token(Token = "0x400B58C")]
		[FieldOffset(Offset = "0x1D")]
		public bool FirstChangeName;

		// Token: 0x0400B58D RID: 46477
		[Token(Token = "0x400B58D")]
		[FieldOffset(Offset = "0x1E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113030C", Offset = "0x113030C")]
		private bool <IsNewPlayer>k__BackingField;

		// Token: 0x0400B58E RID: 46478
		[Token(Token = "0x400B58E")]
		[FieldOffset(Offset = "0x20")]
		private List<ClientNewPlayerLevelUpTaskInfo> m_NewPlayerUpGradeRewardsList;

		// Token: 0x0400B58F RID: 46479
		[Token(Token = "0x400B58F")]
		[FieldOffset(Offset = "0x28")]
		private ClientNewPlayerLevelUpTaskInfo m_CurrentCliamReward;

		// Token: 0x0400B590 RID: 46480
		[Token(Token = "0x400B590")]
		[FieldOffset(Offset = "0x30")]
		public bool HaveGetNewPlayerLevelUpTaskInfo;

		// Token: 0x02001F8B RID: 8075
		[Token(Token = "0x2001F8B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD384", Offset = "0x10FD384")]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x0600B2A3 RID: 45731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2A3")]
			[Address(RVA = "0x241F230", Offset = "0x241F230", VA = "0x7BBCC1F230")]
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x0600B2A4 RID: 45732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2A4")]
			[Address(RVA = "0x241F4B8", Offset = "0x241F4B8", VA = "0x7BBCC1F4B8")]
			internal void <RequstCliamNewPlayerUpgrade>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B591 RID: 46481
			[Token(Token = "0x400B591")]
			[FieldOffset(Offset = "0x10")]
			public UIModelNewPlayerUpGrade <>4__this;

			// Token: 0x0400B592 RID: 46482
			[Token(Token = "0x400B592")]
			[FieldOffset(Offset = "0x18")]
			public int cliam_Index;
		}
	}
}
