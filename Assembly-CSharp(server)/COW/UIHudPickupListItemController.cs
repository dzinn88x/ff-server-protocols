using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001929 RID: 6441
	[Token(Token = "0x2001929")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5A7C", Offset = "0x10F5A7C")]
	internal class UIHudPickupListItemController : UIBaseController
	{
		// Token: 0x06008226 RID: 33318 RVA: 0x00023700 File Offset: 0x00021900
		[Token(Token = "0x6008226")]
		[Address(RVA = "0x1D744D4", Offset = "0x1D744D4", VA = "0x7BBC5744D4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008227 RID: 33319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008227")]
		[Address(RVA = "0x1D74524", Offset = "0x1D74524", VA = "0x7BBC574524", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06008228 RID: 33320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009AA")]
		public nS}etYj CurrentItemData
		{
			[Token(Token = "0x6008228")]
			[Address(RVA = "0x1D72554", Offset = "0x1D72554", VA = "0x7BBC572554")]
			get
			{
				return null;
			}
		}

		// Token: 0x06008229 RID: 33321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008229")]
		[Address(RVA = "0x1D70C58", Offset = "0x1D70C58", VA = "0x7BBC570C58")]
		public void RefreshPickLevel()
		{
		}

		// Token: 0x0600822A RID: 33322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600822A")]
		[Address(RVA = "0x1D73128", Offset = "0x1D73128", VA = "0x7BBC573128")]
		public void SetUIData(^yE\u007FRJO item, uint containerID)
		{
		}

		// Token: 0x0600822B RID: 33323 RVA: 0x00023718 File Offset: 0x00021918
		[Token(Token = "0x600822B")]
		[Address(RVA = "0x1D716D0", Offset = "0x1D716D0", VA = "0x7BBC5716D0")]
		public bool IsEqualPickUp(^yE\u007FRJO pu)
		{
			return default(bool);
		}

		// Token: 0x0600822C RID: 33324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600822C")]
		[Address(RVA = "0x1D7174C", Offset = "0x1D7174C", VA = "0x7BBC57174C")]
		public void OnBtnItemActionClick()
		{
		}

		// Token: 0x0600822D RID: 33325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600822D")]
		[Address(RVA = "0x1D74638", Offset = "0x1D74638", VA = "0x7BBC574638")]
		public UIHudPickupListItemController()
		{
		}

		// Token: 0x04009383 RID: 37763
		[Token(Token = "0x4009383")]
		private const string ITEM_STATE_BAN = "icon_ban";

		// Token: 0x04009384 RID: 37764
		[Token(Token = "0x4009384")]
		private const string ITEM_STATE_INC = "UI_icon_up_arrow";

		// Token: 0x04009385 RID: 37765
		[Token(Token = "0x4009385")]
		private const string ITEM_STATE_DEC = "UI_icon_down_arrow";

		// Token: 0x04009386 RID: 37766
		[Token(Token = "0x4009386")]
		private const string ITEM_STATE_REP = "icon_replace";

		// Token: 0x04009387 RID: 37767
		[Token(Token = "0x4009387")]
		[FieldOffset(Offset = "0x0")]
		private static Color ItemDisable;

		// Token: 0x04009388 RID: 37768
		[Token(Token = "0x4009388")]
		[FieldOffset(Offset = "0x10")]
		private static Color ItemNameDisable;

		// Token: 0x04009389 RID: 37769
		[Token(Token = "0x4009389")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPickupListItemView m_View;

		// Token: 0x0400938A RID: 37770
		[Token(Token = "0x400938A")]
		[FieldOffset(Offset = "0x60")]
		private ^yE\u007FRJO m_CurrentItem;

		// Token: 0x0400938B RID: 37771
		[Token(Token = "0x400938B")]
		[FieldOffset(Offset = "0x68")]
		private uint m_CurrentContainerID;

		// Token: 0x0400938C RID: 37772
		[Token(Token = "0x400938C")]
		[FieldOffset(Offset = "0x6C")]
		public BountyPickupStatus BountyStatus;
	}
}
