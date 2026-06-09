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
	// Token: 0x020019E0 RID: 6624
	[Token(Token = "0x20019E0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F723C", Offset = "0x10F723C")]
	public class UILevelUpController : UIPopupWindowController
	{
		// Token: 0x060088CB RID: 35019 RVA: 0x00024CD8 File Offset: 0x00022ED8
		[Token(Token = "0x60088CB")]
		[Address(RVA = "0x1CB6058", Offset = "0x1CB6058", VA = "0x7BBC4B6058")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060088CC RID: 35020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088CC")]
		[Address(RVA = "0x1CB60A8", Offset = "0x1CB60A8", VA = "0x7BBC4B60A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060088CD RID: 35021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088CD")]
		[Address(RVA = "0x1CB65AC", Offset = "0x1CB65AC", VA = "0x7BBC4B65AC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060088CE RID: 35022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088CE")]
		[Address(RVA = "0x1CB669C", Offset = "0x1CB669C", VA = "0x7BBC4B669C")]
		public void SetLevelData(uint before, uint next, List<BaseItemInfo> list)
		{
		}

		// Token: 0x060088CF RID: 35023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088CF")]
		[Address(RVA = "0x1CB6DC0", Offset = "0x1CB6DC0", VA = "0x7BBC4B6DC0")]
		private void OnBtnShowChestClick()
		{
		}

		// Token: 0x060088D0 RID: 35024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088D0")]
		[Address(RVA = "0x1CB6E40", Offset = "0x1CB6E40", VA = "0x7BBC4B6E40")]
		private void RequstToOpenChest()
		{
		}

		// Token: 0x060088D1 RID: 35025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088D1")]
		[Address(RVA = "0x1CB7010", Offset = "0x1CB7010", VA = "0x7BBC4B7010", Slot = "39")]
		public override void OnPopupWindowListChange()
		{
		}

		// Token: 0x060088D2 RID: 35026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088D2")]
		[Address(RVA = "0x1CB70E0", Offset = "0x1CB70E0", VA = "0x7BBC4B70E0")]
		private void CreateChest()
		{
		}

		// Token: 0x060088D3 RID: 35027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60088D3")]
		[Address(RVA = "0x1CB7248", Offset = "0x1CB7248", VA = "0x7BBC4B7248")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1143804", Offset = "0x1143804")]
		private IEnumerator OpenChestCoroutine()
		{
			return null;
		}

		// Token: 0x060088D4 RID: 35028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088D4")]
		[Address(RVA = "0x1CB72E8", Offset = "0x1CB72E8", VA = "0x7BBC4B72E8")]
		public void ShowChestReward()
		{
		}

		// Token: 0x060088D5 RID: 35029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088D5")]
		[Address(RVA = "0x1CB75AC", Offset = "0x1CB75AC", VA = "0x7BBC4B75AC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060088D6 RID: 35030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088D6")]
		[Address(RVA = "0x1CB76B8", Offset = "0x1CB76B8", VA = "0x7BBC4B76B8")]
		private void OnOKClick()
		{
		}

		// Token: 0x060088D7 RID: 35031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088D7")]
		[Address(RVA = "0x1CB7804", Offset = "0x1CB7804", VA = "0x7BBC4B7804")]
		private void OnReceiveAnimEvent(params object[] param)
		{
		}

		// Token: 0x060088D8 RID: 35032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088D8")]
		[Address(RVA = "0x1CB79F4", Offset = "0x1CB79F4", VA = "0x7BBC4B79F4")]
		private void OnShowRewardItemVFX()
		{
		}

		// Token: 0x060088D9 RID: 35033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088D9")]
		[Address(RVA = "0x1CB7B20", Offset = "0x1CB7B20", VA = "0x7BBC4B7B20")]
		private void OnPlayRewardAudio(string audioName)
		{
		}

		// Token: 0x060088DA RID: 35034 RVA: 0x00024CF0 File Offset: 0x00022EF0
		[Token(Token = "0x60088DA")]
		[Address(RVA = "0x1CB7C8C", Offset = "0x1CB7C8C", VA = "0x7BBC4B7C8C", Slot = "36")]
		public override bool ClosedByEsc()
		{
			return default(bool);
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088DB")]
		[Address(RVA = "0x1CB7C94", Offset = "0x1CB7C94", VA = "0x7BBC4B7C94")]
		public UILevelUpController()
		{
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088DC")]
		[Address(RVA = "0x1CB7D04", Offset = "0x1CB7D04", VA = "0x7BBC4B7D04")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143868", Offset = "0x1143868")]
		private void <RequstToOpenChest>b__13_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x04009719 RID: 38681
		[Token(Token = "0x4009719")]
		[FieldOffset(Offset = "0x98")]
		private UILevelUpView m_View;

		// Token: 0x0400971A RID: 38682
		[Token(Token = "0x400971A")]
		[FieldOffset(Offset = "0xA0")]
		private uint m_ChestId;

		// Token: 0x0400971B RID: 38683
		[Token(Token = "0x400971B")]
		[FieldOffset(Offset = "0xA8")]
		private Transform[] m_AwardGridArray;

		// Token: 0x0400971C RID: 38684
		[Token(Token = "0x400971C")]
		[FieldOffset(Offset = "0xB0")]
		private List<CommonRewardItemInfo> m_RewardInfoList;

		// Token: 0x0400971D RID: 38685
		[Token(Token = "0x400971D")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject m_ModelChest;

		// Token: 0x0400971E RID: 38686
		[Token(Token = "0x400971E")]
		[FieldOffset(Offset = "0xC0")]
		private bool isNullNewEntrance;

		// Token: 0x0400971F RID: 38687
		[Token(Token = "0x400971F")]
		[FieldOffset(Offset = "0xC8")]
		private List<UIStandardItemMAXBController> itemCtrlList;

		// Token: 0x04009720 RID: 38688
		[Token(Token = "0x4009720")]
		[FieldOffset(Offset = "0xD0")]
		private int soundCnt;

		// Token: 0x020019E1 RID: 6625
		[Token(Token = "0x20019E1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7274", Offset = "0x10F7274")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060088DE RID: 35038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60088DE")]
			[Address(RVA = "0x1CB7F50", Offset = "0x1CB7F50", VA = "0x7BBC4B7F50")]
			public <>c()
			{
			}

			// Token: 0x060088DF RID: 35039 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60088DF")]
			[Address(RVA = "0x1CB7F58", Offset = "0x1CB7F58", VA = "0x7BBC4B7F58")]
			internal CommonRewardItemInfo <RequstToOpenChest>b__13_1(ExchangedAward item)
			{
				return null;
			}

			// Token: 0x04009721 RID: 38689
			[Token(Token = "0x4009721")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UILevelUpController.<>c <>9;

			// Token: 0x04009722 RID: 38690
			[Token(Token = "0x4009722")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<ExchangedAward, CommonRewardItemInfo> <>9__13_1;
		}

		// Token: 0x020019E2 RID: 6626
		[Token(Token = "0x20019E2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7284", Offset = "0x10F7284")]
		private sealed class <OpenChestCoroutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060088E0 RID: 35040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60088E0")]
			[Address(RVA = "0x1CB72BC", Offset = "0x1CB72BC", VA = "0x7BBC4B72BC")]
			[DebuggerHidden]
			public <OpenChestCoroutine>d__16(int <>1__state)
			{
			}

			// Token: 0x060088E1 RID: 35041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60088E1")]
			[Address(RVA = "0x1CB7F64", Offset = "0x1CB7F64", VA = "0x7BBC4B7F64", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060088E2 RID: 35042 RVA: 0x00024D08 File Offset: 0x00022F08
			[Token(Token = "0x60088E2")]
			[Address(RVA = "0x1CB7F68", Offset = "0x1CB7F68", VA = "0x7BBC4B7F68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009BD RID: 2493
			// (get) Token: 0x060088E3 RID: 35043 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009BD")]
			private object Current
			{
				[Token(Token = "0x60088E3")]
				[Address(RVA = "0x1CB80D0", Offset = "0x1CB80D0", VA = "0x7BBC4B80D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060088E4 RID: 35044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60088E4")]
			[Address(RVA = "0x1CB80D8", Offset = "0x1CB80D8", VA = "0x7BBC4B80D8", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009BE RID: 2494
			// (get) Token: 0x060088E5 RID: 35045 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009BE")]
			private object Current
			{
				[Token(Token = "0x60088E5")]
				[Address(RVA = "0x1CB8140", Offset = "0x1CB8140", VA = "0x7BBC4B8140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04009723 RID: 38691
			[Token(Token = "0x4009723")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04009724 RID: 38692
			[Token(Token = "0x4009724")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04009725 RID: 38693
			[Token(Token = "0x4009725")]
			[FieldOffset(Offset = "0x20")]
			public UILevelUpController <>4__this;
		}
	}
}
