using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B5D RID: 7005
	[Token(Token = "0x2001B5D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9DC4", Offset = "0x10F9DC4")]
	public class UIRoomCardListController : UIBaseController
	{
		// Token: 0x06009696 RID: 38550 RVA: 0x00027CD8 File Offset: 0x00025ED8
		[Token(Token = "0x6009696")]
		[Address(RVA = "0x1E21BEC", Offset = "0x1E21BEC", VA = "0x7BBC621BEC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009697 RID: 38551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009697")]
		[Address(RVA = "0x1E21C3C", Offset = "0x1E21C3C", VA = "0x7BBC621C3C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009698 RID: 38552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009698")]
		[Address(RVA = "0x1E21D28", Offset = "0x1E21D28", VA = "0x7BBC621D28")]
		public void RefreshCard(params object[] data)
		{
		}

		// Token: 0x06009699 RID: 38553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009699")]
		[Address(RVA = "0x1E224E8", Offset = "0x1E224E8", VA = "0x7BBC6224E8")]
		public UIRoomCardListController()
		{
		}

		// Token: 0x04009F19 RID: 40729
		[Token(Token = "0x4009F19")]
		[FieldOffset(Offset = "0x58")]
		private UIRoomCardListView m_View;

		// Token: 0x04009F1A RID: 40730
		[Token(Token = "0x4009F1A")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<EInventory.ItemSubType, UIRoomCardView> m_CardViewDic;

		// Token: 0x04009F1B RID: 40731
		[Token(Token = "0x4009F1B")]
		private const string GUIDE_KEY = "KEY_CUSTOMROOM_ADCS_CARD";
	}
}
