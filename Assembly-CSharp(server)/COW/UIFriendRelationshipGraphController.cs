using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020017CC RID: 6092
	[Token(Token = "0x20017CC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2CC4", Offset = "0x10F2CC4")]
	public class UIFriendRelationshipGraphController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06007517 RID: 29975 RVA: 0x00020838 File Offset: 0x0001EA38
		[Token(Token = "0x6007517")]
		[Address(RVA = "0x15936BC", Offset = "0x15936BC", VA = "0x7BBBD936BC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06007518 RID: 29976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000941")]
		private List<UIFriendRelationshipGraphContainer> BLayerContainer
		{
			[Token(Token = "0x6007518")]
			[Address(RVA = "0x159370C", Offset = "0x159370C", VA = "0x7BBBD9370C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06007519 RID: 29977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000942")]
		private List<UIFriendRelationshipGraphItemController> BLayerItems
		{
			[Token(Token = "0x6007519")]
			[Address(RVA = "0x1593780", Offset = "0x1593780", VA = "0x7BBBD93780")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x0600751A RID: 29978 RVA: 0x00020850 File Offset: 0x0001EA50
		[Token(Token = "0x17000943")]
		public int BLayerItemNum
		{
			[Token(Token = "0x600751A")]
			[Address(RVA = "0x15937F4", Offset = "0x15937F4", VA = "0x7BBBD937F4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x0600751B RID: 29979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000944")]
		private List<UIFriendRelationshipGraphContainer> CLayerContainer
		{
			[Token(Token = "0x600751B")]
			[Address(RVA = "0x1593858", Offset = "0x1593858", VA = "0x7BBBD93858")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x0600751C RID: 29980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000945")]
		private List<UIFriendRelationshipGraphItemController> CLayerItems
		{
			[Token(Token = "0x600751C")]
			[Address(RVA = "0x15938CC", Offset = "0x15938CC", VA = "0x7BBBD938CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x0600751D RID: 29981 RVA: 0x00020868 File Offset: 0x0001EA68
		[Token(Token = "0x17000946")]
		public int CLayerItemNum
		{
			[Token(Token = "0x600751D")]
			[Address(RVA = "0x1593940", Offset = "0x1593940", VA = "0x7BBBD93940")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x0600751E RID: 29982 RVA: 0x00020880 File Offset: 0x0001EA80
		[Token(Token = "0x17000947")]
		private bool ShowCLayerAnim
		{
			[Token(Token = "0x600751E")]
			[Address(RVA = "0x15939A4", Offset = "0x15939A4", VA = "0x7BBBD939A4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x0600751F RID: 29983 RVA: 0x00020898 File Offset: 0x0001EA98
		[Token(Token = "0x17000948")]
		private uint CLayerSwapAnimDelayCallID
		{
			[Token(Token = "0x600751F")]
			[Address(RVA = "0x15939AC", Offset = "0x15939AC", VA = "0x7BBBD939AC")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06007520 RID: 29984 RVA: 0x000208B0 File Offset: 0x0001EAB0
		[Token(Token = "0x17000949")]
		private int CurrentCLayerFriendIndex
		{
			[Token(Token = "0x6007520")]
			[Address(RVA = "0x15939B4", Offset = "0x15939B4", VA = "0x7BBBD939B4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06007521 RID: 29985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700094A")]
		private List<UIFriendRelationshipGraphContainer> DLayerContainer
		{
			[Token(Token = "0x6007521")]
			[Address(RVA = "0x15939BC", Offset = "0x15939BC", VA = "0x7BBBD939BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06007522 RID: 29986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700094B")]
		private List<UIFriendRelationshipGraphItemController> DLayerItems
		{
			[Token(Token = "0x6007522")]
			[Address(RVA = "0x1593A30", Offset = "0x1593A30", VA = "0x7BBBD93A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06007523 RID: 29987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700094C")]
		private FriendAccountInfo CloseFriendInfo
		{
			[Token(Token = "0x6007523")]
			[Address(RVA = "0x1593AA4", Offset = "0x1593AA4", VA = "0x7BBBD93AA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06007524 RID: 29988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700094D")]
		private List<FriendAccountInfo> GameFriendList
		{
			[Token(Token = "0x6007524")]
			[Address(RVA = "0x1593AAC", Offset = "0x1593AAC", VA = "0x7BBBD93AAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06007525 RID: 29989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700094E")]
		private List<FriendAccountInfo> SearchFriendList
		{
			[Token(Token = "0x6007525")]
			[Address(RVA = "0x1593B20", Offset = "0x1593B20", VA = "0x7BBBD93B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007526 RID: 29990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007526")]
		[Address(RVA = "0x1593B94", Offset = "0x1593B94", VA = "0x7BBBD93B94", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007527 RID: 29991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007527")]
		[Address(RVA = "0x1594278", Offset = "0x1594278", VA = "0x7BBBD94278", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007528 RID: 29992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007528")]
		[Address(RVA = "0x1596220", Offset = "0x1596220", VA = "0x7BBBD96220", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007529 RID: 29993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007529")]
		[Address(RVA = "0x15963E4", Offset = "0x15963E4", VA = "0x7BBBD963E4", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x0600752A RID: 29994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600752A")]
		[Address(RVA = "0x1596494", Offset = "0x1596494", VA = "0x7BBBD96494", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x0600752B RID: 29995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600752B")]
		[Address(RVA = "0x1596560", Offset = "0x1596560", VA = "0x7BBBD96560", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600752C RID: 29996 RVA: 0x000208C8 File Offset: 0x0001EAC8
		[Token(Token = "0x600752C")]
		[Address(RVA = "0x159679C", Offset = "0x159679C", VA = "0x7BBBD9679C", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600752D RID: 29997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600752D")]
		[Address(RVA = "0x15967FC", Offset = "0x15967FC", VA = "0x7BBBD967FC")]
		private void FillBLayerData()
		{
		}

		// Token: 0x0600752E RID: 29998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600752E")]
		[Address(RVA = "0x1596D40", Offset = "0x1596D40", VA = "0x7BBBD96D40")]
		private void FillCLayerData()
		{
		}

		// Token: 0x0600752F RID: 29999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600752F")]
		[Address(RVA = "0x15971D0", Offset = "0x15971D0", VA = "0x7BBBD971D0")]
		private void FillDLayerData()
		{
		}

		// Token: 0x06007530 RID: 30000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007530")]
		[Address(RVA = "0x159615C", Offset = "0x159615C", VA = "0x7BBBD9615C")]
		private void RefreshSearchFriendList()
		{
		}

		// Token: 0x06007531 RID: 30001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007531")]
		[Address(RVA = "0x1595AB0", Offset = "0x1595AB0", VA = "0x7BBBD95AB0")]
		private void RefreshRelationshipInfo()
		{
		}

		// Token: 0x06007532 RID: 30002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007532")]
		[Address(RVA = "0x1595D08", Offset = "0x1595D08", VA = "0x7BBBD95D08")]
		private void RefreshGameFriendList()
		{
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007533")]
		[Address(RVA = "0x1597714", Offset = "0x1597714", VA = "0x7BBBD97714")]
		private void OnLeaveBtnClick()
		{
		}

		// Token: 0x06007534 RID: 30004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007534")]
		[Address(RVA = "0x159771C", Offset = "0x159771C", VA = "0x7BBBD9771C")]
		private void OnShareBtnClick()
		{
		}

		// Token: 0x06007535 RID: 30005 RVA: 0x000208E0 File Offset: 0x0001EAE0
		[Token(Token = "0x6007535")]
		[Address(RVA = "0x1597800", Offset = "0x1597800", VA = "0x7BBBD97800")]
		private int SortGameFriend(FriendAccountInfo xFriend, FriendAccountInfo yFriend)
		{
			return 0;
		}

		// Token: 0x06007536 RID: 30006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007536")]
		[Address(RVA = "0x15978D0", Offset = "0x15978D0", VA = "0x7BBBD978D0")]
		private void OnHandleDetailInfoClick()
		{
		}

		// Token: 0x06007537 RID: 30007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007537")]
		[Address(RVA = "0x1597AF0", Offset = "0x1597AF0", VA = "0x7BBBD97AF0")]
		private void OnHandleOpenBriefBox(params object[] data)
		{
		}

		// Token: 0x06007538 RID: 30008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007538")]
		[Address(RVA = "0x1597B90", Offset = "0x1597B90", VA = "0x7BBBD97B90")]
		private void OnHandleCloseBriefBox(params object[] data)
		{
		}

		// Token: 0x06007539 RID: 30009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007539")]
		[Address(RVA = "0x159665C", Offset = "0x159665C", VA = "0x7BBBD9665C")]
		private void RefreshAddFriendState()
		{
		}

		// Token: 0x0600753A RID: 30010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600753A")]
		[Address(RVA = "0x1597D14", Offset = "0x1597D14", VA = "0x7BBBD97D14")]
		public UIFriendRelationshipGraphController()
		{
		}

		// Token: 0x04008CB4 RID: 36020
		[Token(Token = "0x4008CB4")]
		private const float SWAP_C_LAYER_FRIEND_CDTIME = 10f;

		// Token: 0x04008CB5 RID: 36021
		[Token(Token = "0x4008CB5")]
		[FieldOffset(Offset = "0x98")]
		private UIFriendRelationshipGraphView m_View;

		// Token: 0x04008CB6 RID: 36022
		[Token(Token = "0x4008CB6")]
		[FieldOffset(Offset = "0xA0")]
		private UIFriendRelationshipGraphContainer m_SelfItemContainer;

		// Token: 0x04008CB7 RID: 36023
		[Token(Token = "0x4008CB7")]
		[FieldOffset(Offset = "0xA8")]
		private UIFriendRelationshipGraphItemController m_SelfItem;

		// Token: 0x04008CB8 RID: 36024
		[Token(Token = "0x4008CB8")]
		[FieldOffset(Offset = "0xB0")]
		private UIFriendRelationshipGraphContainer m_CloseFriendContainer;

		// Token: 0x04008CB9 RID: 36025
		[Token(Token = "0x4008CB9")]
		[FieldOffset(Offset = "0xB8")]
		private UIFriendRelationshipGraphItemController m_CloseFriendItem;

		// Token: 0x04008CBA RID: 36026
		[Token(Token = "0x4008CBA")]
		[FieldOffset(Offset = "0xC0")]
		private List<UIFriendRelationshipGraphContainer> m_BLayerContainer;

		// Token: 0x04008CBB RID: 36027
		[Token(Token = "0x4008CBB")]
		[FieldOffset(Offset = "0xC8")]
		private List<UIFriendRelationshipGraphItemController> m_BLayerItems;

		// Token: 0x04008CBC RID: 36028
		[Token(Token = "0x4008CBC")]
		[FieldOffset(Offset = "0xD0")]
		private List<UIFriendRelationshipGraphContainer> m_CLayerContainer;

		// Token: 0x04008CBD RID: 36029
		[Token(Token = "0x4008CBD")]
		[FieldOffset(Offset = "0xD8")]
		private List<UIFriendRelationshipGraphItemController> m_CLayerItems;

		// Token: 0x04008CBE RID: 36030
		[Token(Token = "0x4008CBE")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_ShowCLayerAnim;

		// Token: 0x04008CBF RID: 36031
		[Token(Token = "0x4008CBF")]
		[FieldOffset(Offset = "0xE4")]
		private uint m_CLayerSwapAnimDelayCallID;

		// Token: 0x04008CC0 RID: 36032
		[Token(Token = "0x4008CC0")]
		[FieldOffset(Offset = "0xE8")]
		private int m_CurrentCLayerFriendIndex;

		// Token: 0x04008CC1 RID: 36033
		[Token(Token = "0x4008CC1")]
		[FieldOffset(Offset = "0xF0")]
		private List<UIFriendRelationshipGraphContainer> m_DLayerContainer;

		// Token: 0x04008CC2 RID: 36034
		[Token(Token = "0x4008CC2")]
		[FieldOffset(Offset = "0xF8")]
		private List<UIFriendRelationshipGraphItemController> m_DLayerItems;

		// Token: 0x04008CC3 RID: 36035
		[Token(Token = "0x4008CC3")]
		[FieldOffset(Offset = "0x100")]
		private UIModelFriends m_ModelFriend;

		// Token: 0x04008CC4 RID: 36036
		[Token(Token = "0x4008CC4")]
		[FieldOffset(Offset = "0x108")]
		private UIModelRelationShip m_ModelRelationShip;

		// Token: 0x04008CC5 RID: 36037
		[Token(Token = "0x4008CC5")]
		[FieldOffset(Offset = "0x110")]
		private FriendAccountInfo m_CloseFriendInfo;

		// Token: 0x04008CC6 RID: 36038
		[Token(Token = "0x4008CC6")]
		[FieldOffset(Offset = "0x118")]
		private List<FriendAccountInfo> m_GameFriendList;

		// Token: 0x04008CC7 RID: 36039
		[Token(Token = "0x4008CC7")]
		[FieldOffset(Offset = "0x120")]
		private List<FriendAccountInfo> m_SearchFriendList;
	}
}
