using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001AD0 RID: 6864
	[Token(Token = "0x2001AD0")]
	public class UIPaymentIAPController : UIPaymentController.PaymentTabContentController, IUIModelDataChangeObserver, ITipsDelegate
	{
		// Token: 0x060090EB RID: 37099 RVA: 0x00026A78 File Offset: 0x00024C78
		[Token(Token = "0x60090EB")]
		[Address(RVA = "0x1F293D8", Offset = "0x1F293D8", VA = "0x7BBC7293D8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060090EC RID: 37100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090EC")]
		[Address(RVA = "0x1F29428", Offset = "0x1F29428", VA = "0x7BBC729428", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060090ED RID: 37101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090ED")]
		[Address(RVA = "0x1F29870", Offset = "0x1F29870", VA = "0x7BBC729870", Slot = "29")]
		public override void RefreshContent()
		{
		}

		// Token: 0x060090EE RID: 37102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090EE")]
		[Address(RVA = "0x1F29C9C", Offset = "0x1F29C9C", VA = "0x7BBC729C9C", Slot = "32")]
		public void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x060090EF RID: 37103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090EF")]
		[Address(RVA = "0x1F29B8C", Offset = "0x1F29B8C", VA = "0x7BBC729B8C")]
		private void UpdatePaymentActivityRedDot()
		{
		}

		// Token: 0x060090F0 RID: 37104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090F0")]
		[Address(RVA = "0x1F29CB0", Offset = "0x1F29CB0", VA = "0x7BBC729CB0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060090F1 RID: 37105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090F1")]
		[Address(RVA = "0x1F29E58", Offset = "0x1F29E58", VA = "0x7BBC729E58")]
		private void OnBtnPaymentActivityClick()
		{
		}

		// Token: 0x060090F2 RID: 37106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090F2")]
		[Address(RVA = "0x1F29FCC", Offset = "0x1F29FCC", VA = "0x7BBC729FCC")]
		private void ClearPayItemControllers()
		{
		}

		// Token: 0x060090F3 RID: 37107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090F3")]
		[Address(RVA = "0x1F2A118", Offset = "0x1F2A118", VA = "0x7BBC72A118")]
		private void RefreshCdnAds()
		{
		}

		// Token: 0x060090F4 RID: 37108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090F4")]
		[Address(RVA = "0x1F2A420", Offset = "0x1F2A420", VA = "0x7BBC72A420")]
		private void RefreshCdnAdsUI()
		{
		}

		// Token: 0x060090F5 RID: 37109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090F5")]
		[Address(RVA = "0x1F2AD54", Offset = "0x1F2AD54", VA = "0x7BBC72AD54")]
		private void OnCDNAdItemsAutoScroll()
		{
		}

		// Token: 0x060090F6 RID: 37110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090F6")]
		[Address(RVA = "0x1F2AEA4", Offset = "0x1F2AEA4", VA = "0x7BBC72AEA4")]
		private void GetCdnAdsCenterItem(GameObject centerGo)
		{
		}

		// Token: 0x060090F7 RID: 37111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090F7")]
		[Address(RVA = "0x1F29984", Offset = "0x1F29984", VA = "0x7BBC729984")]
		private void RefreshPayItemControllers()
		{
		}

		// Token: 0x060090F8 RID: 37112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090F8")]
		[Address(RVA = "0x1F2B054", Offset = "0x1F2B054", VA = "0x7BBC72B054")]
		private void OnPayItemClick(object[] parameters)
		{
		}

		// Token: 0x060090F9 RID: 37113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090F9")]
		[Address(RVA = "0x1F2B43C", Offset = "0x1F2B43C", VA = "0x7BBC72B43C")]
		private void OnSpinBtnClick()
		{
		}

		// Token: 0x060090FA RID: 37114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090FA")]
		[Address(RVA = "0x1F2B4DC", Offset = "0x1F2B4DC", VA = "0x7BBC72B4DC")]
		private void OnSpinWndConfirm(object[] parameters)
		{
		}

		// Token: 0x060090FB RID: 37115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090FB")]
		[Address(RVA = "0x1F2B650", Offset = "0x1F2B650", VA = "0x7BBC72B650", Slot = "30")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060090FC RID: 37116 RVA: 0x00026A90 File Offset: 0x00024C90
		[Token(Token = "0x60090FC")]
		[Address(RVA = "0x1F2B8FC", Offset = "0x1F2B8FC", VA = "0x7BBC72B8FC", Slot = "31")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060090FD RID: 37117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090FD")]
		[Address(RVA = "0x1F2B744", Offset = "0x1F2B744", VA = "0x7BBC72B744")]
		private void SetBonusState()
		{
		}

		// Token: 0x060090FE RID: 37118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090FE")]
		[Address(RVA = "0x1F2B7FC", Offset = "0x1F2B7FC", VA = "0x7BBC72B7FC")]
		private void RefreshBonusView()
		{
		}

		// Token: 0x060090FF RID: 37119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090FF")]
		[Address(RVA = "0x1F2BA60", Offset = "0x1F2BA60", VA = "0x7BBC72BA60")]
		private void RefreshBonusCountDownTime()
		{
		}

		// Token: 0x06009100 RID: 37120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009100")]
		[Address(RVA = "0x1F2BB40", Offset = "0x1F2BB40", VA = "0x7BBC72BB40")]
		private void RefreshBonusViewByNotSpinState()
		{
		}

		// Token: 0x06009101 RID: 37121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009101")]
		[Address(RVA = "0x1F2BB9C", Offset = "0x1F2BB9C", VA = "0x7BBC72BB9C")]
		private void RefreshBonusViewByHasBonusTimesState()
		{
		}

		// Token: 0x06009102 RID: 37122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009102")]
		[Address(RVA = "0x1F2B940", Offset = "0x1F2B940", VA = "0x7BBC72B940")]
		private void ResetBonusWidget()
		{
		}

		// Token: 0x06009103 RID: 37123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009103")]
		[Address(RVA = "0x1F2BE98", Offset = "0x1F2BE98", VA = "0x7BBC72BE98")]
		public UIPaymentIAPController()
		{
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009104")]
		[Address(RVA = "0x1F2BF98", Offset = "0x1F2BF98", VA = "0x7BBC72BF98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114494C", Offset = "0x114494C")]
		private void <RefreshBonusCountDownTime>b__33_0()
		{
		}

		// Token: 0x04009C62 RID: 40034
		[Token(Token = "0x4009C62")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentIAPView m_View;

		// Token: 0x04009C63 RID: 40035
		[Token(Token = "0x4009C63")]
		[FieldOffset(Offset = "0x60")]
		private UICenterOnChild m_CenterOnChild;

		// Token: 0x04009C64 RID: 40036
		[Token(Token = "0x4009C64")]
		[FieldOffset(Offset = "0x68")]
		private UIModelPayment m_ModelPayment;

		// Token: 0x04009C65 RID: 40037
		[Token(Token = "0x4009C65")]
		[FieldOffset(Offset = "0x70")]
		private UIPaymentIAPController.EBonusState m_BonusState;

		// Token: 0x04009C66 RID: 40038
		[Token(Token = "0x4009C66")]
		[FieldOffset(Offset = "0x78")]
		private string m_ProductIdentifier;

		// Token: 0x04009C67 RID: 40039
		[Token(Token = "0x4009C67")]
		[FieldOffset(Offset = "0x80")]
		private UICountDownController m_CDControler;

		// Token: 0x04009C68 RID: 40040
		[Token(Token = "0x4009C68")]
		[FieldOffset(Offset = "0x88")]
		private List<UIPayItemController> _PayItemControllerList;

		// Token: 0x04009C69 RID: 40041
		[Token(Token = "0x4009C69")]
		[FieldOffset(Offset = "0x90")]
		private List<AdvertDesc> m_CdnAds;

		// Token: 0x04009C6A RID: 40042
		[Token(Token = "0x4009C6A")]
		[FieldOffset(Offset = "0x98")]
		private List<UIPaymentIAPCDNItemController> m_CDNAdItems;

		// Token: 0x04009C6B RID: 40043
		[Token(Token = "0x4009C6B")]
		[FieldOffset(Offset = "0xA0")]
		private List<UILobbyDotController> m_CDNAdDots;

		// Token: 0x04009C6C RID: 40044
		[Token(Token = "0x4009C6C")]
		[FieldOffset(Offset = "0xA8")]
		private int m_CDNAdIndex;

		// Token: 0x04009C6D RID: 40045
		[Token(Token = "0x4009C6D")]
		[FieldOffset(Offset = "0xAC")]
		private uint m_AutoScrollDelayCallID;

		// Token: 0x02001AD1 RID: 6865
		[Token(Token = "0x2001AD1")]
		private enum EBonusState
		{
			// Token: 0x04009C6F RID: 40047
			[Token(Token = "0x4009C6F")]
			NoBonusEvent,
			// Token: 0x04009C70 RID: 40048
			[Token(Token = "0x4009C70")]
			NotSpin,
			// Token: 0x04009C71 RID: 40049
			[Token(Token = "0x4009C71")]
			HasBonusTimes,
			// Token: 0x04009C72 RID: 40050
			[Token(Token = "0x4009C72")]
			BonusTimesOver
		}
	}
}
