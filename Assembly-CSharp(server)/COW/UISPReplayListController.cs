using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001618 RID: 5656
	[Token(Token = "0x2001618")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFAAC", Offset = "0x10EFAAC")]
	public class UISPReplayListController : UINavigationController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06006595 RID: 26005 RVA: 0x0001D070 File Offset: 0x0001B270
		[Token(Token = "0x6006595")]
		[Address(RVA = "0x16287DC", Offset = "0x16287DC", VA = "0x7BBBE287DC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006596 RID: 26006 RVA: 0x0001D088 File Offset: 0x0001B288
		[Token(Token = "0x6006596")]
		[Address(RVA = "0x162882C", Offset = "0x162882C", VA = "0x7BBBE2882C", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06006597 RID: 26007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006597")]
		[Address(RVA = "0x1628834", Offset = "0x1628834", VA = "0x7BBBE28834", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006598 RID: 26008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006598")]
		[Address(RVA = "0x1628B8C", Offset = "0x1628B8C", VA = "0x7BBBE28B8C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006599 RID: 26009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006599")]
		[Address(RVA = "0x1628C40", Offset = "0x1628C40", VA = "0x7BBBE28C40")]
		private void OnInputChanged()
		{
		}

		// Token: 0x0600659A RID: 26010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600659A")]
		[Address(RVA = "0x1628CF0", Offset = "0x1628CF0", VA = "0x7BBBE28CF0")]
		private void OnBtnInputClear()
		{
		}

		// Token: 0x0600659B RID: 26011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600659B")]
		[Address(RVA = "0x1628D64", Offset = "0x1628D64", VA = "0x7BBBE28D64")]
		private void OnBtnRoomSearch()
		{
		}

		// Token: 0x0600659C RID: 26012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600659C")]
		[Address(RVA = "0x1628ADC", Offset = "0x1628ADC", VA = "0x7BBBE28ADC")]
		public void RefreshUI()
		{
		}

		// Token: 0x0600659D RID: 26013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600659D")]
		[Address(RVA = "0x1628D68", Offset = "0x1628D68", VA = "0x7BBBE28D68", Slot = "41")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600659E RID: 26014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600659E")]
		[Address(RVA = "0x1628DFC", Offset = "0x1628DFC", VA = "0x7BBBE28DFC", Slot = "42")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600659F RID: 26015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600659F")]
		[Address(RVA = "0x1628E2C", Offset = "0x1628E2C", VA = "0x7BBBE28E2C", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060065A0 RID: 26016 RVA: 0x0001D0A0 File Offset: 0x0001B2A0
		[Token(Token = "0x60065A0")]
		[Address(RVA = "0x1628EA4", Offset = "0x1628EA4", VA = "0x7BBBE28EA4", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060065A1 RID: 26017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A1")]
		[Address(RVA = "0x1628EE8", Offset = "0x1628EE8", VA = "0x7BBBE28EE8")]
		public UISPReplayListController()
		{
		}

		// Token: 0x040083D1 RID: 33745
		[Token(Token = "0x40083D1")]
		[FieldOffset(Offset = "0xB0")]
		private UISPReplayListView m_View;

		// Token: 0x040083D2 RID: 33746
		[Token(Token = "0x40083D2")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelReplay m_Model;
	}
}
