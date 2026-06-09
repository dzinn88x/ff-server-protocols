using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200142D RID: 5165
	[Token(Token = "0x200142D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC938", Offset = "0x10EC938")]
	public class UIAvatarAwakenController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06005570 RID: 21872 RVA: 0x00019788 File Offset: 0x00017988
		[Token(Token = "0x6005570")]
		[Address(RVA = "0x1B18524", Offset = "0x1B18524", VA = "0x7BBC318524")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005571 RID: 21873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005571")]
		[Address(RVA = "0x1B18574", Offset = "0x1B18574", VA = "0x7BBC318574", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005572")]
		[Address(RVA = "0x1B18E6C", Offset = "0x1B18E6C", VA = "0x7BBC318E6C")]
		private void OnShowAwardTips()
		{
		}

		// Token: 0x06005573 RID: 21875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005573")]
		[Address(RVA = "0x1B18FF4", Offset = "0x1B18FF4", VA = "0x7BBC318FF4")]
		private void OnMoveToNextComic()
		{
		}

		// Token: 0x06005574 RID: 21876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005574")]
		[Address(RVA = "0x1B1928C", Offset = "0x1B1928C", VA = "0x7BBC31928C")]
		private void OnMoveToLastComic()
		{
		}

		// Token: 0x06005575 RID: 21877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005575")]
		[Address(RVA = "0x1B19294", Offset = "0x1B19294", VA = "0x7BBC319294")]
		private void OnRefreshBtnClick()
		{
		}

		// Token: 0x06005576 RID: 21878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005576")]
		[Address(RVA = "0x1B196E0", Offset = "0x1B196E0", VA = "0x7BBC3196E0", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06005577 RID: 21879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005577")]
		[Address(RVA = "0x1B19790", Offset = "0x1B19790", VA = "0x7BBC319790")]
		private void RefreshTaskConfirm()
		{
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005578")]
		[Address(RVA = "0x1B197D4", Offset = "0x1B197D4", VA = "0x7BBC3197D4")]
		public void SetAvatar(uint curAvatarID)
		{
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005579")]
		[Address(RVA = "0x1B19850", Offset = "0x1B19850", VA = "0x7BBC319850")]
		private void SetCDNList()
		{
		}

		// Token: 0x0600557A RID: 21882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557A")]
		[Address(RVA = "0x1B198BC", Offset = "0x1B198BC", VA = "0x7BBC3198BC")]
		private void InitStoryList()
		{
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557B")]
		[Address(RVA = "0x1B18FFC", Offset = "0x1B18FFC", VA = "0x7BBC318FFC")]
		private void MoveIndexCount(int moveCnt)
		{
		}

		// Token: 0x0600557C RID: 21884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557C")]
		[Address(RVA = "0x1B1A438", Offset = "0x1B1A438", VA = "0x7BBC31A438")]
		private void RefreshStoryList()
		{
		}

		// Token: 0x0600557D RID: 21885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557D")]
		[Address(RVA = "0x1B1A0B0", Offset = "0x1B1A0B0", VA = "0x7BBC31A0B0")]
		private void ShowCurrentComicEffect()
		{
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557E")]
		[Address(RVA = "0x1B1A880", Offset = "0x1B1A880", VA = "0x7BBC31A880")]
		private void RefreshFinishProgress()
		{
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557F")]
		[Address(RVA = "0x1B1AA8C", Offset = "0x1B1AA8C", VA = "0x7BBC31AA8C")]
		private void RefreshAwakenBtnState()
		{
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005580")]
		[Address(RVA = "0x1B1AD58", Offset = "0x1B1AD58", VA = "0x7BBC31AD58")]
		private void RefreshTaskResetBtnState()
		{
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005581")]
		[Address(RVA = "0x1B19824", Offset = "0x1B19824", VA = "0x7BBC319824")]
		private void InitUI()
		{
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005582")]
		[Address(RVA = "0x1B1B0FC", Offset = "0x1B1B0FC", VA = "0x7BBC31B0FC")]
		private void SetDescription()
		{
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005583")]
		[Address(RVA = "0x1B1B22C", Offset = "0x1B1B22C", VA = "0x7BBC31B22C")]
		private void RefreshUI()
		{
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005584")]
		[Address(RVA = "0x1B1B228", Offset = "0x1B1B228", VA = "0x7BBC31B228")]
		private void RefreshSkill()
		{
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005585")]
		[Address(RVA = "0x1B1B680", Offset = "0x1B1B680", VA = "0x7BBC31B680")]
		private void CheckLockState()
		{
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005586")]
		[Address(RVA = "0x1B1BA38", Offset = "0x1B1BA38", VA = "0x7BBC31BA38", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005587")]
		[Address(RVA = "0x1B1BA40", Offset = "0x1B1BA40", VA = "0x7BBC31BA40", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005588")]
		[Address(RVA = "0x1B1BBAC", Offset = "0x1B1BBAC", VA = "0x7BBC31BBAC")]
		private void OnGainAvatarBtnClick()
		{
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005589")]
		[Address(RVA = "0x1B1C0F8", Offset = "0x1B1C0F8", VA = "0x7BBC31C0F8")]
		private void OnAwakenDisableBtnClick()
		{
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558A")]
		[Address(RVA = "0x1B1C290", Offset = "0x1B1C290", VA = "0x7BBC31C290")]
		private void OnClaimAwakenAvatarBtnClick()
		{
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558B")]
		[Address(RVA = "0x1B1C3D4", Offset = "0x1B1C3D4", VA = "0x7BBC31C3D4")]
		private void OnUpgradeSkillBtnClick()
		{
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558C")]
		[Address(RVA = "0x1B1B270", Offset = "0x1B1B270", VA = "0x7BBC31B270")]
		private void RefreshTaskList()
		{
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x000197A0 File Offset: 0x000179A0
		[Token(Token = "0x600558D")]
		[Address(RVA = "0x1B1CABC", Offset = "0x1B1CABC", VA = "0x7BBC31CABC")]
		private int SortItem(AvatarAwakenComicData a, AvatarAwakenComicData b)
		{
			return 0;
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558E")]
		[Address(RVA = "0x1B1CB00", Offset = "0x1B1CB00", VA = "0x7BBC31CB00")]
		private void OnAwakenRewardClaim(params object[] data)
		{
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x000197B8 File Offset: 0x000179B8
		[Token(Token = "0x600558F")]
		[Address(RVA = "0x1B1CB04", Offset = "0x1B1CB04", VA = "0x7BBC31CB04", Slot = "29")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005590")]
		[Address(RVA = "0x1B1CB6C", Offset = "0x1B1CB6C", VA = "0x7BBC31CB6C", Slot = "28")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005591 RID: 21905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005591")]
		[Address(RVA = "0x1B1CEF8", Offset = "0x1B1CEF8", VA = "0x7BBC31CEF8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113E900", Offset = "0x113E900")]
		private IEnumerator ShowUnlockComicEffect(uint unlockNum)
		{
			return null;
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005592")]
		[Address(RVA = "0x1B1CFBC", Offset = "0x1B1CFBC", VA = "0x7BBC31CFBC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113E964", Offset = "0x113E964")]
		private IEnumerator ShowComicProgressAnim()
		{
			return null;
		}

		// Token: 0x06005593 RID: 21907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005593")]
		[Address(RVA = "0x1B1D05C", Offset = "0x1B1D05C", VA = "0x7BBC31D05C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113E9C8", Offset = "0x113E9C8")]
		private IEnumerator WaitForAnimationFinish(float animationTime)
		{
			return null;
		}

		// Token: 0x06005594 RID: 21908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005594")]
		[Address(RVA = "0x1B1D104", Offset = "0x1B1D104", VA = "0x7BBC31D104")]
		private void ShowTaskClaimEffect()
		{
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005595")]
		[Address(RVA = "0x1B1D3E4", Offset = "0x1B1D3E4", VA = "0x7BBC31D3E4")]
		private void ShowUnlockOnceEffect(uint unlockNum)
		{
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005596")]
		[Address(RVA = "0x1B1D62C", Offset = "0x1B1D62C", VA = "0x7BBC31D62C")]
		private void ShowComicClaimEffect(uint unlockNum)
		{
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005597")]
		[Address(RVA = "0x1B1D814", Offset = "0x1B1D814", VA = "0x7BBC31D814")]
		public UIAvatarAwakenController()
		{
		}

		// Token: 0x04007A54 RID: 31316
		[Token(Token = "0x4007A54")]
		[FieldOffset(Offset = "0x58")]
		private UIAvatarAwakenView m_View;

		// Token: 0x04007A55 RID: 31317
		[Token(Token = "0x4007A55")]
		[FieldOffset(Offset = "0x60")]
		private UIModelAvatarProfile m_Model;

		// Token: 0x04007A56 RID: 31318
		[Token(Token = "0x4007A56")]
		[FieldOffset(Offset = "0x68")]
		private AvatarProfile m_CurrentShowAvatar;

		// Token: 0x04007A57 RID: 31319
		[Token(Token = "0x4007A57")]
		[FieldOffset(Offset = "0x70")]
		private List<UIAvatarAwakenTaskItemController> m_CacheTaskItemList;

		// Token: 0x04007A58 RID: 31320
		[Token(Token = "0x4007A58")]
		[FieldOffset(Offset = "0x78")]
		private List<UIAvatarAwakenStoryItemController> m_CacheStoryItemList;

		// Token: 0x04007A59 RID: 31321
		[Token(Token = "0x4007A59")]
		[FieldOffset(Offset = "0x80")]
		private List<GameObject> m_TaskPosList;

		// Token: 0x04007A5A RID: 31322
		[Token(Token = "0x4007A5A")]
		[FieldOffset(Offset = "0x88")]
		private List<GameObject> m_TaskEffectList;

		// Token: 0x04007A5B RID: 31323
		[Token(Token = "0x4007A5B")]
		[FieldOffset(Offset = "0x90")]
		private List<GameObject> m_ComicEffectList;

		// Token: 0x04007A5C RID: 31324
		[Token(Token = "0x4007A5C")]
		[FieldOffset(Offset = "0x98")]
		private List<GameObject> m_ComicCanUnlockEffectList;

		// Token: 0x04007A5D RID: 31325
		[Token(Token = "0x4007A5D")]
		[FieldOffset(Offset = "0xA0")]
		private List<GameObject> m_ComicUnlockEffectList;

		// Token: 0x04007A5E RID: 31326
		[Token(Token = "0x4007A5E")]
		[FieldOffset(Offset = "0xA8")]
		private int ComicCntMax;

		// Token: 0x04007A5F RID: 31327
		[Token(Token = "0x4007A5F")]
		[FieldOffset(Offset = "0xAC")]
		private int m_CurrentIndex;

		// Token: 0x04007A60 RID: 31328
		[Token(Token = "0x4007A60")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_CurrentFinishTaskID;

		// Token: 0x04007A61 RID: 31329
		[Token(Token = "0x4007A61")]
		[FieldOffset(Offset = "0xB8")]
		private IEnumerator m_CurrentAnim;

		// Token: 0x0200142E RID: 5166
		[Token(Token = "0x200142E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC970", Offset = "0x10EC970")]
		private sealed class <ShowUnlockComicEffect>d__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005598 RID: 21912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005598")]
			[Address(RVA = "0x1B1CF90", Offset = "0x1B1CF90", VA = "0x7BBC31CF90")]
			[DebuggerHidden]
			public <ShowUnlockComicEffect>d__47(int <>1__state)
			{
			}

			// Token: 0x06005599 RID: 21913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005599")]
			[Address(RVA = "0x1B1DC50", Offset = "0x1B1DC50", VA = "0x7BBC31DC50", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600559A RID: 21914 RVA: 0x000197D0 File Offset: 0x000179D0
			[Token(Token = "0x600559A")]
			[Address(RVA = "0x1B1DC54", Offset = "0x1B1DC54", VA = "0x7BBC31DC54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700087C RID: 2172
			// (get) Token: 0x0600559B RID: 21915 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700087C")]
			private object Current
			{
				[Token(Token = "0x600559B")]
				[Address(RVA = "0x1B1DDA4", Offset = "0x1B1DDA4", VA = "0x7BBC31DDA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600559C RID: 21916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600559C")]
			[Address(RVA = "0x1B1DDAC", Offset = "0x1B1DDAC", VA = "0x7BBC31DDAC", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700087D RID: 2173
			// (get) Token: 0x0600559D RID: 21917 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700087D")]
			private object Current
			{
				[Token(Token = "0x600559D")]
				[Address(RVA = "0x1B1DE14", Offset = "0x1B1DE14", VA = "0x7BBC31DE14", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007A62 RID: 31330
			[Token(Token = "0x4007A62")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007A63 RID: 31331
			[Token(Token = "0x4007A63")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007A64 RID: 31332
			[Token(Token = "0x4007A64")]
			[FieldOffset(Offset = "0x20")]
			public UIAvatarAwakenController <>4__this;

			// Token: 0x04007A65 RID: 31333
			[Token(Token = "0x4007A65")]
			[FieldOffset(Offset = "0x28")]
			public uint unlockNum;

			// Token: 0x04007A66 RID: 31334
			[Token(Token = "0x4007A66")]
			[FieldOffset(Offset = "0x2C")]
			private int <CurShowIndex>5__2;
		}

		// Token: 0x0200142F RID: 5167
		[Token(Token = "0x200142F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC980", Offset = "0x10EC980")]
		private sealed class <ShowComicProgressAnim>d__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600559E RID: 21918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600559E")]
			[Address(RVA = "0x1B1D030", Offset = "0x1B1D030", VA = "0x7BBC31D030")]
			[DebuggerHidden]
			public <ShowComicProgressAnim>d__48(int <>1__state)
			{
			}

			// Token: 0x0600559F RID: 21919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600559F")]
			[Address(RVA = "0x1B1D8B4", Offset = "0x1B1D8B4", VA = "0x7BBC31D8B4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060055A0 RID: 21920 RVA: 0x000197E8 File Offset: 0x000179E8
			[Token(Token = "0x60055A0")]
			[Address(RVA = "0x1B1D8B8", Offset = "0x1B1D8B8", VA = "0x7BBC31D8B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700087E RID: 2174
			// (get) Token: 0x060055A1 RID: 21921 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700087E")]
			private object Current
			{
				[Token(Token = "0x60055A1")]
				[Address(RVA = "0x1B1DBD8", Offset = "0x1B1DBD8", VA = "0x7BBC31DBD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060055A2 RID: 21922 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60055A2")]
			[Address(RVA = "0x1B1DBE0", Offset = "0x1B1DBE0", VA = "0x7BBC31DBE0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700087F RID: 2175
			// (get) Token: 0x060055A3 RID: 21923 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700087F")]
			private object Current
			{
				[Token(Token = "0x60055A3")]
				[Address(RVA = "0x1B1DC48", Offset = "0x1B1DC48", VA = "0x7BBC31DC48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007A67 RID: 31335
			[Token(Token = "0x4007A67")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007A68 RID: 31336
			[Token(Token = "0x4007A68")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007A69 RID: 31337
			[Token(Token = "0x4007A69")]
			[FieldOffset(Offset = "0x20")]
			public UIAvatarAwakenController <>4__this;

			// Token: 0x04007A6A RID: 31338
			[Token(Token = "0x4007A6A")]
			[FieldOffset(Offset = "0x28")]
			private float <animationTime>5__2;

			// Token: 0x04007A6B RID: 31339
			[Token(Token = "0x4007A6B")]
			[FieldOffset(Offset = "0x2C")]
			private float <oldValue>5__3;

			// Token: 0x04007A6C RID: 31340
			[Token(Token = "0x4007A6C")]
			[FieldOffset(Offset = "0x30")]
			private float <newValue>5__4;
		}

		// Token: 0x02001430 RID: 5168
		[Token(Token = "0x2001430")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC990", Offset = "0x10EC990")]
		private sealed class <WaitForAnimationFinish>d__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060055A4 RID: 21924 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60055A4")]
			[Address(RVA = "0x1B1D0D8", Offset = "0x1B1D0D8", VA = "0x7BBC31D0D8")]
			[DebuggerHidden]
			public <WaitForAnimationFinish>d__49(int <>1__state)
			{
			}

			// Token: 0x060055A5 RID: 21925 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60055A5")]
			[Address(RVA = "0x1B1DE1C", Offset = "0x1B1DE1C", VA = "0x7BBC31DE1C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060055A6 RID: 21926 RVA: 0x00019800 File Offset: 0x00017A00
			[Token(Token = "0x60055A6")]
			[Address(RVA = "0x1B1DE20", Offset = "0x1B1DE20", VA = "0x7BBC31DE20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000880 RID: 2176
			// (get) Token: 0x060055A7 RID: 21927 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000880")]
			private object Current
			{
				[Token(Token = "0x60055A7")]
				[Address(RVA = "0x1B1DE88", Offset = "0x1B1DE88", VA = "0x7BBC31DE88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060055A8 RID: 21928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60055A8")]
			[Address(RVA = "0x1B1DE90", Offset = "0x1B1DE90", VA = "0x7BBC31DE90", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000881 RID: 2177
			// (get) Token: 0x060055A9 RID: 21929 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000881")]
			private object Current
			{
				[Token(Token = "0x60055A9")]
				[Address(RVA = "0x1B1DEF8", Offset = "0x1B1DEF8", VA = "0x7BBC31DEF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007A6D RID: 31341
			[Token(Token = "0x4007A6D")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007A6E RID: 31342
			[Token(Token = "0x4007A6E")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007A6F RID: 31343
			[Token(Token = "0x4007A6F")]
			[FieldOffset(Offset = "0x20")]
			public float animationTime;
		}
	}
}
