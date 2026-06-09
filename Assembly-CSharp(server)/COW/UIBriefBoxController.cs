using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020016EB RID: 5867
	[Token(Token = "0x20016EB")]
	public class UIBriefBoxController : UIBasePopMenuController<UIChatPopMenuItemContoller>, IUIModelDataChangeObserver
	{
		// Token: 0x06006CB0 RID: 27824 RVA: 0x0001EAE0 File Offset: 0x0001CCE0
		[Token(Token = "0x6006CB0")]
		[Address(RVA = "0x14368F0", Offset = "0x14368F0", VA = "0x7BBBC368F0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006CB1 RID: 27825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB1")]
		[Address(RVA = "0x1436940", Offset = "0x1436940", VA = "0x7BBBC36940", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006CB2 RID: 27826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB2")]
		[Address(RVA = "0x1437430", Offset = "0x1437430", VA = "0x7BBBC37430", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06006CB3 RID: 27827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB3")]
		[Address(RVA = "0x14374DC", Offset = "0x14374DC", VA = "0x7BBBC374DC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB4")]
		[Address(RVA = "0x14376C4", Offset = "0x14376C4", VA = "0x7BBBC376C4")]
		private void RefreshCSRank(params object[] param)
		{
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB5")]
		[Address(RVA = "0x14379AC", Offset = "0x14379AC", VA = "0x7BBBC379AC", Slot = "21")]
		public override void Show()
		{
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB6")]
		[Address(RVA = "0x1437624", Offset = "0x1437624", VA = "0x7BBBC37624")]
		private void Clear()
		{
		}

		// Token: 0x06006CB7 RID: 27831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB7")]
		[Address(RVA = "0x14379D4", Offset = "0x14379D4", VA = "0x7BBBC379D4")]
		public void UpdateMenuData(List<CommonPopMenuData> list, BaseProfileInfo profileInfo)
		{
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB8")]
		[Address(RVA = "0x1437A58", Offset = "0x1437A58", VA = "0x7BBBC37A58")]
		public void UpdateMenuData(List<CommonPopMenuData> list, BaseProfileInfo profileInfo, Vector3 WindowPos)
		{
		}

		// Token: 0x06006CB9 RID: 27833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB9")]
		[Address(RVA = "0x1437E34", Offset = "0x1437E34", VA = "0x7BBBC37E34")]
		private void UpdateMenuDataInternal(List<CommonPopMenuData> list, BaseProfileInfo profileInfo, Vector3 WindowPos)
		{
		}

		// Token: 0x06006CBA RID: 27834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CBA")]
		[Address(RVA = "0x1439D58", Offset = "0x1439D58", VA = "0x7BBBC39D58")]
		private void RefreshContainer(float width)
		{
		}

		// Token: 0x06006CBB RID: 27835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CBB")]
		[Address(RVA = "0x143A4F0", Offset = "0x143A4F0", VA = "0x7BBBC3A4F0")]
		private void AddMask()
		{
		}

		// Token: 0x06006CBC RID: 27836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CBC")]
		[Address(RVA = "0x1437D10", Offset = "0x1437D10", VA = "0x7BBBC37D10")]
		private void RequestData()
		{
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CBD")]
		[Address(RVA = "0x1439B30", Offset = "0x1439B30", VA = "0x7BBBC39B30")]
		private void RefreshItem(float width)
		{
		}

		// Token: 0x06006CBE RID: 27838 RVA: 0x0001EAF8 File Offset: 0x0001CCF8
		[Token(Token = "0x6006CBE")]
		[Address(RVA = "0x1438368", Offset = "0x1438368", VA = "0x7BBBC38368")]
		private float RefreshProfile()
		{
			return 0f;
		}

		// Token: 0x06006CBF RID: 27839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CBF")]
		[Address(RVA = "0x143A998", Offset = "0x143A998", VA = "0x7BBBC3A998")]
		private void SetDefaultLanguage()
		{
		}

		// Token: 0x06006CC0 RID: 27840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC0")]
		[Address(RVA = "0x1438760", Offset = "0x1438760", VA = "0x7BBBC38760")]
		private void RefreshBattleTag()
		{
		}

		// Token: 0x06006CC1 RID: 27841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC1")]
		[Address(RVA = "0x1438F44", Offset = "0x1438F44", VA = "0x7BBBC38F44")]
		private void RefreshSocialTag()
		{
		}

		// Token: 0x06006CC2 RID: 27842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC2")]
		[Address(RVA = "0x1439788", Offset = "0x1439788", VA = "0x7BBBC39788")]
		private void RefreshDesc()
		{
		}

		// Token: 0x06006CC3 RID: 27843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC3")]
		[Address(RVA = "0x1436FA8", Offset = "0x1436FA8", VA = "0x7BBBC36FA8")]
		private void InitRank()
		{
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC4")]
		[Address(RVA = "0x1438628", Offset = "0x1438628", VA = "0x7BBBC38628")]
		private void RefreshRank()
		{
		}

		// Token: 0x06006CC5 RID: 27845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC5")]
		[Address(RVA = "0x143BAA4", Offset = "0x143BAA4", VA = "0x7BBBC3BAA4")]
		private void ShowBrLadder(int rank, uint rankpoint, UILabel go, UISprite spr)
		{
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC6")]
		[Address(RVA = "0x143AB58", Offset = "0x143AB58", VA = "0x7BBBC3AB58")]
		private void ShowBrRankInfo()
		{
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC7")]
		[Address(RVA = "0x143BE1C", Offset = "0x143BE1C", VA = "0x7BBBC3BE1C")]
		private void RefreshHeroicLevel(int rankPoint)
		{
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC8")]
		[Address(RVA = "0x143BE64", Offset = "0x143BE64", VA = "0x7BBBC3BE64")]
		private void RefreshHeroicMaxLevel(int rankPoint)
		{
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC9")]
		[Address(RVA = "0x143B67C", Offset = "0x143B67C", VA = "0x7BBBC3B67C")]
		private void ShowCsHistoryRankInfo(uint rank)
		{
		}

		// Token: 0x06006CCA RID: 27850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCA")]
		[Address(RVA = "0x143B180", Offset = "0x143B180", VA = "0x7BBBC3B180")]
		private void ShowCsCurrentRankInfo()
		{
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCB")]
		[Address(RVA = "0x143BEC0", Offset = "0x143BEC0", VA = "0x7BBBC3BEC0")]
		private void OnHeroicMarkBRIconClick()
		{
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCC")]
		[Address(RVA = "0x143BFB8", Offset = "0x143BFB8", VA = "0x7BBBC3BFB8")]
		private void OnHeroicMarkCSIconClick()
		{
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCD")]
		[Address(RVA = "0x143C0B0", Offset = "0x143C0B0", VA = "0x7BBBC3C0B0")]
		private void RefreshHeroicMarkInfo()
		{
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCE")]
		[Address(RVA = "0x143A578", Offset = "0x143A578", VA = "0x7BBBC3A578")]
		private void UpdateMenuDataWithFixedWidth(List<CommonPopMenuData> list, int width)
		{
		}

		// Token: 0x06006CCF RID: 27855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCF")]
		[Address(RVA = "0x143C73C", Offset = "0x143C73C", VA = "0x7BBBC3C73C", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006CD0 RID: 27856 RVA: 0x0001EB10 File Offset: 0x0001CD10
		[Token(Token = "0x6006CD0")]
		[Address(RVA = "0x143C84C", Offset = "0x143C84C", VA = "0x7BBBC3C84C", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006CD1 RID: 27857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD1")]
		[Address(RVA = "0x143C890", Offset = "0x143C890", VA = "0x7BBBC3C890")]
		public UIBriefBoxController()
		{
		}

		// Token: 0x04008835 RID: 34869
		[Token(Token = "0x4008835")]
		[FieldOffset(Offset = "0xE0")]
		private UIModelProfile m_Model;

		// Token: 0x04008836 RID: 34870
		[Token(Token = "0x4008836")]
		[FieldOffset(Offset = "0xE8")]
		private UIBriefBoxView m_View;

		// Token: 0x04008837 RID: 34871
		[Token(Token = "0x4008837")]
		[FieldOffset(Offset = "0xF0")]
		private LayoutTable m_Table;

		// Token: 0x04008838 RID: 34872
		[Token(Token = "0x4008838")]
		[FieldOffset(Offset = "0xF8")]
		private GridTableItem m_GridItem;

		// Token: 0x04008839 RID: 34873
		[Token(Token = "0x4008839")]
		[FieldOffset(Offset = "0x100")]
		private GridTableItem m_TagGridItem;

		// Token: 0x0400883A RID: 34874
		[Token(Token = "0x400883A")]
		[FieldOffset(Offset = "0x108")]
		private GridTableItem m_SocialTagGridItem;

		// Token: 0x0400883B RID: 34875
		[Token(Token = "0x400883B")]
		[FieldOffset(Offset = "0x110")]
		private BaseTableItem m_ProfileContainerItem;

		// Token: 0x0400883C RID: 34876
		[Token(Token = "0x400883C")]
		[FieldOffset(Offset = "0x118")]
		private float m_DefaultWidth;

		// Token: 0x0400883D RID: 34877
		[Token(Token = "0x400883D")]
		[FieldOffset(Offset = "0x120")]
		private ILayoutTableItem m_ScrollViewItem;

		// Token: 0x0400883E RID: 34878
		[Token(Token = "0x400883E")]
		[FieldOffset(Offset = "0x128")]
		private ILayoutTableItem m_DescTableItem;

		// Token: 0x0400883F RID: 34879
		[Token(Token = "0x400883F")]
		[FieldOffset(Offset = "0x130")]
		private UIBaseProfileInfoController m_Control;

		// Token: 0x04008840 RID: 34880
		[Token(Token = "0x4008840")]
		[FieldOffset(Offset = "0x138")]
		private List<CommonPopMenuData> m_MenuDatas;

		// Token: 0x04008841 RID: 34881
		[Token(Token = "0x4008841")]
		[FieldOffset(Offset = "0x140")]
		private Vector3 m_WindowPos;

		// Token: 0x04008842 RID: 34882
		[Token(Token = "0x4008842")]
		[FieldOffset(Offset = "0x150")]
		private BaseProfileInfo m_BaseProfileInfo;

		// Token: 0x04008843 RID: 34883
		[Token(Token = "0x4008843")]
		[FieldOffset(Offset = "0x158")]
		private AccountBriefInfo m_Data;

		// Token: 0x04008844 RID: 34884
		[Token(Token = "0x4008844")]
		[FieldOffset(Offset = "0x160")]
		private UIClickMask m_ClickMask;

		// Token: 0x04008845 RID: 34885
		[Token(Token = "0x4008845")]
		[FieldOffset(Offset = "0x168")]
		private bool m_HasRequestData;

		// Token: 0x04008846 RID: 34886
		[Token(Token = "0x4008846")]
		[FieldOffset(Offset = "0x170")]
		private List<ProfileTagView> m_ProfileTagItems;

		// Token: 0x04008847 RID: 34887
		[Token(Token = "0x4008847")]
		[FieldOffset(Offset = "0x178")]
		private List<ProfileTagView> m_SocialTagItems;

		// Token: 0x04008848 RID: 34888
		[Token(Token = "0x4008848")]
		[FieldOffset(Offset = "0x180")]
		private List<GameObject> m_StarList;

		// Token: 0x04008849 RID: 34889
		[Token(Token = "0x4008849")]
		[FieldOffset(Offset = "0x188")]
		private List<GameObject> m_BlackStarList;

		// Token: 0x0400884A RID: 34890
		[Token(Token = "0x400884A")]
		[FieldOffset(Offset = "0x190")]
		private List<GameObject> m_HistoryStarList;

		// Token: 0x0400884B RID: 34891
		[Token(Token = "0x400884B")]
		[FieldOffset(Offset = "0x198")]
		private List<GameObject> m_HistoryBlackStarList;

		// Token: 0x0400884C RID: 34892
		[Token(Token = "0x400884C")]
		[FieldOffset(Offset = "0x1A0")]
		private TweenPosition m_TweenPos;

		// Token: 0x0400884D RID: 34893
		[Token(Token = "0x400884D")]
		[FieldOffset(Offset = "0x1A8")]
		private TweenScale m_TweenScale;

		// Token: 0x0400884E RID: 34894
		[Token(Token = "0x400884E")]
		[FieldOffset(Offset = "0x1B0")]
		private Vector3 m_FromPos;

		// Token: 0x0400884F RID: 34895
		[Token(Token = "0x400884F")]
		[FieldOffset(Offset = "0x1C0")]
		private GameObject m_CacheHeroicBREffect;

		// Token: 0x04008850 RID: 34896
		[Token(Token = "0x4008850")]
		[FieldOffset(Offset = "0x1C8")]
		private GameObject m_CacheHeroicCSEffect;
	}
}
