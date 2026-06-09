using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200148D RID: 5261
	[Token(Token = "0x200148D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED10C", Offset = "0x10ED10C")]
	internal class UIChampionshipReviewRewardListController : UIPopupWindowController, IEasyList
	{
		// Token: 0x060058DA RID: 22746 RVA: 0x0001A2B0 File Offset: 0x000184B0
		[Token(Token = "0x60058DA")]
		[Address(RVA = "0x1ECA518", Offset = "0x1ECA518", VA = "0x7BBC6CA518")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058DB")]
		[Address(RVA = "0x1ECA568", Offset = "0x1ECA568", VA = "0x7BBC6CA568", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058DC")]
		[Address(RVA = "0x1ECA6D4", Offset = "0x1ECA6D4", VA = "0x7BBC6CA6D4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x0001A2C8 File Offset: 0x000184C8
		[Token(Token = "0x60058DD")]
		[Address(RVA = "0x1ECA710", Offset = "0x1ECA710", VA = "0x7BBC6CA710", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x060058DE RID: 22750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058DE")]
		[Address(RVA = "0x1ECA718", Offset = "0x1ECA718", VA = "0x7BBC6CA718")]
		private void OnCloseButtonClick()
		{
		}

		// Token: 0x060058DF RID: 22751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058DF")]
		[Address(RVA = "0x1ECA720", Offset = "0x1ECA720", VA = "0x7BBC6CA720")]
		public void SetChampionshipInfo(ChampionshipOpenInfoDesc championshipOpenInfo)
		{
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E0")]
		[Address(RVA = "0x1ECA778", Offset = "0x1ECA778", VA = "0x7BBC6CA778")]
		public void RefreshView()
		{
		}

		// Token: 0x060058E1 RID: 22753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E1")]
		[Address(RVA = "0x1ECA82C", Offset = "0x1ECA82C", VA = "0x7BBC6CA82C")]
		private void ReviseScrollView()
		{
		}

		// Token: 0x060058E2 RID: 22754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058E2")]
		[Address(RVA = "0x1ECA7B8", Offset = "0x1ECA7B8", VA = "0x7BBC6CA7B8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113F3D4", Offset = "0x113F3D4")]
		private IEnumerator DelayRefreshView()
		{
			return null;
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E3")]
		[Address(RVA = "0x1ECAC64", Offset = "0x1ECAC64", VA = "0x7BBC6CAC64")]
		private void RefreshChampionReward()
		{
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E4")]
		[Address(RVA = "0x1ECB09C", Offset = "0x1ECB09C", VA = "0x7BBC6CB09C", Slot = "42")]
		protected virtual void RefreshCupIcon()
		{
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058E5")]
		[Address(RVA = "0x1ECB240", Offset = "0x1ECB240", VA = "0x7BBC6CB240", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E6")]
		[Address(RVA = "0x1ECB2D4", Offset = "0x1ECB2D4", VA = "0x7BBC6CB2D4", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E7")]
		[Address(RVA = "0x1ECB304", Offset = "0x1ECB304", VA = "0x7BBC6CB304")]
		public UIChampionshipReviewRewardListController()
		{
		}

		// Token: 0x04007C9D RID: 31901
		[Token(Token = "0x4007C9D")]
		[FieldOffset(Offset = "0x98")]
		private UIChampionshipReviewRewardListView m_View;

		// Token: 0x04007C9E RID: 31902
		[Token(Token = "0x4007C9E")]
		[FieldOffset(Offset = "0xA0")]
		private ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;

		// Token: 0x04007C9F RID: 31903
		[Token(Token = "0x4007C9F")]
		[FieldOffset(Offset = "0xA8")]
		private ChampionshipSettingDesc m_ChampionshipSettingInfo;

		// Token: 0x04007CA0 RID: 31904
		[Token(Token = "0x4007CA0")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007CA1 RID: 31905
		[Token(Token = "0x4007CA1")]
		[FieldOffset(Offset = "0xB8")]
		private UIClickMask m_Mask;

		// Token: 0x0200148E RID: 5262
		[Token(Token = "0x200148E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ED144", Offset = "0x10ED144")]
		private sealed class <DelayRefreshView>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060058E8 RID: 22760 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058E8")]
			[Address(RVA = "0x1ECAC38", Offset = "0x1ECAC38", VA = "0x7BBC6CAC38")]
			[DebuggerHidden]
			public <DelayRefreshView>d__13(int <>1__state)
			{
			}

			// Token: 0x060058E9 RID: 22761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058E9")]
			[Address(RVA = "0x1ECB30C", Offset = "0x1ECB30C", VA = "0x7BBC6CB30C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060058EA RID: 22762 RVA: 0x0001A2E0 File Offset: 0x000184E0
			[Token(Token = "0x60058EA")]
			[Address(RVA = "0x1ECB310", Offset = "0x1ECB310", VA = "0x7BBC6CB310", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700089F RID: 2207
			// (get) Token: 0x060058EB RID: 22763 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700089F")]
			private object Current
			{
				[Token(Token = "0x60058EB")]
				[Address(RVA = "0x1ECB7C8", Offset = "0x1ECB7C8", VA = "0x7BBC6CB7C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060058EC RID: 22764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058EC")]
			[Address(RVA = "0x1ECB7D0", Offset = "0x1ECB7D0", VA = "0x7BBC6CB7D0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008A0 RID: 2208
			// (get) Token: 0x060058ED RID: 22765 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008A0")]
			private object Current
			{
				[Token(Token = "0x60058ED")]
				[Address(RVA = "0x1ECB838", Offset = "0x1ECB838", VA = "0x7BBC6CB838", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007CA2 RID: 31906
			[Token(Token = "0x4007CA2")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007CA3 RID: 31907
			[Token(Token = "0x4007CA3")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007CA4 RID: 31908
			[Token(Token = "0x4007CA4")]
			[FieldOffset(Offset = "0x20")]
			public UIChampionshipReviewRewardListController <>4__this;
		}
	}
}
