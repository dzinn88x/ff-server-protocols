using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016D1 RID: 5841
	[Token(Token = "0x20016D1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0DD4", Offset = "0x10F0DD4")]
	public class UIAvatarUniversalDebrisExchangeController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06006B70 RID: 27504 RVA: 0x0001E690 File Offset: 0x0001C890
		[Token(Token = "0x6006B70")]
		[Address(RVA = "0x1E538A0", Offset = "0x1E538A0", VA = "0x7BBC6538A0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B71")]
		[Address(RVA = "0x1E538F0", Offset = "0x1E538F0", VA = "0x7BBC6538F0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006B72 RID: 27506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B72")]
		[Address(RVA = "0x1E53CAC", Offset = "0x1E53CAC", VA = "0x7BBC653CAC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B73")]
		[Address(RVA = "0x1E53DB4", Offset = "0x1E53DB4", VA = "0x7BBC653DB4")]
		private void OnSelectAvatarheadItem(params object[] data)
		{
		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B74")]
		[Address(RVA = "0x1E544DC", Offset = "0x1E544DC", VA = "0x7BBC6544DC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B75")]
		[Address(RVA = "0x1E544E4", Offset = "0x1E544E4", VA = "0x7BBC6544E4")]
		private void OnUseBtnClick()
		{
		}

		// Token: 0x06006B76 RID: 27510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B76")]
		[Address(RVA = "0x1E54758", Offset = "0x1E54758", VA = "0x7BBC654758")]
		private void OnSliderChanged()
		{
		}

		// Token: 0x06006B77 RID: 27511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B77")]
		[Address(RVA = "0x1E547DC", Offset = "0x1E547DC", VA = "0x7BBC6547DC")]
		private void OnPlusBtnClick()
		{
		}

		// Token: 0x06006B78 RID: 27512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B78")]
		[Address(RVA = "0x1E54874", Offset = "0x1E54874", VA = "0x7BBC654874")]
		private void OnMinusBtnClick()
		{
		}

		// Token: 0x06006B79 RID: 27513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B79")]
		[Address(RVA = "0x1E54908", Offset = "0x1E54908", VA = "0x7BBC654908")]
		private void OnExchangeAllBtnClick()
		{
		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B7A")]
		[Address(RVA = "0x1E54AF4", Offset = "0x1E54AF4", VA = "0x7BBC654AF4")]
		public void InitView(uint avatarID)
		{
		}

		// Token: 0x06006B7B RID: 27515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B7B")]
		[Address(RVA = "0x1E540EC", Offset = "0x1E540EC", VA = "0x7BBC6540EC")]
		public void RefreshSliderInfo()
		{
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B7C")]
		[Address(RVA = "0x1E53EEC", Offset = "0x1E53EEC", VA = "0x7BBC653EEC")]
		private void RefreshCurDebrisInfo()
		{
		}

		// Token: 0x06006B7D RID: 27517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B7D")]
		[Address(RVA = "0x1E54F00", Offset = "0x1E54F00", VA = "0x7BBC654F00")]
		private void RefreshBtnState()
		{
		}

		// Token: 0x06006B7E RID: 27518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B7E")]
		[Address(RVA = "0x1E5512C", Offset = "0x1E5512C", VA = "0x7BBC65512C", Slot = "41")]
		private void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006B7F RID: 27519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B7F")]
		[Address(RVA = "0x1E5515C", Offset = "0x1E5515C", VA = "0x7BBC65515C", Slot = "40")]
		private UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006B80 RID: 27520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B80")]
		[Address(RVA = "0x1E55234", Offset = "0x1E55234", VA = "0x7BBC655234", Slot = "42")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006B81 RID: 27521 RVA: 0x0001E6A8 File Offset: 0x0001C8A8
		[Token(Token = "0x6006B81")]
		[Address(RVA = "0x1E5553C", Offset = "0x1E5553C", VA = "0x7BBC65553C", Slot = "43")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006B82 RID: 27522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B82")]
		[Address(RVA = "0x1E55580", Offset = "0x1E55580", VA = "0x7BBC655580")]
		public UIAvatarUniversalDebrisExchangeController()
		{
		}

		// Token: 0x04008755 RID: 34645
		[Token(Token = "0x4008755")]
		[FieldOffset(Offset = "0x98")]
		private UIAvatarUniversalDebrisExchangeView m_View;

		// Token: 0x04008756 RID: 34646
		[Token(Token = "0x4008756")]
		[FieldOffset(Offset = "0xA0")]
		private List<AvatarProfile> m_ShowAvatarList;

		// Token: 0x04008757 RID: 34647
		[Token(Token = "0x4008757")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelAvatarProfile m_ProfileModel;

		// Token: 0x04008758 RID: 34648
		[Token(Token = "0x4008758")]
		[FieldOffset(Offset = "0xB0")]
		private int m_UniversalDebrisCnt;

		// Token: 0x04008759 RID: 34649
		[Token(Token = "0x4008759")]
		[FieldOffset(Offset = "0xB4")]
		private int m_ExchangeDebrisCnt;

		// Token: 0x0400875A RID: 34650
		[Token(Token = "0x400875A")]
		[FieldOffset(Offset = "0xB8")]
		private BoxCollider m_Collider;

		// Token: 0x0400875B RID: 34651
		[Token(Token = "0x400875B")]
		[FieldOffset(Offset = "0xC0")]
		private AvatarProfile m_CurrentAvatarPofile;

		// Token: 0x0400875C RID: 34652
		[Token(Token = "0x400875C")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_IsBtnClick;

		// Token: 0x0400875D RID: 34653
		[Token(Token = "0x400875D")]
		[FieldOffset(Offset = "0xCC")]
		private Color NORMAL_COLOR;

		// Token: 0x0400875E RID: 34654
		[Token(Token = "0x400875E")]
		[FieldOffset(Offset = "0xDC")]
		private Color DISABLE_COLOR;

		// Token: 0x020016D2 RID: 5842
		[Token(Token = "0x20016D2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0E0C", Offset = "0x10F0E0C")]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06006B83 RID: 27523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B83")]
			[Address(RVA = "0x1E54EF8", Offset = "0x1E54EF8", VA = "0x7BBC654EF8")]
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x06006B84 RID: 27524 RVA: 0x0001E6C0 File Offset: 0x0001C8C0
			[Token(Token = "0x6006B84")]
			[Address(RVA = "0x1E5570C", Offset = "0x1E5570C", VA = "0x7BBC65570C")]
			internal bool <InitView>b__0(AvatarProfile a)
			{
				return default(bool);
			}

			// Token: 0x06006B85 RID: 27525 RVA: 0x0001E6D8 File Offset: 0x0001C8D8
			[Token(Token = "0x6006B85")]
			[Address(RVA = "0x1E557C0", Offset = "0x1E557C0", VA = "0x7BBC6557C0")]
			internal bool <InitView>b__2(AvatarProfile e)
			{
				return default(bool);
			}

			// Token: 0x0400875F RID: 34655
			[Token(Token = "0x400875F")]
			[FieldOffset(Offset = "0x10")]
			public UIAvatarUniversalDebrisExchangeController <>4__this;

			// Token: 0x04008760 RID: 34656
			[Token(Token = "0x4008760")]
			[FieldOffset(Offset = "0x18")]
			public uint avatarID;
		}

		// Token: 0x020016D3 RID: 5843
		[Token(Token = "0x20016D3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0E1C", Offset = "0x10F0E1C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006B87 RID: 27527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B87")]
			[Address(RVA = "0x1E55680", Offset = "0x1E55680", VA = "0x7BBC655680")]
			public <>c()
			{
			}

			// Token: 0x06006B88 RID: 27528 RVA: 0x0001E6F0 File Offset: 0x0001C8F0
			[Token(Token = "0x6006B88")]
			[Address(RVA = "0x1E55688", Offset = "0x1E55688", VA = "0x7BBC655688")]
			internal int <InitView>b__20_1(AvatarProfile ap1, AvatarProfile ap2)
			{
				return 0;
			}

			// Token: 0x04008761 RID: 34657
			[Token(Token = "0x4008761")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIAvatarUniversalDebrisExchangeController.<>c <>9;

			// Token: 0x04008762 RID: 34658
			[Token(Token = "0x4008762")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<AvatarProfile> <>9__20_1;
		}

		// Token: 0x020016D4 RID: 5844
		[Token(Token = "0x20016D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0E2C", Offset = "0x10F0E2C")]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x06006B89 RID: 27529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B89")]
			[Address(RVA = "0x1E55534", Offset = "0x1E55534", VA = "0x7BBC655534")]
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x06006B8A RID: 27530 RVA: 0x0001E708 File Offset: 0x0001C908
			[Token(Token = "0x6006B8A")]
			[Address(RVA = "0x1E557FC", Offset = "0x1E557FC", VA = "0x7BBC6557FC")]
			internal bool <GCommon.IUIModelDataChangeObserver.OnDataChanged>b__0(AvatarProfile e)
			{
				return default(bool);
			}

			// Token: 0x04008763 RID: 34659
			[Token(Token = "0x4008763")]
			[FieldOffset(Offset = "0x10")]
			public object[] param;
		}
	}
}
