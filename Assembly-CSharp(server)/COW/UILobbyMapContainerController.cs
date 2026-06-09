using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A08 RID: 6664
	[Token(Token = "0x2001A08")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7734", Offset = "0x10F7734")]
	public class UILobbyMapContainerController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008AAC RID: 35500 RVA: 0x00025338 File Offset: 0x00023538
		[Token(Token = "0x6008AAC")]
		[Address(RVA = "0x14417AC", Offset = "0x14417AC", VA = "0x7BBBC417AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008AAD RID: 35501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AAD")]
		[Address(RVA = "0x14417FC", Offset = "0x14417FC", VA = "0x7BBBC417FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008AAE RID: 35502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AAE")]
		[Address(RVA = "0x1441A2C", Offset = "0x1441A2C", VA = "0x7BBBC41A2C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008AAF RID: 35503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AAF")]
		[Address(RVA = "0x1441B64", Offset = "0x1441B64", VA = "0x7BBBC41B64")]
		private void OnServerConfirmed(params object[] data)
		{
		}

		// Token: 0x06008AB0 RID: 35504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AB0")]
		[Address(RVA = "0x1441C20", Offset = "0x1441C20", VA = "0x7BBBC41C20")]
		public void SetUIData()
		{
		}

		// Token: 0x06008AB1 RID: 35505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AB1")]
		[Address(RVA = "0x1442888", Offset = "0x1442888", VA = "0x7BBBC42888")]
		private void OnCustomRoomClick()
		{
		}

		// Token: 0x06008AB2 RID: 35506 RVA: 0x00025350 File Offset: 0x00023550
		[Token(Token = "0x6008AB2")]
		[Address(RVA = "0x1442C70", Offset = "0x1442C70", VA = "0x7BBBC42C70", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008AB3 RID: 35507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AB3")]
		[Address(RVA = "0x1442C78", Offset = "0x1442C78", VA = "0x7BBBC42C78", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008AB4 RID: 35508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AB4")]
		[Address(RVA = "0x1442CF0", Offset = "0x1442CF0", VA = "0x7BBBC42CF0")]
		public UILobbyMapContainerController()
		{
		}

		// Token: 0x04009820 RID: 38944
		[Token(Token = "0x4009820")]
		[FieldOffset(Offset = "0x58")]
		private UILobbyMapContainerView m_View;

		// Token: 0x04009821 RID: 38945
		[Token(Token = "0x4009821")]
		[FieldOffset(Offset = "0x60")]
		private UIModelMapOpeningInfo m_ModelMap;
	}
}
