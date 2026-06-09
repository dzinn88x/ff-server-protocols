using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200172F RID: 5935
	[Token(Token = "0x200172F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1AAC", Offset = "0x10F1AAC")]
	internal class UICloseFriendController : UIBaseController, IUIModelDataChangeObserver, ITipsDelegate
	{
		// Token: 0x06006F0F RID: 28431 RVA: 0x0001F368 File Offset: 0x0001D568
		[Token(Token = "0x6006F0F")]
		[Address(RVA = "0x1D069B0", Offset = "0x1D069B0", VA = "0x7BBC5069B0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006F10 RID: 28432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F10")]
		[Address(RVA = "0x1D06A00", Offset = "0x1D06A00", VA = "0x7BBC506A00", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06006F11 RID: 28433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F11")]
		[Address(RVA = "0x1D06D50", Offset = "0x1D06D50", VA = "0x7BBC506D50", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006F12 RID: 28434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F12")]
		[Address(RVA = "0x1D07700", Offset = "0x1D07700", VA = "0x7BBC507700")]
		private void OnShowInviteWnd(params object[] param)
		{
		}

		// Token: 0x06006F13 RID: 28435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F13")]
		[Address(RVA = "0x1D0788C", Offset = "0x1D0788C", VA = "0x7BBC50788C")]
		private void OnClickSettingBtn()
		{
		}

		// Token: 0x06006F14 RID: 28436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F14")]
		[Address(RVA = "0x1D078E8", Offset = "0x1D078E8", VA = "0x7BBC5078E8")]
		private void OnClickAnniversaryTips()
		{
		}

		// Token: 0x06006F15 RID: 28437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F15")]
		[Address(RVA = "0x1D07A68", Offset = "0x1D07A68", VA = "0x7BBC507A68")]
		private void OnNotifyCheckboxChange()
		{
		}

		// Token: 0x06006F16 RID: 28438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F16")]
		[Address(RVA = "0x1D07B44", Offset = "0x1D07B44", VA = "0x7BBC507B44")]
		private void OnClickDescTips()
		{
		}

		// Token: 0x06006F17 RID: 28439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F17")]
		[Address(RVA = "0x1D07C00", Offset = "0x1D07C00", VA = "0x7BBC507C00")]
		private void OnClickRequestBreakBtn()
		{
		}

		// Token: 0x06006F18 RID: 28440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F18")]
		[Address(RVA = "0x1D07F2C", Offset = "0x1D07F2C", VA = "0x7BBC507F2C")]
		private void OnClickChatBtn()
		{
		}

		// Token: 0x06006F19 RID: 28441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F19")]
		[Address(RVA = "0x1D08224", Offset = "0x1D08224", VA = "0x7BBC508224")]
		private void OnClickRequestGroup()
		{
		}

		// Token: 0x06006F1A RID: 28442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F1A")]
		[Address(RVA = "0x1D08728", Offset = "0x1D08728", VA = "0x7BBC508728")]
		private void OnShowRewardWnd(params object[] param)
		{
		}

		// Token: 0x06006F1B RID: 28443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F1B")]
		[Address(RVA = "0x1D088B0", Offset = "0x1D088B0", VA = "0x7BBC5088B0")]
		private void OnChooseFriend(params object[] param)
		{
		}

		// Token: 0x06006F1C RID: 28444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F1C")]
		[Address(RVA = "0x1D08B38", Offset = "0x1D08B38", VA = "0x7BBC508B38")]
		private void OnClickCallBackBtn()
		{
		}

		// Token: 0x06006F1D RID: 28445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F1D")]
		[Address(RVA = "0x1D08C40", Offset = "0x1D08C40", VA = "0x7BBC508C40")]
		private void OnClickMaskBtn()
		{
		}

		// Token: 0x06006F1E RID: 28446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F1E")]
		[Address(RVA = "0x1D08C9C", Offset = "0x1D08C9C", VA = "0x7BBC508C9C")]
		private void OnClickMaskBtn_2()
		{
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F1F")]
		[Address(RVA = "0x1D08CF8", Offset = "0x1D08CF8", VA = "0x7BBC508CF8")]
		private void OnClickBreakRelationshipBtn()
		{
		}

		// Token: 0x06006F20 RID: 28448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F20")]
		[Address(RVA = "0x1D08E58", Offset = "0x1D08E58", VA = "0x7BBC508E58")]
		private void OnClickSendGift()
		{
		}

		// Token: 0x06006F21 RID: 28449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F21")]
		[Address(RVA = "0x1D08ED4", Offset = "0x1D08ED4", VA = "0x7BBC508ED4")]
		private void OnClickInvite()
		{
		}

		// Token: 0x06006F22 RID: 28450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F22")]
		[Address(RVA = "0x1D094BC", Offset = "0x1D094BC", VA = "0x7BBC5094BC")]
		private void OnClickSelectFriend()
		{
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F23")]
		[Address(RVA = "0x1D095A4", Offset = "0x1D095A4", VA = "0x7BBC5095A4")]
		private void OnClickInvitationList()
		{
		}

		// Token: 0x06006F24 RID: 28452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F24")]
		[Address(RVA = "0x1D09688", Offset = "0x1D09688", VA = "0x7BBC509688")]
		public void ShowContent(RelationshipInfo CurrentInfo)
		{
		}

		// Token: 0x06006F25 RID: 28453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F25")]
		[Address(RVA = "0x1D09BA8", Offset = "0x1D09BA8", VA = "0x7BBC509BA8")]
		private void RefreshStateNone()
		{
		}

		// Token: 0x06006F26 RID: 28454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F26")]
		[Address(RVA = "0x1D0A064", Offset = "0x1D0A064", VA = "0x7BBC50A064")]
		private void RefreshStateSent()
		{
		}

		// Token: 0x06006F27 RID: 28455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F27")]
		[Address(RVA = "0x1D0A5E4", Offset = "0x1D0A5E4", VA = "0x7BBC50A5E4")]
		private void RefreshStateAlreadyBe()
		{
		}

		// Token: 0x06006F28 RID: 28456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F28")]
		[Address(RVA = "0x1D0B2B8", Offset = "0x1D0B2B8", VA = "0x7BBC50B2B8")]
		private void RefreshIntimacyState()
		{
		}

		// Token: 0x06006F29 RID: 28457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F29")]
		[Address(RVA = "0x1D0AE50", Offset = "0x1D0AE50", VA = "0x7BBC50AE50")]
		private void RefreshStateWaitBroken()
		{
		}

		// Token: 0x06006F2A RID: 28458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F2A")]
		[Address(RVA = "0x1D0B5A8", Offset = "0x1D0B5A8", VA = "0x7BBC50B5A8")]
		private void RefreshRewardList(params object[] param)
		{
		}

		// Token: 0x06006F2B RID: 28459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F2B")]
		[Address(RVA = "0x1D0BBEC", Offset = "0x1D0BBEC", VA = "0x7BBC50BBEC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11413FC", Offset = "0x11413FC")]
		private IEnumerator StartProgressBarChange(float IntimacyMax)
		{
			return null;
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F2C")]
		[Address(RVA = "0x1D0BC84", Offset = "0x1D0BC84", VA = "0x7BBC50BC84")]
		private void OnReceivedIntimacyRewards(List<CommonRewardItemInfo> rewardData)
		{
		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F2D")]
		[Address(RVA = "0x1D0BE5C", Offset = "0x1D0BE5C", VA = "0x7BBC50BE5C", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006F2E RID: 28462 RVA: 0x0001F380 File Offset: 0x0001D580
		[Token(Token = "0x6006F2E")]
		[Address(RVA = "0x1D0C42C", Offset = "0x1D0C42C", VA = "0x7BBC50C42C", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006F2F RID: 28463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F2F")]
		[Address(RVA = "0x1D0C4D0", Offset = "0x1D0C4D0", VA = "0x7BBC50C4D0", Slot = "30")]
		public void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06006F30 RID: 28464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F30")]
		[Address(RVA = "0x1D0C590", Offset = "0x1D0C590", VA = "0x7BBC50C590")]
		public UICloseFriendController()
		{
		}

		// Token: 0x04008958 RID: 35160
		[Token(Token = "0x4008958")]
		public const float IntimacyAwardShowAwardPaddingX = 1.15f;

		// Token: 0x04008959 RID: 35161
		[Token(Token = "0x4008959")]
		[FieldOffset(Offset = "0x58")]
		private UICloseFriendView m_View;

		// Token: 0x0400895A RID: 35162
		[Token(Token = "0x400895A")]
		[FieldOffset(Offset = "0x60")]
		private UIModelRelationShip m_RelationshipModel;

		// Token: 0x0400895B RID: 35163
		[Token(Token = "0x400895B")]
		[FieldOffset(Offset = "0x68")]
		private FriendAccountInfo m_CurrentInviteFriend;

		// Token: 0x0400895C RID: 35164
		[Token(Token = "0x400895C")]
		[FieldOffset(Offset = "0x70")]
		private RelationshipInfo m_CurrentRelationshipInfo;

		// Token: 0x0400895D RID: 35165
		[Token(Token = "0x400895D")]
		[FieldOffset(Offset = "0x78")]
		private RelationTypeInfoData m_ConfigRelationshipData;

		// Token: 0x0400895E RID: 35166
		[Token(Token = "0x400895E")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<uint, UIRelationshipRewardItemController> m_ItemList;

		// Token: 0x0400895F RID: 35167
		[Token(Token = "0x400895F")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isDismissApplicant;

		// Token: 0x02001730 RID: 5936
		[Token(Token = "0x2001730")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F1AE4", Offset = "0x10F1AE4")]
		private sealed class <StartProgressBarChange>d__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006F31 RID: 28465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F31")]
			[Address(RVA = "0x2095400", Offset = "0x2095400", VA = "0x7BBC895400")]
			[DebuggerHidden]
			public <StartProgressBarChange>d__36(int <>1__state)
			{
			}

			// Token: 0x06006F32 RID: 28466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F32")]
			[Address(RVA = "0x209542C", Offset = "0x209542C", VA = "0x7BBC89542C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006F33 RID: 28467 RVA: 0x0001F398 File Offset: 0x0001D598
			[Token(Token = "0x6006F33")]
			[Address(RVA = "0x2095430", Offset = "0x2095430", VA = "0x7BBC895430", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700092D RID: 2349
			// (get) Token: 0x06006F34 RID: 28468 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700092D")]
			private object Current
			{
				[Token(Token = "0x6006F34")]
				[Address(RVA = "0x2095614", Offset = "0x2095614", VA = "0x7BBC895614", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006F35 RID: 28469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F35")]
			[Address(RVA = "0x209561C", Offset = "0x209561C", VA = "0x7BBC89561C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700092E RID: 2350
			// (get) Token: 0x06006F36 RID: 28470 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700092E")]
			private object Current
			{
				[Token(Token = "0x6006F36")]
				[Address(RVA = "0x2095684", Offset = "0x2095684", VA = "0x7BBC895684", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008960 RID: 35168
			[Token(Token = "0x4008960")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008961 RID: 35169
			[Token(Token = "0x4008961")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008962 RID: 35170
			[Token(Token = "0x4008962")]
			[FieldOffset(Offset = "0x20")]
			public UICloseFriendController <>4__this;

			// Token: 0x04008963 RID: 35171
			[Token(Token = "0x4008963")]
			[FieldOffset(Offset = "0x28")]
			public float IntimacyMax;

			// Token: 0x04008964 RID: 35172
			[Token(Token = "0x4008964")]
			[FieldOffset(Offset = "0x2C")]
			private float <updateTime>5__2;

			// Token: 0x04008965 RID: 35173
			[Token(Token = "0x4008965")]
			[FieldOffset(Offset = "0x30")]
			private int <oldValue>5__3;

			// Token: 0x04008966 RID: 35174
			[Token(Token = "0x4008966")]
			[FieldOffset(Offset = "0x34")]
			private uint <newValue>5__4;

			// Token: 0x04008967 RID: 35175
			[Token(Token = "0x4008967")]
			[FieldOffset(Offset = "0x38")]
			private float <currentValue>5__5;
		}

		// Token: 0x02001731 RID: 5937
		[Token(Token = "0x2001731")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F1AF4", Offset = "0x10F1AF4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006F38 RID: 28472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F38")]
			[Address(RVA = "0x2095350", Offset = "0x2095350", VA = "0x7BBC895350")]
			public <>c()
			{
			}

			// Token: 0x06006F39 RID: 28473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F39")]
			[Address(RVA = "0x2095358", Offset = "0x2095358", VA = "0x7BBC895358")]
			internal void <OnReceivedIntimacyRewards>b__37_0()
			{
			}

			// Token: 0x06006F3A RID: 28474 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006F3A")]
			[Address(RVA = "0x20953F4", Offset = "0x20953F4", VA = "0x7BBC8953F4")]
			internal CommonRewardItemInfo <OnDataChanged>b__38_0(ExchangedAward item)
			{
				return null;
			}

			// Token: 0x04008968 RID: 35176
			[Token(Token = "0x4008968")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UICloseFriendController.<>c <>9;

			// Token: 0x04008969 RID: 35177
			[Token(Token = "0x4008969")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__37_0;

			// Token: 0x0400896A RID: 35178
			[Token(Token = "0x400896A")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<ExchangedAward, CommonRewardItemInfo> <>9__38_0;
		}
	}
}
