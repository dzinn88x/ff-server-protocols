using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001521 RID: 5409
	[Token(Token = "0x2001521")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE1C4", Offset = "0x10EE1C4")]
	public class UILobbyVehicleDisplayController : UINavigationController, IEasyList
	{
		// Token: 0x06005CDF RID: 23775 RVA: 0x0001B018 File Offset: 0x00019218
		[Token(Token = "0x6005CDF")]
		[Address(RVA = "0x19DB778", Offset = "0x19DB778", VA = "0x7BBC1DB778")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005CE0 RID: 23776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE0")]
		[Address(RVA = "0x19DB7C8", Offset = "0x19DB7C8", VA = "0x7BBC1DB7C8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005CE1 RID: 23777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE1")]
		[Address(RVA = "0x19DB82C", Offset = "0x19DB82C", VA = "0x7BBC1DB82C", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06005CE2 RID: 23778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE2")]
		[Address(RVA = "0x19DB838", Offset = "0x19DB838", VA = "0x7BBC1DB838", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06005CE3 RID: 23779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE3")]
		[Address(RVA = "0x19DB840", Offset = "0x19DB840", VA = "0x7BBC1DB840", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005CE4 RID: 23780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CE4")]
		[Address(RVA = "0x19DB848", Offset = "0x19DB848", VA = "0x7BBC1DB848", Slot = "39")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005CE5 RID: 23781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE5")]
		[Address(RVA = "0x19DB904", Offset = "0x19DB904", VA = "0x7BBC1DB904", Slot = "40")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005CE6 RID: 23782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE6")]
		[Address(RVA = "0x19DB934", Offset = "0x19DB934", VA = "0x7BBC1DB934")]
		public UILobbyVehicleDisplayController()
		{
		}

		// Token: 0x04007EC3 RID: 32451
		[Token(Token = "0x4007EC3")]
		[FieldOffset(Offset = "0xB0")]
		private UILobbyVehicleDisplayView m_View;

		// Token: 0x04007EC4 RID: 32452
		[Token(Token = "0x4007EC4")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelVehicleDisplay m_Model;

		// Token: 0x04007EC5 RID: 32453
		[Token(Token = "0x4007EC5")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x04007EC6 RID: 32454
		[Token(Token = "0x4007EC6")]
		[FieldOffset(Offset = "0xC8")]
		private UIPopMenuSmallControler m_PopMenuVehicle;

		// Token: 0x04007EC7 RID: 32455
		[Token(Token = "0x4007EC7")]
		[FieldOffset(Offset = "0xD0")]
		private List<PopMenuData> m_VehicleTypeFilterPopMenuList;

		// Token: 0x04007EC8 RID: 32456
		[Token(Token = "0x4007EC8")]
		[FieldOffset(Offset = "0xD8")]
		private }qPMTAX m_SelectedData;

		// Token: 0x04007EC9 RID: 32457
		[Token(Token = "0x4007EC9")]
		[FieldOffset(Offset = "0xE0")]
		private uint m_CurrentSkinID;

		// Token: 0x04007ECA RID: 32458
		[Token(Token = "0x4007ECA")]
		[FieldOffset(Offset = "0xE8")]
		private List<VehicleSkinBaseInfo> m_VehicleList;

		// Token: 0x04007ECB RID: 32459
		[Token(Token = "0x4007ECB")]
		[FieldOffset(Offset = "0xF0")]
		private UICommonGuideController m_guideController;
	}
}
