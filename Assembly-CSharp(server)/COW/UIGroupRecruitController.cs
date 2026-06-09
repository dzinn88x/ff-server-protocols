using System;
using System.Collections.Generic;
using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001857 RID: 6231
	[Token(Token = "0x2001857")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3DB4", Offset = "0x10F3DB4")]
	public class UIGroupRecruitController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06007A90 RID: 31376 RVA: 0x00021BE8 File Offset: 0x0001FDE8
		[Token(Token = "0x6007A90")]
		[Address(RVA = "0x16A43FC", Offset = "0x16A43FC", VA = "0x7BBBEA43FC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007A91 RID: 31377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A91")]
		[Address(RVA = "0x16A444C", Offset = "0x16A444C", VA = "0x7BBBEA444C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007A92 RID: 31378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A92")]
		[Address(RVA = "0x16A4B98", Offset = "0x16A4B98", VA = "0x7BBBEA4B98")]
		private void InitDefaultSelection()
		{
		}

		// Token: 0x06007A93 RID: 31379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A93")]
		[Address(RVA = "0x16A6BC8", Offset = "0x16A6BC8", VA = "0x7BBBEA6BC8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007A94 RID: 31380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A94")]
		[Address(RVA = "0x16A6C90", Offset = "0x16A6C90", VA = "0x7BBBEA6C90")]
		private void DefaultWorldState()
		{
		}

		// Token: 0x06007A95 RID: 31381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A95")]
		[Address(RVA = "0x16A5568", Offset = "0x16A5568", VA = "0x7BBBEA5568")]
		private void RefreshGroupDataUI()
		{
		}

		// Token: 0x06007A96 RID: 31382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A96")]
		[Address(RVA = "0x16A5D18", Offset = "0x16A5D18", VA = "0x7BBBEA5D18")]
		private void UpdateSendChannelView()
		{
		}

		// Token: 0x06007A97 RID: 31383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A97")]
		[Address(RVA = "0x16A6E18", Offset = "0x16A6E18", VA = "0x7BBBEA6E18")]
		private void OnSendClick()
		{
		}

		// Token: 0x06007A98 RID: 31384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A98")]
		[Address(RVA = "0x16A763C", Offset = "0x16A763C", VA = "0x7BBBEA763C")]
		private void DoSendRecruit()
		{
		}

		// Token: 0x06007A99 RID: 31385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A99")]
		[Address(RVA = "0x16A609C", Offset = "0x16A609C", VA = "0x7BBBEA609C")]
		private void OnChannelWorldToggleChangeWithTips(bool needTips = true)
		{
		}

		// Token: 0x06007A9A RID: 31386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A9A")]
		[Address(RVA = "0x16A7D10", Offset = "0x16A7D10", VA = "0x7BBBEA7D10")]
		private void OnChannelWorldToggleChange()
		{
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A9B")]
		[Address(RVA = "0x16A6350", Offset = "0x16A6350", VA = "0x7BBBEA6350")]
		private void OnChannelClanToggleChange()
		{
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x00021C00 File Offset: 0x0001FE00
		[Token(Token = "0x6007A9C")]
		[Address(RVA = "0x16A75B8", Offset = "0x16A75B8", VA = "0x7BBBEA75B8")]
		private bool CheckSendToValid()
		{
			return default(bool);
		}

		// Token: 0x06007A9D RID: 31389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A9D")]
		[Address(RVA = "0x16A7D2C", Offset = "0x16A7D2C", VA = "0x7BBBEA7D2C")]
		private void OnModeBtnClick()
		{
		}

		// Token: 0x06007A9E RID: 31390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007A9E")]
		[Address(RVA = "0x16A7FA4", Offset = "0x16A7FA4", VA = "0x7BBBEA7FA4")]
		private List<MultiPopMenuData> GetOrConstructModeMenu(ref string defaultID)
		{
			return null;
		}

		// Token: 0x06007A9F RID: 31391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A9F")]
		[Address(RVA = "0x16A832C", Offset = "0x16A832C", VA = "0x7BBBEA832C")]
		private void OnMapBtnClick()
		{
		}

		// Token: 0x06007AA0 RID: 31392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AA0")]
		[Address(RVA = "0x16A852C", Offset = "0x16A852C", VA = "0x7BBBEA852C")]
		private void OnGroupBtnClick()
		{
		}

		// Token: 0x06007AA1 RID: 31393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AA1")]
		[Address(RVA = "0x16A872C", Offset = "0x16A872C", VA = "0x7BBBEA872C")]
		private void OnLadderBtnClick()
		{
		}

		// Token: 0x06007AA2 RID: 31394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AA2")]
		[Address(RVA = "0x16A8950", Offset = "0x16A8950", VA = "0x7BBBEA8950")]
		private void OnTagBtn1Click()
		{
		}

		// Token: 0x06007AA3 RID: 31395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AA3")]
		[Address(RVA = "0x16A8EF0", Offset = "0x16A8EF0", VA = "0x7BBBEA8EF0")]
		private void OnTagBtn2Click()
		{
		}

		// Token: 0x06007AA4 RID: 31396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007AA4")]
		[Address(RVA = "0x16A8CA4", Offset = "0x16A8CA4", VA = "0x7BBBEA8CA4")]
		private List<MultiPopMenuData> GetOrConstructTagMenu()
		{
			return null;
		}

		// Token: 0x06007AA5 RID: 31397 RVA: 0x00021C18 File Offset: 0x0001FE18
		[Token(Token = "0x6007AA5")]
		[Address(RVA = "0x16A63C0", Offset = "0x16A63C0", VA = "0x7BBBEA63C0")]
		private bool SetSelectModeID(uint modeid, uint matchid)
		{
			return default(bool);
		}

		// Token: 0x06007AA6 RID: 31398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AA6")]
		[Address(RVA = "0x16A4E88", Offset = "0x16A4E88", VA = "0x7BBBEA4E88")]
		private void ConstructLadderData()
		{
		}

		// Token: 0x06007AA7 RID: 31399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AA7")]
		[Address(RVA = "0x16A9244", Offset = "0x16A9244", VA = "0x7BBBEA9244")]
		private void ConstructMapMenuList(List<MapModeData> mapList)
		{
		}

		// Token: 0x06007AA8 RID: 31400 RVA: 0x00021C30 File Offset: 0x0001FE30
		[Token(Token = "0x6007AA8")]
		[Address(RVA = "0x16A6934", Offset = "0x16A6934", VA = "0x7BBBEA6934")]
		private bool SetSelectMapID(uint mapid)
		{
			return default(bool);
		}

		// Token: 0x06007AA9 RID: 31401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AA9")]
		[Address(RVA = "0x16A95D8", Offset = "0x16A95D8", VA = "0x7BBBEA95D8")]
		private void ConstructGroupMenuList()
		{
		}

		// Token: 0x06007AAA RID: 31402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AAA")]
		[Address(RVA = "0x16A984C", Offset = "0x16A984C", VA = "0x7BBBEA984C", Slot = "40")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007AAB RID: 31403 RVA: 0x00021C48 File Offset: 0x0001FE48
		[Token(Token = "0x6007AAB")]
		[Address(RVA = "0x16A9920", Offset = "0x16A9920", VA = "0x7BBBEA9920", Slot = "41")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AAC")]
		[Address(RVA = "0x16A9964", Offset = "0x16A9964", VA = "0x7BBBEA9964")]
		public UIGroupRecruitController()
		{
		}

		// Token: 0x06007AAD RID: 31405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AAD")]
		[Address(RVA = "0x16A9A80", Offset = "0x16A9A80", VA = "0x7BBBEA9A80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142424", Offset = "0x1142424")]
		private void <OnModeBtnClick>b__35_0(List<string> ids)
		{
		}

		// Token: 0x06007AAE RID: 31406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AAE")]
		[Address(RVA = "0x16A9BE8", Offset = "0x16A9BE8", VA = "0x7BBBEA9BE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142434", Offset = "0x1142434")]
		private void <OnMapBtnClick>b__37_0(List<string> ids)
		{
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AAF")]
		[Address(RVA = "0x16A9CA4", Offset = "0x16A9CA4", VA = "0x7BBBEA9CA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142444", Offset = "0x1142444")]
		private void <OnGroupBtnClick>b__38_0(List<string> ids)
		{
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AB0")]
		[Address(RVA = "0x16A9D5C", Offset = "0x16A9D5C", VA = "0x7BBBEA9D5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142454", Offset = "0x1142454")]
		private void <OnLadderBtnClick>b__39_0(List<string> ids)
		{
		}

		// Token: 0x06007AB1 RID: 31409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AB1")]
		[Address(RVA = "0x16A9E14", Offset = "0x16A9E14", VA = "0x7BBBEA9E14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142464", Offset = "0x1142464")]
		private void <OnTagBtn1Click>b__40_0(List<string> ids)
		{
		}

		// Token: 0x06007AB2 RID: 31410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AB2")]
		[Address(RVA = "0x16A9ECC", Offset = "0x16A9ECC", VA = "0x7BBBEA9ECC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142474", Offset = "0x1142474")]
		private void <OnTagBtn2Click>b__41_0(List<string> ids)
		{
		}

		// Token: 0x04008F3A RID: 36666
		[Token(Token = "0x4008F3A")]
		[FieldOffset(Offset = "0x98")]
		private UIGroupRecruitView m_View;

		// Token: 0x04008F3B RID: 36667
		[Token(Token = "0x4008F3B")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelChat m_ChatModel;

		// Token: 0x04008F3C RID: 36668
		[Token(Token = "0x4008F3C")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelGroup m_GroupModel;

		// Token: 0x04008F3D RID: 36669
		[Token(Token = "0x4008F3D")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelMapOpeningInfo m_ModelMap;

		// Token: 0x04008F3E RID: 36670
		[Token(Token = "0x4008F3E")]
		[FieldOffset(Offset = "0xB8")]
		private StringBuilder m_Builder;

		// Token: 0x04008F3F RID: 36671
		[Token(Token = "0x4008F3F")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_LastInCDState;

		// Token: 0x04008F40 RID: 36672
		[Token(Token = "0x4008F40")]
		[FieldOffset(Offset = "0xC4")]
		private uint m_WorldDelayCallID;

		// Token: 0x04008F41 RID: 36673
		[Token(Token = "0x4008F41")]
		[FieldOffset(Offset = "0xC8")]
		private readonly float GREY_ALPHA;

		// Token: 0x04008F42 RID: 36674
		[Token(Token = "0x4008F42")]
		[FieldOffset(Offset = "0xCC")]
		private bool m_HasWorldToggleInit;

		// Token: 0x04008F43 RID: 36675
		[Token(Token = "0x4008F43")]
		[FieldOffset(Offset = "0xD0")]
		private uint m_ModeID;

		// Token: 0x04008F44 RID: 36676
		[Token(Token = "0x4008F44")]
		[FieldOffset(Offset = "0xD4")]
		private uint m_MatchID;

		// Token: 0x04008F45 RID: 36677
		[Token(Token = "0x4008F45")]
		[FieldOffset(Offset = "0xD8")]
		private uint m_MapID;

		// Token: 0x04008F46 RID: 36678
		[Token(Token = "0x4008F46")]
		[FieldOffset(Offset = "0xDC")]
		private uint m_GroupID;

		// Token: 0x04008F47 RID: 36679
		[Token(Token = "0x4008F47")]
		[FieldOffset(Offset = "0xE0")]
		private int m_LadderLimitID;

		// Token: 0x04008F48 RID: 36680
		[Token(Token = "0x4008F48")]
		[FieldOffset(Offset = "0xE4")]
		private uint m_Tag1;

		// Token: 0x04008F49 RID: 36681
		[Token(Token = "0x4008F49")]
		[FieldOffset(Offset = "0xE8")]
		private uint m_Tag2;

		// Token: 0x04008F4A RID: 36682
		[Token(Token = "0x4008F4A")]
		[FieldOffset(Offset = "0xF0")]
		private List<MultiPopMenuData> m_ModeMenuData;

		// Token: 0x04008F4B RID: 36683
		[Token(Token = "0x4008F4B")]
		[FieldOffset(Offset = "0xF8")]
		private List<MultiPopMenuData> m_MapMenuData;

		// Token: 0x04008F4C RID: 36684
		[Token(Token = "0x4008F4C")]
		[FieldOffset(Offset = "0x100")]
		private List<MultiPopMenuData> m_GroupMenuData;

		// Token: 0x04008F4D RID: 36685
		[Token(Token = "0x4008F4D")]
		[FieldOffset(Offset = "0x108")]
		private List<MultiPopMenuData> m_RankMenuData;

		// Token: 0x04008F4E RID: 36686
		[Token(Token = "0x4008F4E")]
		[FieldOffset(Offset = "0x110")]
		private List<MultiPopMenuData> m_CSRankMenuData;

		// Token: 0x04008F4F RID: 36687
		[Token(Token = "0x4008F4F")]
		[FieldOffset(Offset = "0x118")]
		private List<MultiPopMenuData> m_TagMenuData;
	}
}
